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
    public partial class Frm_ListarArticulos : Form
    {
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
            ArticuloService service = new ArticuloService();
            dgv_listadoArticulos.DataSource = service.listar();
        }

       

    }
}
