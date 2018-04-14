namespace Inventario2._0
{
    partial class Inventario
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
            this.inventariosDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edificiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSeleccionado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.invBox = new System.Windows.Forms.ComboBox();
            this.id_inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_salon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codSalon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_actualizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inventariosDGV
            // 
            this.inventariosDGV.AllowUserToAddRows = false;
            this.inventariosDGV.AllowUserToDeleteRows = false;
            this.inventariosDGV.AllowUserToOrderColumns = true;
            this.inventariosDGV.BackgroundColor = System.Drawing.Color.White;
            this.inventariosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventariosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_inventario,
            this.id_edificio,
            this.id_salon,
            this.salon,
            this.codSalon,
            this.edificio,
            this.encargado,
            this.totales,
            this.diferentes,
            this.observaciones,
            this.fecha_creacion,
            this.fecha_actualizado});
            this.inventariosDGV.GridColor = System.Drawing.Color.White;
            this.inventariosDGV.Location = new System.Drawing.Point(12, 52);
            this.inventariosDGV.MultiSelect = false;
            this.inventariosDGV.Name = "inventariosDGV";
            this.inventariosDGV.ReadOnly = true;
            this.inventariosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventariosDGV.Size = new System.Drawing.Size(1244, 468);
            this.inventariosDGV.TabIndex = 0;
            this.inventariosDGV.DoubleClick += new System.EventHandler(this.inventariosDGV_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramientasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExcelToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a Excel";
            this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edificiosToolStripMenuItem,
            this.salonesToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.nuevoInventarioToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.herramientasToolStripMenuItem.Text = "Administrar";
            // 
            // edificiosToolStripMenuItem
            // 
            this.edificiosToolStripMenuItem.Name = "edificiosToolStripMenuItem";
            this.edificiosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.edificiosToolStripMenuItem.Text = "Edificios";
            this.edificiosToolStripMenuItem.Click += new System.EventHandler(this.edificiosToolStripMenuItem_Click);
            // 
            // salonesToolStripMenuItem
            // 
            this.salonesToolStripMenuItem.Name = "salonesToolStripMenuItem";
            this.salonesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.salonesToolStripMenuItem.Text = "Salones";
            this.salonesToolStripMenuItem.Click += new System.EventHandler(this.salonesToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // nuevoInventarioToolStripMenuItem
            // 
            this.nuevoInventarioToolStripMenuItem.Name = "nuevoInventarioToolStripMenuItem";
            this.nuevoInventarioToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.nuevoInventarioToolStripMenuItem.Text = "Nuevo inventario";
            this.nuevoInventarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoInventarioToolStripMenuItem_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(595, 565);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(329, 565);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(110, 23);
            this.btnDetalle.TabIndex = 3;
            this.btnDetalle.Text = "Ver detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(462, 565);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtSeleccionado
            // 
            this.txtSeleccionado.Location = new System.Drawing.Point(12, 568);
            this.txtSeleccionado.Name = "txtSeleccionado";
            this.txtSeleccionado.ReadOnly = true;
            this.txtSeleccionado.Size = new System.Drawing.Size(274, 20);
            this.txtSeleccionado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 543);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccionado";
            // 
            // invBox
            // 
            this.invBox.FormattingEnabled = true;
            this.invBox.Location = new System.Drawing.Point(735, 565);
            this.invBox.Name = "invBox";
            this.invBox.Size = new System.Drawing.Size(121, 21);
            this.invBox.TabIndex = 8;
            this.invBox.SelectedIndexChanged += new System.EventHandler(this.invBox_SelectedIndexChanged);
            // 
            // id_inventario
            // 
            this.id_inventario.DataPropertyName = "id_inventario";
            this.id_inventario.HeaderText = "id_inventario";
            this.id_inventario.Name = "id_inventario";
            this.id_inventario.ReadOnly = true;
            // 
            // id_edificio
            // 
            this.id_edificio.DataPropertyName = "id_edificio";
            this.id_edificio.HeaderText = "id_edificio";
            this.id_edificio.Name = "id_edificio";
            this.id_edificio.ReadOnly = true;
            this.id_edificio.Visible = false;
            // 
            // id_salon
            // 
            this.id_salon.DataPropertyName = "id_salon";
            this.id_salon.HeaderText = "id_salon";
            this.id_salon.Name = "id_salon";
            this.id_salon.ReadOnly = true;
            this.id_salon.Visible = false;
            // 
            // salon
            // 
            this.salon.DataPropertyName = "salon";
            this.salon.HeaderText = "Salón";
            this.salon.MinimumWidth = 50;
            this.salon.Name = "salon";
            this.salon.ReadOnly = true;
            // 
            // codSalon
            // 
            this.codSalon.DataPropertyName = "codSalon";
            this.codSalon.HeaderText = "Código Salon";
            this.codSalon.MinimumWidth = 50;
            this.codSalon.Name = "codSalon";
            this.codSalon.ReadOnly = true;
            // 
            // edificio
            // 
            this.edificio.DataPropertyName = "edificio";
            this.edificio.HeaderText = "Edificio";
            this.edificio.MinimumWidth = 80;
            this.edificio.Name = "edificio";
            this.edificio.ReadOnly = true;
            this.edificio.Width = 180;
            // 
            // encargado
            // 
            this.encargado.DataPropertyName = "encargado";
            this.encargado.HeaderText = "Encargado";
            this.encargado.MinimumWidth = 50;
            this.encargado.Name = "encargado";
            this.encargado.ReadOnly = true;
            this.encargado.Width = 180;
            // 
            // totales
            // 
            this.totales.DataPropertyName = "totales";
            this.totales.HeaderText = "Art. Totales";
            this.totales.MinimumWidth = 50;
            this.totales.Name = "totales";
            this.totales.ReadOnly = true;
            // 
            // diferentes
            // 
            this.diferentes.DataPropertyName = "diferentes";
            this.diferentes.HeaderText = "Art. Diferentes";
            this.diferentes.MinimumWidth = 50;
            this.diferentes.Name = "diferentes";
            this.diferentes.ReadOnly = true;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.MinimumWidth = 200;
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Width = 500;
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.DataPropertyName = "fecha_creacion";
            this.fecha_creacion.HeaderText = "Creado";
            this.fecha_creacion.MinimumWidth = 50;
            this.fecha_creacion.Name = "fecha_creacion";
            this.fecha_creacion.ReadOnly = true;
            this.fecha_creacion.Width = 120;
            // 
            // fecha_actualizado
            // 
            this.fecha_actualizado.DataPropertyName = "fecha_actualizado";
            this.fecha_actualizado.HeaderText = "Actualizado";
            this.fecha_actualizado.MinimumWidth = 50;
            this.fecha_actualizado.Name = "fecha_actualizado";
            this.fecha_actualizado.ReadOnly = true;
            this.fecha_actualizado.Width = 120;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1268, 604);
            this.Controls.Add(this.invBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeleccionado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.inventariosDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1284, 643);
            this.MinimumSize = new System.Drawing.Size(1284, 643);
            this.Name = "Inventario";
            this.ShowIcon = false;
            this.Text = "Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inventario_FormClosing);
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventariosDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inventariosDGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edificiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoInventarioToolStripMenuItem;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtSeleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox invBox;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_salon;
        private System.Windows.Forms.DataGridViewTextBoxColumn salon;
        private System.Windows.Forms.DataGridViewTextBoxColumn codSalon;
        private System.Windows.Forms.DataGridViewTextBoxColumn edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn diferentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_actualizado;
    }
}