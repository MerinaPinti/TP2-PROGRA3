namespace TPWinForm_equipo_11A
{
    partial class Frm_ModificarArticulo
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
            this.cBox_Categoria = new System.Windows.Forms.ComboBox();
            this.cBox_Marca = new System.Windows.Forms.ComboBox();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.tb_Precio = new System.Windows.Forms.TextBox();
            this.tb_codArt = new System.Windows.Forms.TextBox();
            this.tb_Descrip = new System.Windows.Forms.TextBox();
            this.tb_nombreArt = new System.Windows.Forms.TextBox();
            this.lb_Precio = new System.Windows.Forms.Label();
            this.lb_IdCategoria = new System.Windows.Forms.Label();
            this.lb_IdMarca = new System.Windows.Forms.Label();
            this.lb_Desc_Articulo = new System.Windows.Forms.Label();
            this.lb_NombreArticulo = new System.Windows.Forms.Label();
            this.lb_Cod_Articulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cBox_Categoria
            // 
            this.cBox_Categoria.Enabled = false;
            this.cBox_Categoria.FormattingEnabled = true;
            this.cBox_Categoria.Location = new System.Drawing.Point(110, 274);
            this.cBox_Categoria.Name = "cBox_Categoria";
            this.cBox_Categoria.Size = new System.Drawing.Size(285, 21);
            this.cBox_Categoria.TabIndex = 20;
            // 
            // cBox_Marca
            // 
            this.cBox_Marca.FormattingEnabled = true;
            this.cBox_Marca.Location = new System.Drawing.Point(110, 226);
            this.cBox_Marca.Name = "cBox_Marca";
            this.cBox_Marca.Size = new System.Drawing.Size(285, 21);
            this.cBox_Marca.TabIndex = 18;
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Aceptar.Location = new System.Drawing.Point(313, 364);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(82, 29);
            this.bt_Aceptar.TabIndex = 24;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(27, 24);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(202, 30);
            this.lb_Titulo.TabIndex = 26;
            this.lb_Titulo.Text = "Modificar Artículo";
            // 
            // tb_Precio
            // 
            this.tb_Precio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Precio.Location = new System.Drawing.Point(110, 320);
            this.tb_Precio.Multiline = true;
            this.tb_Precio.Name = "tb_Precio";
            this.tb_Precio.Size = new System.Drawing.Size(285, 21);
            this.tb_Precio.TabIndex = 22;
            // 
            // tb_codArt
            // 
            this.tb_codArt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codArt.Location = new System.Drawing.Point(110, 177);
            this.tb_codArt.Multiline = true;
            this.tb_codArt.Name = "tb_codArt";
            this.tb_codArt.Size = new System.Drawing.Size(285, 21);
            this.tb_codArt.TabIndex = 16;
            // 
            // tb_Descrip
            // 
            this.tb_Descrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Descrip.Location = new System.Drawing.Point(110, 110);
            this.tb_Descrip.Multiline = true;
            this.tb_Descrip.Name = "tb_Descrip";
            this.tb_Descrip.Size = new System.Drawing.Size(285, 42);
            this.tb_Descrip.TabIndex = 14;
            // 
            // tb_nombreArt
            // 
            this.tb_nombreArt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombreArt.Location = new System.Drawing.Point(110, 67);
            this.tb_nombreArt.Multiline = true;
            this.tb_nombreArt.Name = "tb_nombreArt";
            this.tb_nombreArt.Size = new System.Drawing.Size(285, 21);
            this.tb_nombreArt.TabIndex = 13;
            // 
            // lb_Precio
            // 
            this.lb_Precio.AutoSize = true;
            this.lb_Precio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Precio.Location = new System.Drawing.Point(29, 323);
            this.lb_Precio.Name = "lb_Precio";
            this.lb_Precio.Size = new System.Drawing.Size(44, 17);
            this.lb_Precio.TabIndex = 25;
            this.lb_Precio.Text = "Precio";
            // 
            // lb_IdCategoria
            // 
            this.lb_IdCategoria.AutoSize = true;
            this.lb_IdCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdCategoria.Location = new System.Drawing.Point(29, 274);
            this.lb_IdCategoria.Name = "lb_IdCategoria";
            this.lb_IdCategoria.Size = new System.Drawing.Size(65, 17);
            this.lb_IdCategoria.TabIndex = 23;
            this.lb_IdCategoria.Text = "Categoría";
            // 
            // lb_IdMarca
            // 
            this.lb_IdMarca.AutoSize = true;
            this.lb_IdMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdMarca.Location = new System.Drawing.Point(29, 226);
            this.lb_IdMarca.Name = "lb_IdMarca";
            this.lb_IdMarca.Size = new System.Drawing.Size(45, 17);
            this.lb_IdMarca.TabIndex = 21;
            this.lb_IdMarca.Text = "Marca";
            // 
            // lb_Desc_Articulo
            // 
            this.lb_Desc_Articulo.AutoSize = true;
            this.lb_Desc_Articulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Desc_Articulo.Location = new System.Drawing.Point(29, 110);
            this.lb_Desc_Articulo.Name = "lb_Desc_Articulo";
            this.lb_Desc_Articulo.Size = new System.Drawing.Size(76, 17);
            this.lb_Desc_Articulo.TabIndex = 19;
            this.lb_Desc_Articulo.Text = "Descripción";
            // 
            // lb_NombreArticulo
            // 
            this.lb_NombreArticulo.AutoSize = true;
            this.lb_NombreArticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NombreArticulo.Location = new System.Drawing.Point(29, 70);
            this.lb_NombreArticulo.Name = "lb_NombreArticulo";
            this.lb_NombreArticulo.Size = new System.Drawing.Size(61, 17);
            this.lb_NombreArticulo.TabIndex = 17;
            this.lb_NombreArticulo.Text = "Nombre ";
            // 
            // lb_Cod_Articulo
            // 
            this.lb_Cod_Articulo.AutoSize = true;
            this.lb_Cod_Articulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cod_Articulo.Location = new System.Drawing.Point(29, 177);
            this.lb_Cod_Articulo.Name = "lb_Cod_Articulo";
            this.lb_Cod_Articulo.Size = new System.Drawing.Size(51, 17);
            this.lb_Cod_Articulo.TabIndex = 15;
            this.lb_Cod_Articulo.Text = "Código";
            // 
            // Frm_ModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 417);
            this.Controls.Add(this.cBox_Categoria);
            this.Controls.Add(this.cBox_Marca);
            this.Controls.Add(this.bt_Aceptar);
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
            this.Name = "Frm_ModificarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBox_Categoria;
        private System.Windows.Forms.ComboBox cBox_Marca;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.TextBox tb_Precio;
        private System.Windows.Forms.TextBox tb_codArt;
        private System.Windows.Forms.TextBox tb_Descrip;
        private System.Windows.Forms.TextBox tb_nombreArt;
        private System.Windows.Forms.Label lb_Precio;
        private System.Windows.Forms.Label lb_IdCategoria;
        private System.Windows.Forms.Label lb_IdMarca;
        private System.Windows.Forms.Label lb_Desc_Articulo;
        private System.Windows.Forms.Label lb_NombreArticulo;
        private System.Windows.Forms.Label lb_Cod_Articulo;
    }
}