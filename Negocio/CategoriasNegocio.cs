using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriasNegocio
    {
        public List<Categoria> listar()
        {

            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos(); // Generar instancia del acceso a datos.

            try 
            {

                datos.setearConsulta("select id Descripcion from CATEGORIAS");// Lo mismo que en articuloNegocio pero trabajado con la clase AccesoDatos.
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IDCategoria = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
                  
            }

            catch (Exception ex) 
            {
                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();

            }




        }
    }
}
