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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListarCategorias
            // 
            this.dgv_ListarCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListarCategorias.Location = new System.Drawing.Point(272, 96);
            this.dgv_ListarCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_ListarCategorias.Name = "dgv_ListarCategorias";
            this.dgv_ListarCategorias.RowHeadersWidth = 51;
            this.dgv_ListarCategorias.Size = new System.Drawing.Size(561, 325);
            this.dgv_ListarCategorias.TabIndex = 0;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(272, 459);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(103, 37);
            this.btn_modificar.TabIndex = 1;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(392, 459);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(103, 37);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Frm_ListarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.dgv_ListarCategorias);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_ListarCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Categorías";
            this.Load += new System.EventHandler(this.Frm_ListarCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListarCategorias;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_Eliminar;
    }
}