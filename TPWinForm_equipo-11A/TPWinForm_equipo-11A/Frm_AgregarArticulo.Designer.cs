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
            this.SuspendLayout();
            // 
            // lb_Cod_Articulo
            // 
            this.lb_Cod_Articulo.AutoSize = true;
            this.lb_Cod_Articulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cod_Articulo.Location = new System.Drawing.Point(40, 217);
            this.lb_Cod_Articulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Cod_Articulo.Name = "lb_Cod_Articulo";
            this.lb_Cod_Articulo.Size = new System.Drawing.Size(65, 23);
            this.lb_Cod_Articulo.TabIndex = 1;
            this.lb_Cod_Articulo.Text = "Código";
            // 
            // lb_NombreArticulo
            // 
            this.lb_NombreArticulo.AutoSize = true;
            this.lb_NombreArticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NombreArticulo.Location = new System.Drawing.Point(40, 85);
            this.lb_NombreArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_NombreArticulo.Name = "lb_NombreArticulo";
            this.lb_NombreArticulo.Size = new System.Drawing.Size(78, 23);
            this.lb_NombreArticulo.TabIndex = 2;
            this.lb_NombreArticulo.Text = "Nombre ";
            // 
            // lb_Desc_Articulo
            // 
            this.lb_Desc_Articulo.AutoSize = true;
            this.lb_Desc_Articulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Desc_Articulo.Location = new System.Drawing.Point(40, 134);
            this.lb_Desc_Articulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Desc_Articulo.Name = "lb_Desc_Articulo";
            this.lb_Desc_Articulo.Size = new System.Drawing.Size(98, 23);
            this.lb_Desc_Articulo.TabIndex = 3;
            this.lb_Desc_Articulo.Text = "Descripción";
            // 
            // lb_IdMarca
            // 
            this.lb_IdMarca.AutoSize = true;
            this.lb_IdMarca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdMarca.Location = new System.Drawing.Point(40, 277);
            this.lb_IdMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_IdMarca.Name = "lb_IdMarca";
            this.lb_IdMarca.Size = new System.Drawing.Size(57, 23);
            this.lb_IdMarca.TabIndex = 4;
            this.lb_IdMarca.Text = "Marca";
            // 
            // lb_IdCategoria
            // 
            this.lb_IdCategoria.AutoSize = true;
            this.lb_IdCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IdCategoria.Location = new System.Drawing.Point(40, 336);
            this.lb_IdCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_IdCategoria.Name = "lb_IdCategoria";
            this.lb_IdCategoria.Size = new System.Drawing.Size(84, 23);
            this.lb_IdCategoria.TabIndex = 5;
            this.lb_IdCategoria.Text = "Categoría";
            // 
            // lb_Precio
            // 
            this.lb_Precio.AutoSize = true;
            this.lb_Precio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Precio.Location = new System.Drawing.Point(40, 396);
            this.lb_Precio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Precio.Name = "lb_Precio";
            this.lb_Precio.Size = new System.Drawing.Size(57, 23);
            this.lb_Precio.TabIndex = 6;
            this.lb_Precio.Text = "Precio";
            // 
            // tb_nombreArt
            // 
            this.tb_nombreArt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombreArt.Location = new System.Drawing.Point(148, 81);
            this.tb_nombreArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nombreArt.Multiline = true;
            this.tb_nombreArt.Name = "tb_nombreArt";
            this.tb_nombreArt.Size = new System.Drawing.Size(379, 25);
            this.tb_nombreArt.TabIndex = 0;
            // 
            // tb_Descrip
            // 
            this.tb_Descrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Descrip.Location = new System.Drawing.Point(148, 134);
            this.tb_Descrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Descrip.Multiline = true;
            this.tb_Descrip.Name = "tb_Descrip";
            this.tb_Descrip.Size = new System.Drawing.Size(379, 51);
            this.tb_Descrip.TabIndex = 1;
            // 
            // tb_codArt
            // 
            this.tb_codArt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codArt.Location = new System.Drawing.Point(148, 217);
            this.tb_codArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_codArt.Multiline = true;
            this.tb_codArt.Name = "tb_codArt";
            this.tb_codArt.Size = new System.Drawing.Size(379, 25);
            this.tb_codArt.TabIndex = 2;
            // 
            // tb_Precio
            // 
            this.tb_Precio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Precio.Location = new System.Drawing.Point(148, 393);
            this.tb_Precio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Precio.Multiline = true;
            this.tb_Precio.Name = "tb_Precio";
            this.tb_Precio.Size = new System.Drawing.Size(379, 25);
            this.tb_Precio.TabIndex = 5;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(37, 28);
            this.lb_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(233, 37);
            this.lb_Titulo.TabIndex = 12;
            this.lb_Titulo.Text = "Agregar Artículo";
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Agregar.Location = new System.Drawing.Point(419, 447);
            this.bt_Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(109, 36);
            this.bt_Agregar.TabIndex = 6;
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
            this.cBox_Marca.Location = new System.Drawing.Point(148, 277);
            this.cBox_Marca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox_Marca.Name = "cBox_Marca";
            this.cBox_Marca.Size = new System.Drawing.Size(379, 24);
            this.cBox_Marca.TabIndex = 3;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(419, 490);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(108, 34);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cBox_Categoria
            // 
            this.cBox_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Categoria.FormattingEnabled = true;
            this.cBox_Categoria.Location = new System.Drawing.Point(148, 330);
            this.cBox_Categoria.Name = "cBox_Categoria";
            this.cBox_Categoria.Size = new System.Drawing.Size(380, 24);
            this.cBox_Categoria.TabIndex = 14;
            // 
            // Frm_AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(565, 555);
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
            this.Name = "Frm_AgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.Load += new System.EventHandler(this.Frm_AgregarArticulo_Load);
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
    }
}