using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marcas> listar() 
        {
            List<Marcas> lista = new List<Marcas>();
            AccesoDatos datos = new AccesoDatos();


            try
            {

                datos.setearConsulta("Select id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();
                    aux.ID = datos.Lector.GetInt32(0); //Cuando hacemos un get debemos elegir el tipo de dato adecuado, y entre paréntesis va la posición de los campos en el orden del select ejemplo el 0 es "ID" 
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
