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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        //private void frm_Principal_Load(object sender, EventArgs e)
        //{
           // ArticuloService service = new ArticuloService();
            //dgvArticulos.DataSource = service.listar();
        //}


        /// Evento que se acciona cuando presionamos "LISTAR->ARCHIVOS" de Toolstrip 
        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarArticulos ventana = new Frm_ListarArticulos();
            //para que no se pueda abrir mucas veces sino solo una vez 
            //Con esto uso la ventana principal como padre y quede dentro de la principal. 
            ventana.MdiParent = this;
            //para este caso no se puede usar el showdialog porque la ventana de atrás debe seguir teniendo control.  
            //ventana.ShowDialog();
            ventana.Show();
          
        }
    }
}
