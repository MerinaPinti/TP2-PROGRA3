namespace TPWinForm_equipo_11A
{
    partial class Frm_AgregarCategoria
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
            this.bt_Agregar = new System.Windows.Forms.Button();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.tb_nombreCat = new System.Windows.Forms.TextBox();
            this.lb_NombreArticulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Agregar.Location = new System.Drawing.Point(413, 156);
            this.bt_Agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(109, 36);
            this.bt_Agregar.TabIndex = 29;
            this.bt_Agregar.Text = "Agregar";
            this.bt_Agregar.UseVisualStyleBackColor = true;
            this.bt_Agregar.Click += new System.EventHandler(this.bt_Agregar_Click);
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(32, 48);
            this.lb_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(255, 37);
            this.lb_Titulo.TabIndex = 30;
            this.lb_Titulo.Text = "Agregar Categoria";
            // 
            // tb_nombreCat
            // 
            this.tb_nombreCat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombreCat.Location = new System.Drawing.Point(143, 101);
            this.tb_nombreCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nombreCat.Multiline = true;
            this.tb_nombreCat.Name = "tb_nombreCat";
            this.tb_nombreCat.Size = new System.Drawing.Size(379, 25);
            this.tb_nombreCat.TabIndex = 27;
            // 
            // lb_NombreArticulo
            // 
            this.lb_NombreArticulo.AutoSize = true;
            this.lb_NombreArticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NombreArticulo.Location = new System.Drawing.Point(35, 105);
            this.lb_NombreArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_NombreArticulo.Name = "lb_NombreArticulo";
            this.lb_NombreArticulo.Size = new System.Drawing.Size(78, 23);
            this.lb_NombreArticulo.TabIndex = 28;
            this.lb_NombreArticulo.Text = "Nombre ";
            // 
            // Frm_AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 222);
            this.Controls.Add(this.bt_Agregar);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.tb_nombreCat);
            this.Controls.Add(this.lb_NombreArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_AgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Agregar;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.TextBox tb_nombreCat;
        private System.Windows.Forms.Label lb_NombreArticulo;
    }
}