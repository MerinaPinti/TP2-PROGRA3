namespace TPWinForm_equipo_11A
{
    partial class frm_Agregar_Articulo
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
            this.lb_Cod_Articulo = new System.Windows.Forms.Label();
            this.lb_NombreArticulo = new System.Windows.Forms.Label();
            this.lb_Desc_Articulo = new System.Windows.Forms.Label();
            this.lb_IdMarca = new System.Windows.Forms.Label();
            this.lb_IdCategoria = new System.Windows.Forms.Label();
            this.lb_Precio = new System.Windows.Forms.Label();
            this.tb_nombreArt = new System.Windows.Forms.TextBox();
            this.tb_Descrip = new System.Windows.Forms.TextBox();
            this.tb_codArt = new System.Windows.Forms.TextBox();
            this.tb_Marca = new System.Windows.Forms.TextBox();
            this.tb_Precio = new System.Windows.Forms.TextBox();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.bt_Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Cod_Articulo
            // 
            this.lb_Cod_Articulo.AutoSize = true;
            this.lb_Cod_Articulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cod_Articulo.Location = new System.Drawing.Point(96, 266);
            this.lb_Cod_Articulo.Name = "lb_Cod_Articulo";
            this.lb_Cod_Articulo.Size = new System.Drawing.Size(101, 31);
            this.lb_Cod_Articulo.TabIndex = 1;
            this.lb_Cod_Articulo.Text = "Código";
            // 
            // lb_NombreArticulo
            // 
            this.lb_NombreArticulo.AutoSize = true;
            this.lb_NombreArticulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NombreArticulo.Location = new System.Drawing.Point(96, 101);
            this.lb_NombreArticulo.Name = "lb_NombreArticulo";
            this.lb_NombreArticulo.Size = new System.Drawing.Size(121, 31);
            this.lb_NombreArticulo.TabIndex = 2;
            this.lb_NombreArticulo.Text = "Nombre ";
            // 
            // lb_Desc_Articulo
            // 
            this.lb_Desc_Articulo.AutoSize = true;
            this.lb_Desc_Articulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Desc_Articulo.Location = new System.Drawing.Point(96, 166);
            this.lb_Desc_Articulo.Name = "lb_Desc_Articulo";
            this.lb_Desc_Articulo.Size = new System.Drawing.Size(155, 31);
            this.lb_Desc_Articulo.TabIndex = 3;
            this.lb_Desc_Articulo.Text = "Descripción";
            // 
            // lb_IdMarca
            // 
            this.lb_IdMarca.AutoSize = true;
            this.lb_IdMarca.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdMarca.Location = new System.Drawing.Point(96, 322);
            this.lb_IdMarca.Name = "lb_IdMarca";
            this.lb_IdMarca.Size = new System.Drawing.Size(89, 31);
            this.lb_IdMarca.TabIndex = 4;
            this.lb_IdMarca.Text = "Marca";
            // 
            // lb_IdCategoria
            // 
            this.lb_IdCategoria.AutoSize = true;
            this.lb_IdCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdCategoria.Location = new System.Drawing.Point(96, 380);
            this.lb_IdCategoria.Name = "lb_IdCategoria";
            this.lb_IdCategoria.Size = new System.Drawing.Size(131, 31);
            this.lb_IdCategoria.TabIndex = 5;
            this.lb_IdCategoria.Text = "Categoría";
            // 
            // lb_Precio
            // 
            this.lb_Precio.AutoSize = true;
            this.lb_Precio.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Precio.Location = new System.Drawing.Point(96, 445);
            this.lb_Precio.Name = "lb_Precio";
            this.lb_Precio.Size = new System.Drawing.Size(89, 31);
            this.lb_Precio.TabIndex = 6;
            this.lb_Precio.Text = "Precio";
            // 
            // tb_nombreArt
            // 
            this.tb_nombreArt.Location = new System.Drawing.Point(259, 101);
            this.tb_nombreArt.Multiline = true;
            this.tb_nombreArt.Name = "tb_nombreArt";
            this.tb_nombreArt.Size = new System.Drawing.Size(175, 32);
            this.tb_nombreArt.TabIndex = 7;
            // 
            // tb_Descrip
            // 
            this.tb_Descrip.Location = new System.Drawing.Point(257, 177);
            this.tb_Descrip.Multiline = true;
            this.tb_Descrip.Name = "tb_Descrip";
            this.tb_Descrip.Size = new System.Drawing.Size(261, 61);
            this.tb_Descrip.TabIndex = 8;
            // 
            // tb_codArt
            // 
            this.tb_codArt.Location = new System.Drawing.Point(257, 266);
            this.tb_codArt.Multiline = true;
            this.tb_codArt.Name = "tb_codArt";
            this.tb_codArt.Size = new System.Drawing.Size(114, 29);
            this.tb_codArt.TabIndex = 9;
            // 
            // tb_Marca
            // 
            this.tb_Marca.Location = new System.Drawing.Point(257, 324);
            this.tb_Marca.Multiline = true;
            this.tb_Marca.Name = "tb_Marca";
            this.tb_Marca.Size = new System.Drawing.Size(130, 29);
            this.tb_Marca.TabIndex = 10;
            // 
            // tb_Precio
            // 
            this.tb_Precio.Location = new System.Drawing.Point(257, 445);
            this.tb_Precio.Multiline = true;
            this.tb_Precio.Name = "tb_Precio";
            this.tb_Precio.Size = new System.Drawing.Size(65, 31);
            this.tb_Precio.TabIndex = 11;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(199, 19);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(224, 28);
            this.lb_Titulo.TabIndex = 12;
            this.lb_Titulo.Text = "Agregue un artículo";
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Agregar.Location = new System.Drawing.Point(437, 519);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(122, 39);
            this.bt_Agregar.TabIndex = 13;
            this.bt_Agregar.Text = "AGREGAR";
            this.bt_Agregar.UseVisualStyleBackColor = true;
            // 
            // frm_Agregar_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 586);
            this.Controls.Add(this.bt_Agregar);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.tb_Precio);
            this.Controls.Add(this.tb_Marca);
            this.Controls.Add(this.tb_codArt);
            this.Controls.Add(this.tb_Descrip);
            this.Controls.Add(this.tb_nombreArt);
            this.Controls.Add(this.lb_Precio);
            this.Controls.Add(this.lb_IdCategoria);
            this.Controls.Add(this.lb_IdMarca);
            this.Controls.Add(this.lb_Desc_Articulo);
            this.Controls.Add(this.lb_NombreArticulo);
            this.Controls.Add(this.lb_Cod_Articulo);
            this.MinimumSize = new System.Drawing.Size(638, 625);
            this.Name = "frm_Agregar_Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
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
        private System.Windows.Forms.TextBox tb_Marca;
        private System.Windows.Forms.TextBox tb_Precio;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Button bt_Agregar;
    }
}