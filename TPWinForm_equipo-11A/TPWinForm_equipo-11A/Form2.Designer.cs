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
            this.lb_IdArticulo = new System.Windows.Forms.Label();
            this.lb_Cod_Articulo = new System.Windows.Forms.Label();
            this.lb_NombreArticulo = new System.Windows.Forms.Label();
            this.lb_Desc_Articulo = new System.Windows.Forms.Label();
            this.lb_IdMarca = new System.Windows.Forms.Label();
            this.lb_IdCategoria = new System.Windows.Forms.Label();
            this.lb_Precio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_IdArticulo
            // 
            this.lb_IdArticulo.AutoSize = true;
            this.lb_IdArticulo.Location = new System.Drawing.Point(186, 81);
            this.lb_IdArticulo.Name = "lb_IdArticulo";
            this.lb_IdArticulo.Size = new System.Drawing.Size(58, 13);
            this.lb_IdArticulo.TabIndex = 0;
            this.lb_IdArticulo.Text = "ID Artículo";
            // 
            // lb_Cod_Articulo
            // 
            this.lb_Cod_Articulo.AutoSize = true;
            this.lb_Cod_Articulo.Location = new System.Drawing.Point(186, 172);
            this.lb_Cod_Articulo.Name = "lb_Cod_Articulo";
            this.lb_Cod_Articulo.Size = new System.Drawing.Size(95, 13);
            this.lb_Cod_Articulo.TabIndex = 1;
            this.lb_Cod_Articulo.Text = "Codigo de Artículo";
            // 
            // lb_NombreArticulo
            // 
            this.lb_NombreArticulo.AutoSize = true;
            this.lb_NombreArticulo.Location = new System.Drawing.Point(186, 111);
            this.lb_NombreArticulo.Name = "lb_NombreArticulo";
            this.lb_NombreArticulo.Size = new System.Drawing.Size(47, 13);
            this.lb_NombreArticulo.TabIndex = 2;
            this.lb_NombreArticulo.Text = "Nombre ";
            // 
            // lb_Desc_Articulo
            // 
            this.lb_Desc_Articulo.AutoSize = true;
            this.lb_Desc_Articulo.Location = new System.Drawing.Point(186, 140);
            this.lb_Desc_Articulo.Name = "lb_Desc_Articulo";
            this.lb_Desc_Articulo.Size = new System.Drawing.Size(63, 13);
            this.lb_Desc_Articulo.TabIndex = 3;
            this.lb_Desc_Articulo.Text = "Descripción";
            // 
            // lb_IdMarca
            // 
            this.lb_IdMarca.AutoSize = true;
            this.lb_IdMarca.Location = new System.Drawing.Point(186, 201);
            this.lb_IdMarca.Name = "lb_IdMarca";
            this.lb_IdMarca.Size = new System.Drawing.Size(51, 13);
            this.lb_IdMarca.TabIndex = 4;
            this.lb_IdMarca.Text = "ID Marca";
            // 
            // lb_IdCategoria
            // 
            this.lb_IdCategoria.AutoSize = true;
            this.lb_IdCategoria.Location = new System.Drawing.Point(186, 230);
            this.lb_IdCategoria.Name = "lb_IdCategoria";
            this.lb_IdCategoria.Size = new System.Drawing.Size(68, 13);
            this.lb_IdCategoria.TabIndex = 5;
            this.lb_IdCategoria.Text = "ID Categoría";
            // 
            // lb_Precio
            // 
            this.lb_Precio.AutoSize = true;
            this.lb_Precio.Location = new System.Drawing.Point(186, 259);
            this.lb_Precio.Name = "lb_Precio";
            this.lb_Precio.Size = new System.Drawing.Size(37, 13);
            this.lb_Precio.TabIndex = 6;
            this.lb_Precio.Text = "Precio";
            // 
            // frm_Agregar_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 609);
            this.Controls.Add(this.lb_Precio);
            this.Controls.Add(this.lb_IdCategoria);
            this.Controls.Add(this.lb_IdMarca);
            this.Controls.Add(this.lb_Desc_Articulo);
            this.Controls.Add(this.lb_NombreArticulo);
            this.Controls.Add(this.lb_Cod_Articulo);
            this.Controls.Add(this.lb_IdArticulo);
            this.MinimumSize = new System.Drawing.Size(736, 648);
            this.Name = "frm_Agregar_Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Artículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_IdArticulo;
        private System.Windows.Forms.Label lb_Cod_Articulo;
        private System.Windows.Forms.Label lb_NombreArticulo;
        private System.Windows.Forms.Label lb_Desc_Articulo;
        private System.Windows.Forms.Label lb_IdMarca;
        private System.Windows.Forms.Label lb_IdCategoria;
        private System.Windows.Forms.Label lb_Precio;
    }
}