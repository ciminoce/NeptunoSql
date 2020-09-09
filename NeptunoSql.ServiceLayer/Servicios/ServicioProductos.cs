using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer;
using NeptunoSql.DataLayer.Repositorios;
using NeptunoSql.DataLayer.Repositorios.Facades;
using NeptunoSql.ServiceLayer.Servicios.Facades;

namespace NeptunoSql.ServiceLayer.Servicios
{
    public class ServicioProductos:IServicioProductos
    {
        private IRepositorioProductos _repositorioProductos;
        private IRepositorioMarcas _repositorioMarcas;
        private IRepositorioCategorias _repositorioCategorias;
        private IRepositorioMedidas _repositorioMedidas;
        private ConexionBd _conexion;
        public Producto GetProductoPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Producto> GetLista()
        {
            _conexion=new ConexionBd();
            _repositorioMarcas=new RepositorioMarcas(_conexion.AbrirConexion());
            _repositorioCategorias=new RepositorioCategorias(_conexion.AbrirConexion());
            _repositorioMedidas=new RepositorioMedidas(_conexion.AbrirConexion());
            _repositorioProductos=new RepositorioProductos(_conexion.AbrirConexion(),_repositorioMarcas,
                _repositorioCategorias,_repositorioMedidas);
            var lista = _repositorioProductos.GetLista();
            _conexion.CerrarConexion();
            return lista;

        }

        public void Guardar(Producto producto)
        {
            throw new System.NotImplementedException();
        }

        public void Borrar(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Existe(Producto producto)
        {
            throw new System.NotImplementedException();
        }

        public bool EstaRelacionado(Producto producto)
        {
            throw new System.NotImplementedException();
        }
    }
}
