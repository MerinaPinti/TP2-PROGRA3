using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_11A
{
    public partial class Frm_AgregarMarca : Form
    {
        private Marcas marcas = null;
        public Frm_AgregarMarca()
        {
            InitializeComponent();
        }

        public Frm_AgregarMarca(Marcas marcas)
        {
            InitializeComponent();
            //this es el null y categorías es el que viene por parámetro. 
            //cuando ponemos modificar va a estar cargdo con el pokemon que vino de la otra ventana. 
            this.marcas = marcas;
            Text = "Modificar Marcas";

        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (marcas == null)
                {
                    marcas = new Marcas();
                }

                marcas.Descripcion = tb_nombreArt.Text;
                //Validación caracteres 
                if (tb_nombreArt.Text.Length > 50)
                {
                    MessageBox.Show("La descripción no puede tener más de 50 caracteres.");
                    tb_nombreArt.Focus();
                    return;
                }

                marcas.Descripcion = tb_nombreArt.Text;

                if (marcas.ID != 0)
                {
                    negocio.modificarMarca(marcas);
                    MessageBox.Show("Modificado Exitosamente.");
                }
                else
                {
                    negocio.agregarMarca(marcas);
                    MessageBox.Show("Marca agregada.");
                }

                this.DialogResult = DialogResult.OK;
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

        private void Frm_AgregarMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if (marcas != null)
                {
                    tb_nombreArt.Text = marcas.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
