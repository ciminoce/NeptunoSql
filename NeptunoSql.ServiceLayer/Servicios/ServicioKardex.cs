using System.Collections.Generic;
using System.Data.SqlClient;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer;
using NeptunoSql.DataLayer.Repositorios;
using NeptunoSql.DataLayer.Repositorios.Facades;
using NeptunoSql.ServiceLayer.Servicios.Facades;

namespace NeptunoSql.ServiceLayer.Servicios
{
    public class ServicioKardex:IServicioKardex
    {
        private IRepositorioKardex _repositorioKardex;
        private ConexionBd _conexion;


        public ServicioKardex()
        {
            
        }
        public List<Kardex> ConsultaKardex(Producto producto)
        {
            _conexion = new ConexionBd();
            _repositorioKardex=new RepositorioKardex(_conexion.AbrirConexion());
            var lista = _repositorioKardex.ConsultaKardex(producto);
            _conexion.CerrarConexion();
            return lista;

        }

    }
}
