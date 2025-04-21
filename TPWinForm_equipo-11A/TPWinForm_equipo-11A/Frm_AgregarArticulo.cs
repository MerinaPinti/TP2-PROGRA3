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
        private Articulo articulo = null;
        public Frm_AgregarArticulo()
        {
            InitializeComponent();
        }

        public Frm_AgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.Text = "Modificar Artículo";
            lb_Titulo.Text = "Modificar Artículo";
            this.articulo = articulo;

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Agregar_Click(object sender, EventArgs e)
        {
         
            ArticuloNegocio negocio = new ArticuloNegocio();
            Frm_ListarArticulos listar = new Frm_ListarArticulos();
            try
            {
                if(articulo == null) 
                    articulo = new Articulo();    
                
                if (!(validar(negocio, articulo)))
                {
                    return;
                }  
                articulo.Codigo = tb_codArt.Text;                    
                articulo.Nombre = tb_nombreArt.Text;                   
                articulo.Descripcion = tb_Descrip.Text;                                      
                articulo.Marca = (Marcas)cBox_Marca.SelectedItem;                   
                articulo.Categoria = (Categorias)cBox_Categoria.SelectedItem;                    
                articulo.Precio = float.Parse(tb_Precio.Text);                
                articulo.Imagen = new Imagenes();                    
                articulo.Imagen.ImagenUrl = tb_urlImagen.Text;

                if (articulo.ID != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Artículo Modificado!", "Modificar Artículo");
                }
                else
                {
                    if (negocio.existeCodigo(articulo.Codigo))
                    {
                        MessageBox.Show("Ya existe un artículo con ese código. Ingresá uno diferente.");
                        return;
                    }
                    negocio.agregarArticulo(articulo);
                    MessageBox.Show("Artículo agregado!", "Agregar Artículo");
                }

                Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error desconocido, intente de nuevo más tarde");
                //MessageBox.Show(ex.ToString());
            }
        }

        private bool validar(ArticuloNegocio negocio, Articulo nuevo)
        {
            
                //Validación caracteres 
            if (tb_Descrip.Text.Length > 150)
            {
                MessageBox.Show("La descripción no puede tener más de 150 caracteres.");
                    return false;
            }

            //Validación de no ingresar un número negativo 
            if (string.IsNullOrWhiteSpace(tb_codArt.Text) || (string.IsNullOrWhiteSpace(tb_nombreArt.Text) || string.IsNullOrWhiteSpace(tb_Precio.Text)))
            {
                MessageBox.Show("Por favor ingrese los campos obligatorios *","Campos obligatorios vacíos");
                lbl_Obligatorio.Visible = true;
                lbl_Obligatorio2.Visible = true;
                lbl_Obligatorio3.Visible = true;
                lbl_Obligatorio4.Visible = true;
                lbl_Obligatorio5.Visible = true;
                return false;
            }
            return true;
        }

        private void Frm_AgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio articuloNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cBox_Marca.DataSource = articuloNegocio.listar();
                cBox_Marca.ValueMember = "Id";
                cBox_Marca.DisplayMember = "Descripcion";
                cBox_Categoria.DataSource = categoriaNegocio.listar();
                cBox_Categoria.ValueMember = "Id";
                cBox_Categoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    lb_Titulo.Text = "Modificar Artículo";
                    tb_codArt.Text = articulo.Codigo;
                    tb_Descrip.Text = articulo.Descripcion;
                    tb_nombreArt.Text = articulo.Nombre;
                    tb_Precio.Text = articulo.Precio.ToString();
                    tb_urlImagen.Text = articulo.Imagen.ImagenUrl;
                    cBox_Categoria.SelectedValue = articulo.Categoria.ID;
                    cBox_Marca.SelectedValue = articulo.Marca.ID;
                    cargarImagen(articulo.Imagen.ImagenUrl);
                    
                }

            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
                MessageBox.Show("Error desconocido, intente de nuevo más tarde");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tb_urlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tb_urlImagen.Text);

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagen))
                {
                    pb_AgregarImagenArt.Load(imagen);
                }
                else
                {
                    pb_AgregarImagenArt.Load("https://codigogenesis.com/genesis/2022/04/imagen-placeholder-por-defecto-WooCommerce.png");
                }
            }
            catch (Exception)
            {
                pb_AgregarImagenArt.Load("https://codigogenesis.com/genesis/2022/04/imagen-placeholder-por-defecto-WooCommerce.png");
            }
        }

        private void tb_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b') 
            {
                e.Handled = true;
            }

            if(e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
