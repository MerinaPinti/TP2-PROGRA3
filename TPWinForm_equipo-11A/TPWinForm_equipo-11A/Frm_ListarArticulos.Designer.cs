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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListarArticulos));
            this.dgv_listadoArticulos = new System.Windows.Forms.DataGridView();
            this.pb_articulos = new System.Windows.Forms.PictureBox();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listadoArticulos
            // 
            this.dgv_listadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_listadoArticulos.Location = new System.Drawing.Point(12, 96);
            this.dgv_listadoArticulos.MultiSelect = false;
            this.dgv_listadoArticulos.Name = "dgv_listadoArticulos";
            this.dgv_listadoArticulos.RowHeadersWidth = 51;
            this.dgv_listadoArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(174, 458);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.Location = new System.Drawing.Point(1131, 54);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(33, 24);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // tb_filtro
            // 
            this.tb_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_filtro.Location = new System.Drawing.Point(944, 57);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(176, 20);
            this.tb_filtro.TabIndex = 5;
            // 
            // Frm_ListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 568);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.tb_filtro);
            this.Controls.Add(this.btn_Eliminar);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listadoArticulos;
        private System.Windows.Forms.PictureBox pb_articulos;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox tb_filtro;
    }
}