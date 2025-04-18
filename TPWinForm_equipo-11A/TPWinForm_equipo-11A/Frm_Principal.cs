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


        /// Evento que se acciona cuando presionamos "LISTAR->ARTICULOS" de Toolstrip 
        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm_AgregarArticulo))
                    return;
            }
            Frm_ListarArticulos ventana = new Frm_ListarArticulos();
            //para que no se pueda abrir mucas veces sino solo una vez 
            //Con esto uso la ventana principal como padre y quede dentro de la principal (Container true). 
            ventana.MdiParent = this;
            //para este caso no se puede usar el showdialog porque la ventana de atrás debe seguir teniendo control.  
            ventana.Show();
          
        }

        //Boton Agregar Articulos ARTÍCULOS-> AGREGAR  
        private void tstrip_Agregar_Archivos_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm_AgregarArticulo))
                    return;
            }
            Frm_AgregarArticulo ventana = new Frm_AgregarArticulo();
            ventana.MdiParent = this; 
            ventana.Show(); 

        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //LISTAR CATEGORÍAS /// Evento que se acciona cuando presionamos "LISTAR->CATEGORÍAS" de Toolstrip 
        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm_ListarCategorias))
                    return;
            }
            Frm_ListarCategorias ventana = new Frm_ListarCategorias();
            //para que no se pueda abrir mucas veces sino solo una vez 
            //Con esto uso la ventana principal como padre y quede dentro de la principal (Container true). 
            ventana.MdiParent = this;
            //para este caso no se puede usar el showdialog porque la ventana de atrás debe seguir teniendo control.  
            ventana.Show();
        }

        private void tstrip_Modificar_Archivos_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm_ModificarArticulo))
                    return;
            }

            Frm_ModificarArticulo ventana = new Frm_ModificarArticulo();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tstrip_Agregar_Marcas_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm_AgregarMarca)) return;
            }
            Frm_AgregarMarca ventana = new Frm_AgregarMarca();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void tstrip_Modificar_Marcas_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Frm_ModificarMarca)) return;
            }
            Frm_ModificarMarca ventana = new Frm_ModificarMarca();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
