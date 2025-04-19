using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_11A
{
    public partial class Frm_AgregarCategoria : Form
    {

        private Categorias categorias = null;
        public Frm_AgregarCategoria()
        {
            InitializeComponent();
        }

        public Frm_AgregarCategoria(Categorias categorias)
        {
            InitializeComponent();
            //this es el null y categorías es el que viene por parámetro. 
            //cuando ponemos modificar va a estar cargdo con el pokemon que vino de la otra ventana. 
            this.categorias = categorias;
            Text = "Modificar Categoría";

        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categorias == null)
                {
                    categorias = new Categorias();
                }

                categorias.Descripcion = tb_nombreCat.Text;

                if (categorias.ID != 0)
                {
                    negocio.modificarCategoria(categorias);
                    MessageBox.Show("Modificado Exitosamente.");
                }
                else
                {
                    negocio.agregarCategoria(categorias);
                    MessageBox.Show("Categoria agregada.");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
     

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
