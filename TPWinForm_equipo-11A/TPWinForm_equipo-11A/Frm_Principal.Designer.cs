namespace TPWinForm_equipo_11A
{
    partial class frm_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tstrip_Archivos = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_Agregar_Archivos = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_Modificar_Archivos = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_Eliminar_Archivos = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_Marcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_Agregar_Marcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_Modificar_Marcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_Eliminar_Marcas = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_Categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_Agregar_Categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_Modificar_Categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.tstrip_Eliminar_Categorias = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrip_Archivos,
            this.tstrip_Marcas,
            this.tstrip_Categorias,
            this.listarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(825, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tstrip_Archivos
            // 
            this.tstrip_Archivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrip_Agregar_Archivos,
            this.tstrip_Modificar_Archivos,
            this.tstrip_Eliminar_Archivos});
            this.tstrip_Archivos.Name = "tstrip_Archivos";
            this.tstrip_Archivos.Size = new System.Drawing.Size(81, 24);
            this.tstrip_Archivos.Text = "&Artículos";
            // 
            // tstrip_Agregar_Archivos
            // 
            this.tstrip_Agregar_Archivos.Name = "tstrip_Agregar_Archivos";
            this.tstrip_Agregar_Archivos.Size = new System.Drawing.Size(156, 26);
            this.tstrip_Agregar_Archivos.Text = "Agregar";
            this.tstrip_Agregar_Archivos.Click += new System.EventHandler(this.tstrip_Agregar_Archivos_Click);
            // 
            // tstrip_Modificar_Archivos
            // 
            this.tstrip_Modificar_Archivos.Name = "tstrip_Modificar_Archivos";
            this.tstrip_Modificar_Archivos.Size = new System.Drawing.Size(156, 26);
            this.tstrip_Modificar_Archivos.Text = "Modificar";
            this.tstrip_Modificar_Archivos.Click += new System.EventHandler(this.tstrip_Modificar_Archivos_Click);
            // 
            // tstrip_Eliminar_Archivos
            // 
            this.tstrip_Eliminar_Archivos.Name = "tstrip_Eliminar_Archivos";
            this.tstrip_Eliminar_Archivos.Size = new System.Drawing.Size(156, 26);
            this.tstrip_Eliminar_Archivos.Text = "Eliminar";
            // 
            // tstrip_Marcas
            // 
            this.tstrip_Marcas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrip_Agregar_Marcas,
            this.tstrip_Modificar_Marcas,
            this.tstrip_Eliminar_Marcas});
            this.tstrip_Marcas.Name = "tstrip_Marcas";
            this.tstrip_Marcas.Size = new System.Drawing.Size(70, 24);
            this.tstrip_Marcas.Text = "Ma&rcas";
            // 
            // tstrip_Agregar_Marcas
            // 
            this.tstrip_Agregar_Marcas.Name = "tstrip_Agregar_Marcas";
            this.tstrip_Agregar_Marcas.Size = new System.Drawing.Size(224, 26);
            this.tstrip_Agregar_Marcas.Text = "Agregar";
            this.tstrip_Agregar_Marcas.Click += new System.EventHandler(this.tstrip_Agregar_Marcas_Click);
            // 
            // tstrip_Modificar_Marcas
            // 
            this.tstrip_Modificar_Marcas.Name = "tstrip_Modificar_Marcas";
            this.tstrip_Modificar_Marcas.Size = new System.Drawing.Size(224, 26);
            this.tstrip_Modificar_Marcas.Text = "Modificar";
            this.tstrip_Modificar_Marcas.Click += new System.EventHandler(this.tstrip_Modificar_Marcas_Click);
            // 
            // tstrip_Eliminar_Marcas
            // 
            this.tstrip_Eliminar_Marcas.Name = "tstrip_Eliminar_Marcas";
            this.tstrip_Eliminar_Marcas.Size = new System.Drawing.Size(224, 26);
            this.tstrip_Eliminar_Marcas.Text = "Eliminar";
            this.tstrip_Eliminar_Marcas.Click += new System.EventHandler(this.tstrip_Eliminar_Marcas_Click);
            // 
            // tstrip_Categorias
            // 
            this.tstrip_Categorias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrip_Agregar_Categorias,
            this.tstrip_Modificar_Categorias,
            this.tstrip_Eliminar_Categorias});
            this.tstrip_Categorias.Name = "tstrip_Categorias";
            this.tstrip_Categorias.Size = new System.Drawing.Size(94, 24);
            this.tstrip_Categorias.Text = "Cate&gorías";
            // 
            // tstrip_Agregar_Categorias
            // 
            this.tstrip_Agregar_Categorias.Name = "tstrip_Agregar_Categorias";
            this.tstrip_Agregar_Categorias.Size = new System.Drawing.Size(224, 26);
            this.tstrip_Agregar_Categorias.Text = "Agregar";
            this.tstrip_Agregar_Categorias.Click += new System.EventHandler(this.tstrip_Agregar_Categorias_Click);
            // 
            // tstrip_Modificar_Categorias
            // 
            this.tstrip_Modificar_Categorias.Name = "tstrip_Modificar_Categorias";
            this.tstrip_Modificar_Categorias.Size = new System.Drawing.Size(224, 26);
            this.tstrip_Modificar_Categorias.Text = "Modificar";
            this.tstrip_Modificar_Categorias.Click += new System.EventHandler(this.tstrip_Modificar_Categorias_Click);
            // 
            // tstrip_Eliminar_Categorias
            // 
            this.tstrip_Eliminar_Categorias.Name = "tstrip_Eliminar_Categorias";
            this.tstrip_Eliminar_Categorias.Size = new System.Drawing.Size(224, 26);
            this.tstrip_Eliminar_Categorias.Text = "Eliminar";
            this.tstrip_Eliminar_Categorias.Click += new System.EventHandler(this.tstrip_Eliminar_Categorias_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoríasToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.listarToolStripMenuItem.Text = "Lista&r";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.archivosToolStripMenuItem.Text = "Artículos";
            this.archivosToolStripMenuItem.Click += new System.EventHandler(this.archivosToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            this.categoríasToolStripMenuItem.Click += new System.EventHandler(this.categoríasToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(516, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.Location = new System.Drawing.Point(765, 1);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(44, 30);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(825, 554);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(841, 591);
            this.Name = "frm_Principal";
            this.Text = "Gestión de Artículos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Archivos;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Agregar_Archivos;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Modificar_Archivos;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Eliminar_Archivos;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Marcas;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Agregar_Marcas;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Modificar_Marcas;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Eliminar_Marcas;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Categorias;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Agregar_Categorias;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Modificar_Categorias;
        private System.Windows.Forms.ToolStripMenuItem tstrip_Eliminar_Categorias;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
    }
}

