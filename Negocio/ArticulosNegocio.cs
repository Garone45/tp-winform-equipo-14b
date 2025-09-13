using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Security.AccessControl;

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
                comando.CommandText = "\r\nSELECT \r\n    A.Id,\r\n    A.Codigo,\r\n    A.Nombre,\r\n    A.Descripcion,\r\n    M.Descripcion AS Marca,\r\n    C.Descripcion AS Categoria,\r\n    A.IdMarca,\r\n    A.IdCategoria,\r\n    A.Precio,\r\n    I.ImagenUrl\r\nFROM \r\n    Articulos A\r\nINNER JOIN Marcas M ON M.Id = A.IdMarca\r\nINNER JOIN Categorias C ON C.Id = A.IdCategoria\r\nLEFT JOIN Imagenes I ON I.IdArticulo = A.Id";//"Select A.Id, Codigo, Nombre, A.Descripcion,M.Descripcion Marca,C.Descripcion Categoria,A.IdMarca,A.IdCategoria,A.Id, Precio From Articulos A, Marcas M, CATEGORIAS C where M.id = A.idMarca and C.id = A.idCategoria";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.IDArticulo = (int)lector["Id"];
                    aux.Marca = new Marcas();
                    aux.Marca.IDMarca = (int)lector["IdMarca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IDCategoria = (int)lector["IdCategoria"];

                    aux.IDArticulo = (int)lector["Id"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.CodigoArticulo = (string)lector["Codigo"];
                    aux.Descripcion = (string)lector["Descripcion"];
                   // aux.UrlImagen = (string)lector["ImagenUrl"];

                    if (!(lector["Marca"] is DBNull))
                    aux.Marca.Descripcion = (string)lector ["Marca"];
                    if (!(lector["Categoria"] is DBNull))
                    aux.Categoria.Descripcion = (string)lector["Categoria"];
                    if (!(lector["Precio"] is DBNull))
                    aux.Precio = Convert.ToDecimal(lector["Precio"]);

                    aux.Imagen = new Imagen();
                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.Imagen.UrlImagen = (string)lector["ImagenUrl"];
                    else
                        aux.Imagen.UrlImagen = "";


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
           
        public void modificar(Articulos articulos)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Articulos set Nombre = @nombre, Codigo = @codigo, Descripcion = @descripcion, IdMarca = @idTipo, IdCategoria = @idDebilidad where Id = @id");
                datos.setearParametro("@nombre", articulos.Nombre);
                datos.setearParametro("@codigo", articulos.CodigoArticulo);
                datos.setearParametro("@descripcion", articulos.Descripcion);
                datos.setearParametro("@idTipo", articulos.Marca.IDMarca);
                datos.setearParametro("@idDebilidad", articulos.Categoria.IDCategoria);
                datos.setearParametro("@id", articulos.IDArticulo);
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

        public void eliminar (int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from articulos where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
