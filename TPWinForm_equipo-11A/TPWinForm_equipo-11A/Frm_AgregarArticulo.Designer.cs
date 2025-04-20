namespace TPWinForm_equipo_11A
{
    partial class Frm_AgregarArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_Cod_Articulo = new System.Windows.Forms.Label();
            this.lb_NombreArticulo = new System.Windows.Forms.Label();
            this.lb_Desc_Articulo = new System.Windows.Forms.Label();
            this.lb_IdMarca = new System.Windows.Forms.Label();
            this.lb_IdCategoria = new System.Windows.Forms.Label();
            this.lb_Precio = new System.Windows.Forms.Label();
            this.tb_nombreArt = new System.Windows.Forms.TextBox();
            this.tb_Descrip = new System.Windows.Forms.TextBox();
            this.tb_codArt = new System.Windows.Forms.TextBox();
            this.tb_Precio = new System.Windows.Forms.TextBox();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.bt_Agregar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cBox_Marca = new System.Windows.Forms.ComboBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cBox_Categoria = new System.Windows.Forms.ComboBox();
            this.lb_agregarimagen = new System.Windows.Forms.Label();
            this.tb_urlImagen = new System.Windows.Forms.TextBox();
            this.pb_AgregarImagenArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AgregarImagenArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Cod_Articulo
            // 
            this.lb_Cod_Articulo.AutoSize = true;
            this.lb_Cod_Articulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cod_Articulo.Location = new System.Drawing.Point(30, 176);
            this.lb_Cod_Articulo.Name = "lb_Cod_Articulo";
            this.lb_Cod_Articulo.Size = new System.Drawing.Size(51, 17);
            this.lb_Cod_Articulo.TabIndex = 1;
            this.lb_Cod_Articulo.Text = "Código";
            // 
            // lb_NombreArticulo
            // 
            this.lb_NombreArticulo.AutoSize = true;
            this.lb_NombreArticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NombreArticulo.Location = new System.Drawing.Point(30, 69);
            this.lb_NombreArticulo.Name = "lb_NombreArticulo";
            this.lb_NombreArticulo.Size = new System.Drawing.Size(61, 17);
            this.lb_NombreArticulo.TabIndex = 2;
            this.lb_NombreArticulo.Text = "Nombre ";
            // 
            // lb_Desc_Articulo
            // 
            this.lb_Desc_Articulo.AutoSize = true;
            this.lb_Desc_Articulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Desc_Articulo.Location = new System.Drawing.Point(30, 109);
            this.lb_Desc_Articulo.Name = "lb_Desc_Articulo";
            this.lb_Desc_Articulo.Size = new System.Drawing.Size(76, 17);
            this.lb_Desc_Articulo.TabIndex = 3;
            this.lb_Desc_Articulo.Text = "Descripción";
            // 
            // lb_IdMarca
            // 
            this.lb_IdMarca.AutoSize = true;
            this.lb_IdMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdMarca.Location = new System.Drawing.Point(30, 225);
            this.lb_IdMarca.Name = "lb_IdMarca";
            this.lb_IdMarca.Size = new System.Drawing.Size(45, 17);
            this.lb_IdMarca.TabIndex = 4;
            this.lb_IdMarca.Text = "Marca";
            // 
            // lb_IdCategoria
            // 
            this.lb_IdCategoria.AutoSize = true;
            this.lb_IdCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdCategoria.Location = new System.Drawing.Point(30, 273);
            this.lb_IdCategoria.Name = "lb_IdCategoria";
            this.lb_IdCategoria.Size = new System.Drawing.Size(65, 17);
            this.lb_IdCategoria.TabIndex = 5;
            this.lb_IdCategoria.Text = "Categoría";
            // 
            // lb_Precio
            // 
            this.lb_Precio.AutoSize = true;
            this.lb_Precio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Precio.Location = new System.Drawing.Point(30, 322);
            this.lb_Precio.Name = "lb_Precio";
            this.lb_Precio.Size = new System.Drawing.Size(44, 17);
            this.lb_Precio.TabIndex = 6;
            this.lb_Precio.Text = "Precio";
            // 
            // tb_nombreArt
            // 
            this.tb_nombreArt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombreArt.Location = new System.Drawing.Point(111, 66);
            this.tb_nombreArt.Multiline = true;
            this.tb_nombreArt.Name = "tb_nombreArt";
            this.tb_nombreArt.Size = new System.Drawing.Size(285, 21);
            this.tb_nombreArt.TabIndex = 0;
            // 
            // tb_Descrip
            // 
            this.tb_Descrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Descrip.Location = new System.Drawing.Point(111, 109);
            this.tb_Descrip.Multiline = true;
            this.tb_Descrip.Name = "tb_Descrip";
            this.tb_Descrip.Size = new System.Drawing.Size(285, 42);
            this.tb_Descrip.TabIndex = 1;
            // 
            // tb_codArt
            // 
            this.tb_codArt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codArt.Location = new System.Drawing.Point(111, 176);
            this.tb_codArt.Multiline = true;
            this.tb_codArt.Name = "tb_codArt";
            this.tb_codArt.Size = new System.Drawing.Size(285, 21);
            this.tb_codArt.TabIndex = 2;
            // 
            // tb_Precio
            // 
            this.tb_Precio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Precio.Location = new System.Drawing.Point(111, 319);
            this.tb_Precio.Multiline = true;
            this.tb_Precio.Name = "tb_Precio";
            this.tb_Precio.Size = new System.Drawing.Size(285, 21);
            this.tb_Precio.TabIndex = 5;
            this.tb_Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Precio_KeyPress);
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(28, 23);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(187, 30);
            this.lb_Titulo.TabIndex = 12;
            this.lb_Titulo.Text = "Agregar Artículo";
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Agregar.Location = new System.Drawing.Point(228, 422);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(82, 29);
            this.bt_Agregar.TabIndex = 7;
            this.bt_Agregar.Text = "Agregar";
            this.bt_Agregar.UseVisualStyleBackColor = true;
            this.bt_Agregar.Click += new System.EventHandler(this.bt_Agregar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cBox_Marca
            // 
            this.cBox_Marca.FormattingEnabled = true;
            this.cBox_Marca.Location = new System.Drawing.Point(111, 225);
            this.cBox_Marca.Name = "cBox_Marca";
            this.cBox_Marca.Size = new System.Drawing.Size(285, 21);
            this.cBox_Marca.TabIndex = 3;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(315, 423);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(81, 28);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cBox_Categoria
            // 
            this.cBox_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Categoria.FormattingEnabled = true;
            this.cBox_Categoria.Location = new System.Drawing.Point(111, 268);
            this.cBox_Categoria.Margin = new System.Windows.Forms.Padding(2);
            this.cBox_Categoria.Name = "cBox_Categoria";
            this.cBox_Categoria.Size = new System.Drawing.Size(286, 21);
            this.cBox_Categoria.TabIndex = 4;
            // 
            // lb_agregarimagen
            // 
            this.lb_agregarimagen.AutoSize = true;
            this.lb_agregarimagen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_agregarimagen.Location = new System.Drawing.Point(30, 373);
            this.lb_agregarimagen.Name = "lb_agregarimagen";
            this.lb_agregarimagen.Size = new System.Drawing.Size(72, 17);
            this.lb_agregarimagen.TabIndex = 15;
            this.lb_agregarimagen.Text = "Url Imagen";
            // 
            // tb_urlImagen
            // 
            this.tb_urlImagen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_urlImagen.Location = new System.Drawing.Point(111, 373);
            this.tb_urlImagen.Multiline = true;
            this.tb_urlImagen.Name = "tb_urlImagen";
            this.tb_urlImagen.Size = new System.Drawing.Size(285, 21);
            this.tb_urlImagen.TabIndex = 6;
            this.tb_urlImagen.Leave += new System.EventHandler(this.tb_urlImagen_Leave);
            // 
            // pb_AgregarImagenArt
            // 
            this.pb_AgregarImagenArt.Location = new System.Drawing.Point(414, 68);
            this.pb_AgregarImagenArt.Name = "pb_AgregarImagenArt";
            this.pb_AgregarImagenArt.Size = new System.Drawing.Size(331, 325);
            this.pb_AgregarImagenArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_AgregarImagenArt.TabIndex = 17;
            this.pb_AgregarImagenArt.TabStop = false;
            // 
            // Frm_AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(813, 495);
            this.Controls.Add(this.pb_AgregarImagenArt);
            this.Controls.Add(this.tb_urlImagen);
            this.Controls.Add(this.lb_agregarimagen);
            this.Controls.Add(this.cBox_Categoria);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.cBox_Marca);
            this.Controls.Add(this.bt_Agregar);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.tb_Precio);
            this.Controls.Add(this.tb_codArt);
            this.Controls.Add(this.tb_Descrip);
            this.Controls.Add(this.tb_nombreArt);
            this.Controls.Add(this.lb_Precio);
            this.Controls.Add(this.lb_IdCategoria);
            this.Controls.Add(this.lb_IdMarca);
            this.Controls.Add(this.lb_Desc_Articulo);
            this.Controls.Add(this.lb_NombreArticulo);
            this.Controls.Add(this.lb_Cod_Articulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_AgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.Frm_AgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_AgregarImagenArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Cod_Articulo;
        private System.Windows.Forms.Label lb_NombreArticulo;
        private System.Windows.Forms.Label lb_Desc_Articulo;
        private System.Windows.Forms.Label lb_IdMarca;
        private System.Windows.Forms.Label lb_IdCategoria;
        private System.Windows.Forms.Label lb_Precio;
        private System.Windows.Forms.TextBox tb_nombreArt;
        private System.Windows.Forms.TextBox tb_Descrip;
        private System.Windows.Forms.TextBox tb_codArt;
        private System.Windows.Forms.TextBox tb_Precio;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Button bt_Agregar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cBox_Marca;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ComboBox cBox_Categoria;
        private System.Windows.Forms.Label lb_agregarimagen;
        private System.Windows.Forms.TextBox tb_urlImagen;
        private System.Windows.Forms.PictureBox pb_AgregarImagenArt;
    }
}