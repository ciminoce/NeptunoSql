using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer;
using NeptunoSql.DataLayer.Repositorios;
using NeptunoSql.DataLayer.Repositorios.Facades;
using NeptunoSql.ServiceLayer.Servicios.Facades;

namespace NeptunoSql.ServiceLayer.Servicios
{
    public class ServicioVenta:IServicioVentas
    {
        private IRepositorioVentas _repositorioVentas;
        private IRepositorioDetalleVentas _repositorioDetalleVentas;
        private IRepositorioProductos _repositorioProductos;
        private IRepositorioKardex _repositorioKardex;

        private IRepositorioAnulacionesVentas _repositorioAnulaciones;
        private IRepositorioDetalleAnulacionesVentas _repositorioDetalleAnulaciones;
        private ConexionBd _conexion;

        public ServicioVenta()
        {

        }
        public void Guardar(Venta venta)
        {
            _conexion = new ConexionBd();
            SqlTransaction tran = null;
            try
            {
                SqlConnection cn = _conexion.AbrirConexion();
                tran = cn.BeginTransaction();
                _repositorioVentas = new RepositorioVentas(cn, tran);
                _repositorioProductos = new RepositorioProductos(cn, tran);
                _repositorioDetalleVentas = new RepositorioDetalleVentas(cn, tran);
                _repositorioKardex = new RepositorioKardex(cn, tran);

                _repositorioVentas.Guardar(venta);
                foreach (var detalleVenta in venta.DetalleVentas)
                {
                    detalleVenta.Venta = venta;
                    Kardex kardex = _repositorioKardex.GetUltimoKardex(detalleVenta.Producto);
                    if (kardex == null)
                    {
                        kardex = new Kardex();
                        kardex.Producto = detalleVenta.Producto;
                        kardex.Fecha = venta.Fecha;
                        kardex.Movimiento = $"Venta Nro {venta.VentaId}";
                        kardex.Entrada = 0;
                        kardex.Salida = detalleVenta.Cantidad;
                        kardex.Saldo = -detalleVenta.Cantidad;
                    }
                    else
                    {
                        kardex.Fecha = venta.Fecha;
                        kardex.Movimiento = $"Venta Nro {venta.VentaId}";
                        kardex.Entrada = 0;
                        kardex.Salida = detalleVenta.Cantidad;
                        kardex.Saldo -= detalleVenta.Cantidad;

                    }
                    _repositorioKardex.Guardar(kardex);
                    detalleVenta.Kardex = kardex;
                    _repositorioDetalleVentas.Guardar(detalleVenta);
                    _repositorioProductos.ActualizarStock(detalleVenta.Producto,
                        -detalleVenta.Cantidad);
                }
                tran.Commit();
            }
            catch (Exception e)
            {
                tran.Rollback();
                throw new Exception(e.Message);
            }
        }

        public decimal GetTotalVenta(int ventaId)
        {
            _conexion = new ConexionBd();
            _repositorioVentas = new RepositorioVentas(_conexion.AbrirConexion());
            var p = _repositorioVentas.GetTotalVenta(ventaId);
            _conexion.CerrarConexion();
            return p;

        }

        public void FacturarVenta(int ventaId)
        {
            _conexion = new ConexionBd();
            _repositorioVentas = new RepositorioVentas(_conexion.AbrirConexion());
            _repositorioVentas.FacturarVenta(ventaId);
            _conexion.CerrarConexion();

        }

        public void AnularVenta(Venta venta)
        {
            _conexion = new ConexionBd();
            SqlTransaction tran = null;
            try
            {
                SqlConnection cn = _conexion.AbrirConexion();
                tran = cn.BeginTransaction();
                _repositorioVentas = new RepositorioVentas(cn, tran);
                _repositorioProductos = new RepositorioProductos(cn, tran);
                _repositorioAnulaciones=new RepositorioAnulacionesVentas(cn,tran);
                _repositorioDetalleAnulaciones = new RepositorioDetalleAnulacionesVentas(cn, tran);
                _repositorioKardex = new RepositorioKardex(cn, tran);

                var anulacion = ConstruirAnulacion(venta);
                _repositorioVentas.AnularVenta(venta.VentaId);//cambio el estado a la venta
                _repositorioAnulaciones.Guardar(anulacion);//guardo la anulación
                
                //guardo los detalles de anulacion
                foreach (var detalleAnulacion in anulacion.DetalleAnulacion)
                {
                    detalleAnulacion.AnulacionVenta = anulacion;
                    Kardex kardex = _repositorioKardex.GetUltimoKardex(detalleAnulacion.Producto);
                    if (kardex == null)
                    {
                        kardex = new Kardex();
                        kardex.Producto = detalleAnulacion.Producto;
                        kardex.Fecha = venta.Fecha;
                        kardex.Movimiento = $"Anulación Nro {venta.VentaId}";
                        kardex.Entrada = detalleAnulacion.Cantidad;
                        kardex.Salida = 0;
                        kardex.Saldo = detalleAnulacion.Cantidad;
                    }
                    else
                    {
                        kardex.Fecha = venta.Fecha;
                        kardex.Movimiento = $"Anulación Nro {venta.VentaId}";
                        kardex.Entrada = detalleAnulacion.Cantidad;
                        kardex.Salida = 0;
                        kardex.Saldo += detalleAnulacion.Cantidad;

                    }
                    _repositorioKardex.Guardar(kardex);
                    detalleAnulacion.Kardex = kardex;
                    _repositorioDetalleAnulaciones.Guardar(detalleAnulacion);
                    _repositorioProductos.ActualizarStock(detalleAnulacion.Producto,
                        -detalleAnulacion.Cantidad);
                }
                tran.Commit();
            }
            catch (Exception e)
            {
                tran.Rollback();
                throw new Exception(e.Message);
            }

        }

        private AnulacionVenta ConstruirAnulacion(Venta venta)
        {
            return new AnulacionVenta
            {
                Venta = venta,
                Fecha = DateTime.Now,
                Referencia = "0000012",
                DetalleAnulacion = ConstruirDetalleAnulacion(venta.DetalleVentas)
            };
        }

        private List<DetalleAnulacionVenta> ConstruirDetalleAnulacion(List<DetalleVenta> detalle)
        {
            var lista = new List<DetalleAnulacionVenta>();
            foreach (var detalleVenta in detalle)
            {
                var detalleAnulacion = new DetalleAnulacionVenta
                {
                    Producto = detalleVenta.Producto,
                    Cantidad = detalleVenta.Cantidad,

                };
                lista.Add(detalleAnulacion);
            }

            return lista;
        }
    }
}
