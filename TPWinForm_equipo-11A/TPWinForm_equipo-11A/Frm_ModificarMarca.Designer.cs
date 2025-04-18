namespace TPWinForm_equipo_11A
{
    partial class Frm_ModificarMarca
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
            this.tb_nombreArt = new System.Windows.Forms.TextBox();
            this.lb_NombreArticulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Agregar.Location = new System.Drawing.Point(307, 127);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(82, 29);
            this.bt_Agregar.TabIndex = 29;
            this.bt_Agregar.Text = "Aceptar";
            this.bt_Agregar.UseVisualStyleBackColor = true;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(21, 39);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(184, 30);
            this.lb_Titulo.TabIndex = 30;
            this.lb_Titulo.Text = "Modificar Marca";
            // 
            // tb_nombreArt
            // 
            this.tb_nombreArt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombreArt.Location = new System.Drawing.Point(104, 82);
            this.tb_nombreArt.Multiline = true;
            this.tb_nombreArt.Name = "tb_nombreArt";
            this.tb_nombreArt.Size = new System.Drawing.Size(285, 21);
            this.tb_nombreArt.TabIndex = 27;
            // 
            // lb_NombreArticulo
            // 
            this.lb_NombreArticulo.AutoSize = true;
            this.lb_NombreArticulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NombreArticulo.Location = new System.Drawing.Point(23, 85);
            this.lb_NombreArticulo.Name = "lb_NombreArticulo";
            this.lb_NombreArticulo.Size = new System.Drawing.Size(61, 17);
            this.lb_NombreArticulo.TabIndex = 28;
            this.lb_NombreArticulo.Text = "Nombre ";
            // 
            // Frm_ModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 180);
            this.Controls.Add(this.bt_Agregar);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.tb_nombreArt);
            this.Controls.Add(this.lb_NombreArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_ModificarMarca";
            this.Text = "ModificarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Agregar;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.TextBox tb_nombreArt;
        private System.Windows.Forms.Label lb_NombreArticulo;
    }
}