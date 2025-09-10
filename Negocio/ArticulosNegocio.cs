using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticulosNegocio
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security=true ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Id, Codigo, Nombre, Descripcion,IdMarca, IdCategoria, Precio From Articulos";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    //aux.Nombre = lector.GetString(1);
                    aux.IDArticulo = (int)lector["Id"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    // aux.Precio = (decimal)lector["Precio"];

                    //aux.Marca = (Marcas)lector["IdMarca"];
                    //aux.Categoria = (Categoria)lector["IdCategoria"];


                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void agregar(Articulos articulos)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                ///revisar
                //datos.setearConsulta("insert into Articulos (Nombre,Codigo,Descripcion,) values (" + articulos.Nombre + ",'" + ",'" + articulos.CodigoArticulo + ",'" + articulos.Descripcion);
                //datos.cerrarConexion();

                datos.setearConsulta("INSERT INTO Articulos (Nombre, Codigo, Descripcion) VALUES (@nombre, @codigo, @descripcion)"); //creacion de "variable" para setear con el nuevo valor articulos.

                datos.setearParametro("@nombre", articulos.Nombre);
                datos.setearParametro("@codigo", articulos.CodigoArticulo);
                datos.setearParametro("@descripcion", articulos.Descripcion);

                datos.ejecutarAccion();

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
