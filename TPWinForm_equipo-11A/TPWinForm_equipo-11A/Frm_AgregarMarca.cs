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
    public partial class Frm_AgregarMarca : Form
    {
        public Frm_AgregarMarca()
        {
            InitializeComponent();
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            Marcas nuevo = new Marcas();
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                nuevo.Descripcion = tb_nombreArt.Text;

                negocio.agregarMarca(nuevo);

                MessageBox.Show("Marca agregada.");

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
