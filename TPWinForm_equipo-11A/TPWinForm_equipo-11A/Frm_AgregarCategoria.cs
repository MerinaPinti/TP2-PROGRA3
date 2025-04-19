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
        public Frm_AgregarCategoria()
        {
            InitializeComponent();
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            Categorias nuevo = new Categorias();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                nuevo.Descripcion = tb_nombreCat.Text;

                negocio.agregarCategoria(nuevo);

                MessageBox.Show("Categoria agregada.");

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
