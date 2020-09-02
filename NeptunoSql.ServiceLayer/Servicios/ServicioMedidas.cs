using System;
using System.Collections.Generic;
using NeptunoSql.BusinessLayer.Entities;
using NeptunoSql.DataLayer;
using NeptunoSql.DataLayer.Repositorios;
using NeptunoSql.DataLayer.Repositorios.Facades;
using NeptunoSql.ServiceLayer.Servicios.Facades;

namespace NeptunoSql.ServiceLayer.Servicios
{
    public class ServicioMedidas:IServicioMedidas
    {
        private ConexionBd _conexion;
        private IRepositorioMedidas _repositorio;
        public ServicioMedidas()
        {
            
        }
        public Medida GetMedidaPorId(int id)
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioMedidas(_conexion.AbrirConexion());
                return _repositorio.GetMedidaPorId(id);

            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }

        }

        public List<Medida> GetLista()
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioMedidas(_conexion.AbrirConexion());
                var lista = _repositorio.GetLista();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Medida medida)
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioMedidas(_conexion.AbrirConexion());
                _repositorio.Guardar(medida);
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
                _repositorio=new RepositorioMedidas(_conexion.AbrirConexion());
                _repositorio.Borrar(id);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Medida medida)
        {
            try
            {
                _conexion=new ConexionBd();
                _repositorio=new RepositorioMedidas(_conexion.AbrirConexion());
                var existe = _repositorio.Existe(medida);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ExisteAbreviatura(Medida medida)
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorio = new RepositorioMedidas(_conexion.AbrirConexion());
                var existe = _repositorio.ExisteAbreviatura(medida);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Medida medida)
        {
            return false;
        }
    }
}
