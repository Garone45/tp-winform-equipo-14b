using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Configuration;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector // De este modo leemos el lector desde afuera.
        {
            get { return Lector; }
        }

        public AccesoDatos() //Constructor
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security=true ");
            comando = new SqlCommand();
        }
        public void setearConsulta(string consulta) // Encapsulamos consulta
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarLectura() // Metodo para ejecutar lectura y guardar en el lector
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector=comando.ExecuteReader();

            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        public void cerrarConexion()
        {
            if(lector!=null) 
            conexion.Close();
            lector.Close();
           
        }



    }
}
