using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categorias> listar() //1. Metodo para que lea los registros de la base de datos
        {
            List<Categorias> lista = new List<Categorias>();//2. crea la lista
            //6. Una vez que agregue la libreria voy a poder crear los objetos que me permitan usar la BDD
            //6a conexion de la BDD
            SqlConnection conexion = new SqlConnection();
            //6b una vez conectada la BDD voy a realiar acciones
            SqlCommand comando = new SqlCommand();
            //6c los datos obtenidos los recolecto dentro de un lector de datos
            SqlDataReader lector;

            //4. Manejo de excepcion
            try //4a devuelve la lista si no hay inconvenientes
            {
                //7. una vez creados los objetos los tengo que configurar
                //7a cadena de conexion. indica la direccion de la BDD que vamos a usar
                //CONEXIÓN MERI
                conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true";
                //CONEXION NORMAL
                //conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                //7b configuracion del comando de texto
                comando.CommandType = System.Data.CommandType.Text;
                //7c configuracion del contenido del texto (consulta) que va a contener el comando
                comando.CommandText = "Select id, Descripcion FROM CATEGORIAS";
                //7d ejecuta el comando en la direccion que agregue en 7A
                comando.Connection = conexion;
                //7e abrir la conexion
                conexion.Open();
                //7f realizo la lectura de la BDD y se lo asigno al lector que cree al principio
                lector = comando.ExecuteReader(); //con esto ya tengo una especie puntero a una tabla virtual

                //8. leemos el contenido de "lector" para transformar la tabla en una coleccion de objetos
                while (lector.Read()) //8a mientras encuentre objetos en la lista va a ser TRUE y va a crear una copia
                {
                    //9. creo un objeto auxiliar
                    Categorias aux = new Categorias();
                    aux.ID = lector.GetInt32 (0); //Cuando hacemos un get debemos elegir el tipo de dato adecuado, y entre paréntesis va la posición de los campos en el orden del select ejemplo el 0 es "ID" 
                    aux.Descripcion = (string)lector["Descripcion"];
                 

                    //10. agrego el objeto a la lista
                    lista.Add(aux);
                } // 11. cuando no tenga mas objetos va a marcar FALSE y va a retornar la lista (3) o una excepcion (4b)

                conexion.Close(); //12. cierra la conexion cuando termina de leer la BDD
                return lista; //3. devuelve la lista de articulos
            }
            catch (Exception ex) //4b devuelve un error si hay inconvenientes
            {

                throw ex;
            }

        }
    }



}

