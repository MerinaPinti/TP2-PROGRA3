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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListarMarcas
            // 
            this.dgv_ListarMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListarMarcas.Location = new System.Drawing.Point(36, 77);
            this.dgv_ListarMarcas.Name = "dgv_ListarMarcas";
            this.dgv_ListarMarcas.RowHeadersWidth = 51;
            this.dgv_ListarMarcas.RowTemplate.Height = 24;
            this.dgv_ListarMarcas.Size = new System.Drawing.Size(296, 277);
            this.dgv_ListarMarcas.TabIndex = 0;
            // 
            // Frm_ListarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.dgv_ListarMarcas);
            this.Name = "Frm_ListarMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ListarMarcas";
            this.Load += new System.EventHandler(this.Frm_ListarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListarMarcas;
    }
}