using System;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer;
using NeptunoSql.DataLayer.Repositorios;
using NeptunoSql.DataLayer.Repositorios.Facades;
using NeptunoSql.ServiceLayer.Servicios.Facades;

namespace NeptunoSql.ServiceLayer.Servicios
{
    public class ServicioIngresos:IServicioIngresos
    {
        private IRepositorioIngresos _repositorioIngresos;
        private IRepositorioDetalleIngresos _repositorioDetalleIngresos;
        private IRepositorioProductos _repositorioProductos;
        private IRepositorioKardex _repositorioKardex;
        private ConexionBd _conexion;

        public ServicioIngresos()
        {
            
        }
        public void Guardar(Ingreso ingreso)
        {
           _conexion=new ConexionBd();
           SqlTransaction tran = null;
           try
           {
               SqlConnection cn = _conexion.AbrirConexion();
               tran = cn.BeginTransaction();
               _repositorioIngresos=new RepositorioIngresos(cn, tran);
               _repositorioProductos=new RepositorioProductos(cn,tran);
               _repositorioDetalleIngresos=new RepositorioDetalleIngresos(cn,tran);
               _repositorioKardex=new RepositorioKardex(cn,tran);

               _repositorioIngresos.Guardar(ingreso);
               foreach (var detalleIngreso in ingreso.DetalleIngresos)
               {
                   detalleIngreso.Ingreso = ingreso;
                   Kardex kardex = _repositorioKardex.GetUltimoKardex(detalleIngreso.Producto);
                   if (kardex==null)
                   {
                       kardex=new Kardex();
                       kardex.Producto = detalleIngreso.Producto;
                       kardex.Fecha = ingreso.Fecha;
                       kardex.Movimiento = $"Ingreso Nro {ingreso.IngresoId}";
                       kardex.Entrada = detalleIngreso.Cantidad;
                       kardex.Salida = 0;
                       kardex.Saldo = detalleIngreso.Cantidad;
                   }
                   else
                   {
                       kardex.Fecha = ingreso.Fecha;
                       kardex.Movimiento = $"Ingreso Nro {ingreso.IngresoId}";
                       kardex.Entrada = detalleIngreso.Cantidad;
                       kardex.Salida = 0;
                       kardex.Saldo += detalleIngreso.Cantidad;
                       
                   }
                   _repositorioKardex.Guardar(kardex);
                   detalleIngreso.Kardex = kardex;
                   _repositorioDetalleIngresos.Guardar(detalleIngreso);
                   _repositorioProductos.ActualizarStock(detalleIngreso.Producto,
                       detalleIngreso.Cantidad);
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
