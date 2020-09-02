using System;
using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer;
using NeptunoSql.DataLayer.Repositorios;
using NeptunoSql.DataLayer.Repositorios.Facades;
using NeptunoSql.ServiceLayer.Servicios.Facades;

namespace NeptunoSql.ServiceLayer.Servicios
{
    public class ServicioCategorias : IServicioCategorias
    {
        private ConexionBd _conexion;
        private IRepositorioCategorias _repositorio;

        public ServicioCategorias()
        {

        }
        public Categoria GetCategoriaPorId(int id)
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioCategorias(_conexion.AbrirConexion());
                var categoria = _repositorio.GetCategoriaPorId(id);
                _conexion.CerrarConexion();
                return categoria;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public List<Categoria> GetLista()
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioCategorias(_conexion.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Categoria categoria)
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioCategorias(_conexion.AbrirConexion());
                _repositorio.Guardar(categoria);
                _conexion.CerrarConexion();
                
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int id)
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioCategorias(_conexion.AbrirConexion());
                _repositorio.Borrar(id);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Categoria categoria)
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioCategorias(_conexion.AbrirConexion());
                var existe = _repositorio.Existe(categoria);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Categoria categoria)
        {
            return false;
        }
    }
}
