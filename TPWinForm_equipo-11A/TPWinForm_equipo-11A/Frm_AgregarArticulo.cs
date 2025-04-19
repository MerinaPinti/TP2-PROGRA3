using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio; 

namespace TPWinForm_equipo_11A
{
    public partial class Frm_AgregarArticulo : Form
    {
        public Frm_AgregarArticulo()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                nuevo.Codigo = tb_codArt.Text;
                nuevo.Nombre = tb_nombreArt.Text;
                nuevo.Descripcion = tb_Descrip.Text;
                nuevo.Marca = (Marcas)cBox_Marca.SelectedItem;
                nuevo.Categoria = (Categorias)cBox_Categoria.SelectedItem;
                nuevo.Precio = float.Parse(tb_Precio.Text);
                negocio.agregarArticulo(nuevo);
                MessageBox.Show("Articulo agregado");

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Frm_AgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio articulonegocio = new MarcaNegocio();
            CategoriaNegocio categorianegocio = new CategoriaNegocio();

            try
            {
                cBox_Marca.DataSource = articulonegocio.listar();
                cBox_Categoria.DataSource = categorianegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
