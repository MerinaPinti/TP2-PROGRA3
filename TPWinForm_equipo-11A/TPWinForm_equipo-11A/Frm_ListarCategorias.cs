using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio; 

namespace TPWinForm_equipo_11A
{
    public partial class Frm_ListarCategorias : Form
    {
        public Frm_ListarCategorias()
        {
            InitializeComponent();
        }

        private void Frm_ListarCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgv_ListarCategorias.DataSource = negocio.listar();
        }
    }
}
