using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class AccesoDatos
    {
        //objetos para la conexión
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        //le damos la posibilidad de acceder al lector desde afuera sólo para leerlo NO escribirlo. 
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        //Constructor para la conexion 
        public AccesoDatos()

        {
            //Cuando lo creo le asigno la conexión directamente
            conexion = new SqlConnection(
                //CONEXIÓN MERI
                "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true"
                //CONEXION NORMAL
                //"server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true"
                //CONEXION JOHAN
                //"server=localhost,1433; database=CATALOGO_P3_DB; user id=sa; password=Johann123"

                );
            comando = new SqlCommand();

        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

                throw ex;
            }
        }

        public void setearParametros(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void cerrarConexion()
        {
            //si realicé una lectura cierrro el lector si es que hay realizandose una conexión y sino también. 
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();

        }

        public int ejecutarScalar()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                object resultado = comando.ExecuteScalar();
                return Convert.ToInt32(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
