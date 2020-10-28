using System;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer;
using NeptunoSql.DataLayer.Repositorios;
using NeptunoSql.DataLayer.Repositorios.Facades;
using NeptunoSql.ServiceLayer.Servicios.Facades;

namespace NeptunoSql.ServiceLayer.Servicios
{
    public class ServicioAnulacionVentas:IServicioAnulacionVentas
    {
        private IRepositorioAnulacionesVentas _repositorioAnulacionesVentas;
        private IRepositorioDetalleAnulacionesVentas _repositorioDetalleAnulaciones;
        private IRepositorioProductos _repositorioProductos;
        private IRepositorioKardex _repositorioKardex;
        private ConexionBd _conexion;

        public ServicioAnulacionVentas()
        {

        }
        public void Guardar(AnulacionVenta anulacionVenta)
        {
            _conexion = new ConexionBd();
            SqlTransaction tran = null;
            try
            {
                SqlConnection cn = _conexion.AbrirConexion();
                tran = cn.BeginTransaction();
                _repositorioAnulacionesVentas = new RepositorioAnulacionesVentas(cn, tran);
                _repositorioProductos = new RepositorioProductos(cn, tran);
                _repositorioDetalleAnulaciones = new RepositorioDetalleAnulacionesVentas(cn, tran);
                _repositorioKardex = new RepositorioKardex(cn, tran);

                _repositorioAnulacionesVentas.Guardar(anulacionVenta);
                foreach (var detalleAnulacion in anulacionVenta.DetalleAnulacion)
                {
                    detalleAnulacion.AnulacionVenta = anulacionVenta;

                    Kardex kardex = _repositorioKardex.GetUltimoKardex(detalleAnulacion.Producto);
                    if (kardex == null)
                    {
                        kardex = new Kardex();
                        kardex.Producto = detalleAnulacion.Producto;
                        kardex.Fecha = anulacionVenta.Fecha;
                        kardex.Movimiento = $"Anulacion Venta Nro {anulacionVenta.AnulacionId}";
                        kardex.Entrada = detalleAnulacion.Cantidad;
                        kardex.Salida = 0;
                        kardex.Saldo = detalleAnulacion.Cantidad;
                    }
                    else
                    {
                        kardex.Fecha = anulacionVenta.Fecha;
                        kardex.Movimiento = $"Anulacion Venta Nro {anulacionVenta.AnulacionId}";
                        kardex.Entrada = detalleAnulacion.Cantidad;
                        kardex.Salida = 0;
                        kardex.Saldo += detalleAnulacion.Cantidad;

                    }
                    _repositorioKardex.Guardar(kardex);
                    detalleAnulacion.Kardex = kardex;
                    _repositorioDetalleAnulaciones.Guardar(detalleAnulacion);
                    _repositorioProductos.ActualizarStock(detalleAnulacion.Producto,
                        detalleAnulacion.Cantidad);
                }
                tran.Commit();
            }
            catch (Exception e)
            {
                tran.Rollback();
                throw new Exception(e.Message);
            }
        }
    }
}
