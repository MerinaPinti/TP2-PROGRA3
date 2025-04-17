namespace TPWinForm_equipo_11A
{
    partial class Frm_ListarCategorias
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
            this.dgv_ListarCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListarCategorias
            // 
            this.dgv_ListarCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListarCategorias.Location = new System.Drawing.Point(204, 78);
            this.dgv_ListarCategorias.Name = "dgv_ListarCategorias";
            this.dgv_ListarCategorias.Size = new System.Drawing.Size(421, 264);
            this.dgv_ListarCategorias.TabIndex = 0;
            // 
            // Frm_ListarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_ListarCategorias);
            this.Name = "Frm_ListarCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Categorías";
            this.Load += new System.EventHandler(this.Frm_ListarCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListarCategorias;
    }
}