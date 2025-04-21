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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            this.lbl_Filtro = new System.Windows.Forms.Label();
            this.lb_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listadoArticulos
            // 
            this.dgv_listadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_listadoArticulos.Location = new System.Drawing.Point(15, 106);
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
            this.pb_articulos.Location = new System.Drawing.Point(817, 106);
            this.pb_articulos.Name = "pb_articulos";
            this.pb_articulos.Size = new System.Drawing.Size(350, 356);
            this.pb_articulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_articulos.TabIndex = 1;
            this.pb_articulos.TabStop = false;
            // 
            // bt_modificar
            // 
            this.bt_modificar.Location = new System.Drawing.Point(96, 468);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(75, 23);
            this.bt_modificar.TabIndex = 2;
            this.bt_modificar.Text = "Modificar";
            this.bt_modificar.UseVisualStyleBackColor = true;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(15, 468);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(75, 23);
            this.bt_agregar.TabIndex = 3;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(177, 468);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // tb_filtro
            // 
            this.tb_filtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_filtro.Location = new System.Drawing.Point(53, 72);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(176, 20);
            this.tb_filtro.TabIndex = 5;
            this.tb_filtro.TextChanged += new System.EventHandler(this.tb_filtro_TextChanged);
            // 
            // lbl_Filtro
            // 
            this.lbl_Filtro.AutoSize = true;
            this.lbl_Filtro.Location = new System.Drawing.Point(15, 75);
            this.lbl_Filtro.Name = "lbl_Filtro";
            this.lbl_Filtro.Size = new System.Drawing.Size(32, 13);
            this.lbl_Filtro.TabIndex = 6;
            this.lbl_Filtro.Text = "Filtro:";
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.Location = new System.Drawing.Point(10, 18);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(187, 30);
            this.lb_Titulo.TabIndex = 27;
            this.lb_Titulo.Text = "Listado Artículos";
            // 
            // Frm_ListarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 517);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.lbl_Filtro);
            this.Controls.Add(this.tb_filtro);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.bt_modificar);
            this.Controls.Add(this.pb_articulos);
            this.Controls.Add(this.dgv_listadoArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.TextBox tb_filtro;
        private System.Windows.Forms.Label lbl_Filtro;
        private System.Windows.Forms.Label lb_Titulo;
    }
}