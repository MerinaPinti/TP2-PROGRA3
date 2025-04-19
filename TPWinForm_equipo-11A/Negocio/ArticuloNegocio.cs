using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //5. libreria para establecer la conexion y leer los datos de la BD
using System.Xml.Linq;
using Dominio;
using System.Net.Configuration;
using Negocio;




namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar() //1. Metodo para que lea los registros de la base de datos
        {
            /*List<Articulo> lista = new List<Articulo> ();//2. crea la lista
            //6. Una vez que agregue la libreria voy a poder crear los objetos que me permitan usar la BDD
            //6a conexion de la BDD
            SqlConnection conexion = new SqlConnection ();
            //6b una vez conectada la BDD voy a realiar acciones
            SqlCommand comando = new SqlCommand ();
            //6c los datos obtenidos los recolecto dentro de un lector de datos
            SqlDataReader lector; 

            //4. Manejo de excepcion
            try //4a devuelve la lista si no hay inconvenientes
            {
                //7. una vez creados los objetos los tengo que configurar
                //7a cadena de conexion. indica la direccion de la BDD que vamos a usar

                //CONEXION JOHAN
                conexion.ConnectionString = "server=localhost,1433; database=CATALOGO_P3_DB; user id=sa; password=Johann123";
                //CONEXIÓN MERI
                //conexion.ConnectionString = "server=.\\SQLEXPRESS01; database=CATALOGO_P3_DB; integrated security=true";
                //CONEXION NORMAL
                //conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                //7b configuracion del comando de texto
                comando.CommandType = System.Data.CommandType.Text;
                //7c configuracion del contenido del texto (consulta) que va a contener el comando
                comando.CommandText = "SELECT A.ID, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.Precio, I.ImagenUrl FROM ARTICULOS A INNER JOIN MARCAS M ON A.IDMarca = M.ID INNER JOIN CATEGORIAS C ON A.IDCategoria = C.ID LEFT JOIN IMAGENES I ON A.ID = I.IDArticulo";

                //comando.CommandText = "SELECT A.ID, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.Precio FROM ARTICULOS A INNER JOIN MARCAS M ON A.IDMarca = M.ID INNER JOIN CATEGORIAS C ON A.IDCategoria = C.ID";

                //7d ejecuta el comando en la direccion que agregue en 7A
                comando.Connection = conexion;
                //7e abrir la conexion
                conexion.Open();
                //7f realizo la lectura de la BDD y se lo asigno al lector que cree al principio
                lector = comando.ExecuteReader (); //con esto ya tengo una especie puntero a una tabla virtual

                //8. leemos el contenido de "lector" para transformar la tabla en una coleccion de objetos
                while (lector.Read()) //8a mientras encuentre objetos en la lista va a ser TRUE y va a crear una copia
                {
                    //9. creo un objeto auxiliar
                    Articulo aux = new Articulo();
                    //Le mandamos posición de la tabla 
                    aux.ID = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Marca = new Marcas();
                    //aux.Marca.ID = lector.GetInt32(4); 
                    aux.Marca.Descripcion = lector["Marca"].ToString();
                    aux.Categoria = new Categorias();
                    //Se hizo un override a la función TOSTRING para que devuelva la descripción en ambos casos. No se realiza casteo porque al trabajar con un objeto directamente no es posible 
                    //aux.Categoria.ID = lector.GetInt32(5);
                    aux.Categoria.Descripcion = lector["Categoria"].ToString();
                    aux.Precio = lector["Precio"] != DBNull.Value ? Convert.ToSingle(lector["Precio"]) : 0;
                    //aux.Precio = (float)lector["Precio"];

                    aux.Imagen = new Imagenes();
                    aux.Imagen.ImagenUrl = lector["ImagenUrl"] != DBNull.Value ? lector["ImagenUrl"].ToString() : null;

                    //aux.Imagen = new Imagenes();
                    
                    //aux.Imagen = lector["ImagenUrl"] != DBNull.Value ? lector["ImagenUrl"].ToString() : null;

                    //aux.ImagenUrl = (string)lector["ImagenUrl"];
                    //aux.Imagen.ImagenUrl = lector["ImagenUrl"].ToString();
                    // aux.ImagenUrl.ImagenUrl = lector["ImagenUrl"].ToString();



                    //aux.ImagenUrl = (string)lector["ImagenUrl"];

                    //10. agrego el objeto a la lista
                    lista.Add(aux);
                } // 11. cuando no tenga mas objetos va a marcar FALSE y va a retornar la lista (3) o una excepcion (4b)

                conexion.Close (); //12. cierra la conexion cuando termina de leer la BDD
                return lista; //3. devuelve la lista de articulos
            }
            catch (Exception ex) //4b devuelve un error si hay inconvenientes
            {
                
                throw ex;
            }*/

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("SELECT A.ID, A.Codigo, A.Nombre, A.Descripcion, M.Id AS IDMarca, M.Descripcion AS Marca, C.Id AS IDCategoria, C.Descripcion AS Categoria, A.Precio, I.ImagenUrl FROM ARTICULOS A INNER JOIN MARCAS M ON A.IDMarca = M.ID INNER JOIN CATEGORIAS C ON A.IDCategoria = C.ID LEFT JOIN IMAGENES I ON A.ID = I.IDArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.ID = datos.Lector.GetInt32(0);
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marcas();

                    aux.ID_Marca = Convert.ToInt32(datos.Lector["IDMarca"]);


                    //aux.Marca.ID = Convert.ToInt32(datos.Lector["IDMarca"]);
                    aux.Marca.Descripcion = datos.Lector["Marca"].ToString();
                    aux.Categoria = new Categorias();
                    aux.ID_Categoria = Convert.ToInt32(datos.Lector["IDCategoria"]);
                    //aux.Categoria.ID = Convert.ToInt32(datos.Lector["IDCategoria"]);
                    aux.Categoria.Descripcion = datos.Lector["Categoria"].ToString();
                    aux.Precio = datos.Lector["Precio"] != DBNull.Value ? Convert.ToSingle(datos.Lector["Precio"]) : 0;
                    aux.Imagen = new Imagenes();
                    aux.Imagen.ImagenUrl = datos.Lector["ImagenUrl"] != DBNull.Value ? datos.Lector["ImagenUrl"].ToString() : "";
                    

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
        public void agregarArticulo(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio, IDMarca, IDCategoria) values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "'," + nuevo.Precio + ", @IDMarca, @IDCategoria)");
                datos.setearParametros("@IDMarca", nuevo.Marca.ID);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.ID);
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

            datos = new AccesoDatos();

            try
            {
                if (!string.IsNullOrEmpty(nuevo.Imagen.ImagenUrl))
                {

                    datos.setearConsulta(@"insert into IMAGENES (IdArticulo, ImagenUrl) values (@IdArticulo, @ImagenUrl)");
                    datos.setearParametros("@IdArticulo", nuevo.ID);
                    datos.setearParametros("@ImagenUrl", nuevo.Imagen.ImagenUrl);
                    datos.ejecutarAccion();
                }
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

