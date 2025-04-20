namespace TPWinForm_equipo_11A
{
    partial class Frm_ListarArticulos
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
            this.dgv_listadoArticulos = new System.Windows.Forms.DataGridView();
            this.pb_articulos = new System.Windows.Forms.PictureBox();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listadoArticulos
            // 
            this.dgv_listadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoArticulos.Location = new System.Drawing.Point(12, 96);
            this.dgv_listadoArticulos.Name = "dgv_listadoArticulos";
            this.dgv_listadoArticulos.Size = new System.Drawing.Size(796, 356);
            this.dgv_listadoArticulos.TabIndex = 0;
            this.dgv_listadoArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listadoArticulos_CellContentClick);
            this.dgv_listadoArticulos.SelectionChanged += new System.EventHandler(this.dgv_listadoArticulos_SelectionChanged);
            // 
            // pb_articulos
            // 
            this.pb_articulos.Location = new System.Drawing.Point(814, 96);
            this.pb_articulos.Name = "pb_articulos";
            this.pb_articulos.Size = new System.Drawing.Size(350, 356);
            this.pb_articulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_articulos.TabIndex = 1;
            this.pb_articulos.TabStop = false;
            // 
            // bt_modificar
            // 
            this.bt_modificar.Location = new System.Drawing.Point(93, 458);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(75, 23);
            this.bt_modificar.TabIndex = 2;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(12, 458);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(75, 23);
            this.bt_agregar.TabIndex = 3;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // Frm_ListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 568);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.pb_articulos);
            this.Controls.Add(this.dgv_listadoArticulos);
            this.Name = "Frm_ListarArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Artículos";
            this.Load += new System.EventHandler(this.Frm_ListarArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_articulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listadoArticulos;
        private System.Windows.Forms.PictureBox pb_articulos;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Button bt_agregar;
    }
}