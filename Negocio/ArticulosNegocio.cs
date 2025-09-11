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
                comando.CommandText = "Select A.Id, Codigo, Nombre, A.Descripcion,M.Descripcion Marca,C.Descripcion Categoria, Precio From Articulos A, Marcas M, CATEGORIAS C where M.id = A.idMarca and C.id = A.idCategoria";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Marca = new Marcas();
                    aux.Categoria = new Categoria();

                    aux.IDArticulo = (int)lector["Id"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    if (!(lector["Marca"] is DBNull))
                    aux.Marca.Descripcion = (string)lector ["Marca"];
                    if (!(lector["Categoria"] is DBNull))
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    if (!(lector["Precio"] is DBNull))
                    aux.Precio = Convert.ToDecimal(lector["Precio"]);


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

                datos.setearConsulta("INSERT INTO Articulos (Nombre, Codigo, Descripcion,IdMarca,IdCategoria) VALUES (@nombre, @codigo, @descripcion,@idTipo, @idDebilidad)"); //creacion de "variable" para setear con el nuevo valor articulos.

                datos.setearParametro("@nombre", articulos.Nombre);
                datos.setearParametro("@codigo", articulos.CodigoArticulo);
                datos.setearParametro("@descripcion", articulos.Descripcion);
                datos.setearParametro("@idTipo", articulos.Marca.IDMarca);
                datos.setearParametro("@idDebilidad", articulos.Categoria.IDCategoria);


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
