using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio; 

namespace TPWinForm_equipo_11A
{
    public partial class Frm_ListarArticulos : Form
    {
        private List<Articulo> lista;
        public Frm_ListarArticulos()
        {
            InitializeComponent();

        }

        private void dgv_listadoArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// Evento que se acciona cuando presionamos "LISTAR->ARCHIVOS" de Toolstrip 


        private void Frm_ListarArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            lista = negocio.listar();
            dgv_listadoArticulos.DataSource = lista;
            //Ocultamos la url de la imagen en el registro 
            //dgv_listadoArticulos.Columns["ImagenUrl"].Visible = false;
            //cargarImagen(lista[0].Imagen.ToString());
        }

        private void dgv_listadoArticulos_SelectionChanged(object sender, EventArgs e)
        {
            //Current row es el registro de la lista seleccionado (ACTUAL) 
            //cada fila tiene un objeto enlazado y le pedimos que nos devuelva el objeto. Para poder manejar de manera genérica un objeto y modelarlo internamente lo maneja como object 
            //Cuando devuelve siempre devuelve un objeto, pero sabemos que ese object es un tipo pokemon (porque le dimos una lista de pokemons) entonces lo casteamos para guardarlo en un avariable pokemon 
            //dgv_pokemons.CurrentRow.DataBoundItem;

            Articulo seleccionado = (Articulo)dgv_listadoArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.ToString());
        }


        //Si no puede cargar la imagen muestra una imagen por defecto
        /*  private void cargarImagen(string imagen)
          {

             try
              {

                  pb_articulos.Load(imagen);
              }
              catch (Exception ex)
              {
                  pb_articulos.Load("https://codigogenesis.com/genesis/2022/04/imagen-placeholder-por-defecto-WooCommerce.png");
                  throw;
              }
          }*/


        private void cargarImagen(string imagen)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagen))
                {
                    pb_articulos.Load(imagen);
                }
                else
                {
                    pb_articulos.Load("https://codigogenesis.com/genesis/2022/04/imagen-placeholder-por-defecto-WooCommerce.png");
                }
            }
            catch (Exception)
            {
                pb_articulos.Load("https://codigogenesis.com/genesis/2022/04/imagen-placeholder-por-defecto-WooCommerce.png");
            }
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm_AgregarArticulo))
                    return;
            }
            Articulo seleccionado;
            seleccionado = (Articulo)dgv_listadoArticulos.CurrentRow.DataBoundItem;

            Frm_AgregarArticulo modificar = new Frm_AgregarArticulo(seleccionado);
            modificar.Show();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm_AgregarArticulo))
                    return;
            }

            Frm_AgregarArticulo ventana = new Frm_AgregarArticulo();
            ventana.Show();
        }
    }
}
