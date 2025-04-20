namespace TPWinForm_equipo_11A
{
    partial class Frm_ListarMarcas
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
            this.dgv_ListarMarcas = new System.Windows.Forms.DataGridView();
            this.btn_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListarMarcas
            // 
            this.dgv_ListarMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListarMarcas.Location = new System.Drawing.Point(27, 50);
            this.dgv_ListarMarcas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_ListarMarcas.Name = "dgv_ListarMarcas";
            this.dgv_ListarMarcas.RowHeadersWidth = 51;
            this.dgv_ListarMarcas.RowTemplate.Height = 24;
            this.dgv_ListarMarcas.Size = new System.Drawing.Size(401, 281);
            this.dgv_ListarMarcas.TabIndex = 0;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(27, 366);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(69, 25);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // Frm_ListarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 432);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.dgv_ListarMarcas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_ListarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Marcas";
            this.Load += new System.EventHandler(this.Frm_ListarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListarMarcas;
        private System.Windows.Forms.Button btn_Modificar;
    }
}