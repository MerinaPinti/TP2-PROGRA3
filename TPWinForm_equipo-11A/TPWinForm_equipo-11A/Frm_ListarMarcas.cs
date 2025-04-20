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
    public partial class Frm_ListarMarcas : Form
    {
        public Frm_ListarMarcas()
        {
            InitializeComponent();
        }

        private void Frm_ListarMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgv_ListarMarcas.DataSource = negocio.listar();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_ListarMarcas.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná una marca para modificar.");
                return;
            }

            Marcas seleccionado = (Marcas)dgv_ListarMarcas.CurrentRow.DataBoundItem;
            Frm_AgregarMarca modificar = new Frm_AgregarMarca(seleccionado);

            if (modificar.ShowDialog() == DialogResult.OK)
            {
                MarcaNegocio negocio = new MarcaNegocio();
                dgv_ListarMarcas.DataSource = negocio.listar();
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            eliminarMarca();
        }

        private void eliminarMarca(bool logico = false)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marcas seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Esta seguro de eliminar esta marca?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marcas)dgv_ListarMarcas.CurrentRow.DataBoundItem;
                    if (logico)
                    {
                        negocio.eliminarLogico(seleccionado.ID);
                    }
                    else
                    {
                        negocio.eliminarFisico(seleccionado.ID);
                    }
                    dgv_ListarMarcas.DataSource = negocio.listar();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
