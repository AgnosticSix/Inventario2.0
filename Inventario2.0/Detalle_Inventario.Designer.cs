namespace Inventario2._0
{
    partial class Detalle_Inventario
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
            this.dataGridViewDetalle = new System.Windows.Forms.DataGridView();
            this.id_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboEdificios = new System.Windows.Forms.ComboBox();
            this.comboSalones = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboArticulos = new System.Windows.Forms.ComboBox();
            this.cantidadArticulos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnCancelarInventario = new System.Windows.Forms.Button();
            this.btnGuardarInvetario = new System.Windows.Forms.Button();
            this.btnCancelarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDetalle
            // 
            this.dataGridViewDetalle.AllowUserToAddRows = false;
            this.dataGridViewDetalle.AllowUserToDeleteRows = false;
            this.dataGridViewDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_articulo,
            this.articulo,
            this.cantidad});
            this.dataGridViewDetalle.GridColor = System.Drawing.Color.White;
            this.dataGridViewDetalle.Location = new System.Drawing.Point(13, 32);
            this.dataGridViewDetalle.MultiSelect = false;
            this.dataGridViewDetalle.Name = "dataGridViewDetalle";
            this.dataGridViewDetalle.ReadOnly = true;
            this.dataGridViewDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDetalle.Size = new System.Drawing.Size(498, 386);
            this.dataGridViewDetalle.TabIndex = 0;
            this.dataGridViewDetalle.DoubleClick += new System.EventHandler(this.dataGridViewDetalle_DoubleClick);
            // 
            // id_articulo
            // 
            this.id_articulo.HeaderText = "id_articulo";
            this.id_articulo.Name = "id_articulo";
            this.id_articulo.ReadOnly = true;
            this.id_articulo.Visible = false;
            // 
            // articulo
            // 
            this.articulo.DataPropertyName = "articulo";
            this.articulo.HeaderText = "Articulo";
            this.articulo.MinimumWidth = 200;
            this.articulo.Name = "articulo";
            this.articulo.ReadOnly = true;
            this.articulo.Width = 350;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 70;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(531, 486);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(274, 20);
            this.txtEncargado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encargado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(13, 486);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(498, 160);
            this.txtObservaciones.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edificio";
            // 
            // comboEdificios
            // 
            this.comboEdificios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEdificios.FormattingEnabled = true;
            this.comboEdificios.Location = new System.Drawing.Point(531, 557);
            this.comboEdificios.Name = "comboEdificios";
            this.comboEdificios.Size = new System.Drawing.Size(274, 21);
            this.comboEdificios.TabIndex = 6;
            this.comboEdificios.SelectedIndexChanged += new System.EventHandler(this.comboEdificios_SelectedIndexChanged);
            // 
            // comboSalones
            // 
            this.comboSalones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSalones.FormattingEnabled = true;
            this.comboSalones.Location = new System.Drawing.Point(531, 625);
            this.comboSalones.Name = "comboSalones";
            this.comboSalones.Size = new System.Drawing.Size(274, 21);
            this.comboSalones.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salón";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Articulo";
            // 
            // comboArticulos
            // 
            this.comboArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboArticulos.FormattingEnabled = true;
            this.comboArticulos.Location = new System.Drawing.Point(534, 76);
            this.comboArticulos.Name = "comboArticulos";
            this.comboArticulos.Size = new System.Drawing.Size(271, 21);
            this.comboArticulos.TabIndex = 10;
            // 
            // cantidadArticulos
            // 
            this.cantidadArticulos.Location = new System.Drawing.Point(534, 161);
            this.cantidadArticulos.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cantidadArticulos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidadArticulos.Name = "cantidadArticulos";
            this.cantidadArticulos.Size = new System.Drawing.Size(271, 20);
            this.cantidadArticulos.TabIndex = 11;
            this.cantidadArticulos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad";
            // 
            // btnGuardarArticulo
            // 
            this.btnGuardarArticulo.Location = new System.Drawing.Point(534, 221);
            this.btnGuardarArticulo.Name = "btnGuardarArticulo";
            this.btnGuardarArticulo.Size = new System.Drawing.Size(122, 23);
            this.btnGuardarArticulo.TabIndex = 13;
            this.btnGuardarArticulo.Text = "Guardar";
            this.btnGuardarArticulo.UseVisualStyleBackColor = true;
            this.btnGuardarArticulo.Click += new System.EventHandler(this.btnGuardarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Enabled = false;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(683, 221);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(122, 23);
            this.btnEliminarArticulo.TabIndex = 14;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelarInventario
            // 
            this.btnCancelarInventario.Location = new System.Drawing.Point(683, 683);
            this.btnCancelarInventario.Name = "btnCancelarInventario";
            this.btnCancelarInventario.Size = new System.Drawing.Size(122, 23);
            this.btnCancelarInventario.TabIndex = 16;
            this.btnCancelarInventario.Text = "Cancelar";
            this.btnCancelarInventario.UseVisualStyleBackColor = true;
            this.btnCancelarInventario.Click += new System.EventHandler(this.btnCancelarInventario_Click);
            // 
            // btnGuardarInvetario
            // 
            this.btnGuardarInvetario.Location = new System.Drawing.Point(534, 683);
            this.btnGuardarInvetario.Name = "btnGuardarInvetario";
            this.btnGuardarInvetario.Size = new System.Drawing.Size(122, 23);
            this.btnGuardarInvetario.TabIndex = 15;
            this.btnGuardarInvetario.Text = "Guardar";
            this.btnGuardarInvetario.UseVisualStyleBackColor = true;
            this.btnGuardarInvetario.Click += new System.EventHandler(this.btnGuardarInvetario_Click);
            // 
            // btnCancelarArticulo
            // 
            this.btnCancelarArticulo.Enabled = false;
            this.btnCancelarArticulo.Location = new System.Drawing.Point(534, 264);
            this.btnCancelarArticulo.Name = "btnCancelarArticulo";
            this.btnCancelarArticulo.Size = new System.Drawing.Size(271, 23);
            this.btnCancelarArticulo.TabIndex = 17;
            this.btnCancelarArticulo.Text = "Cancelar";
            this.btnCancelarArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarArticulo.Click += new System.EventHandler(this.btnCancelarArticulo_Click);
            // 
            // Detalle_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 733);
            this.Controls.Add(this.btnCancelarArticulo);
            this.Controls.Add(this.btnCancelarInventario);
            this.Controls.Add(this.btnGuardarInvetario);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnGuardarArticulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cantidadArticulos);
            this.Controls.Add(this.comboArticulos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboSalones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboEdificios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.dataGridViewDetalle);
            this.MaximumSize = new System.Drawing.Size(833, 772);
            this.MinimumSize = new System.Drawing.Size(833, 726);
            this.Name = "Detalle_Inventario";
            this.ShowIcon = false;
            this.Text = "Detalle_Inventario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Detalle_Inventario_FormClosing);
            this.Load += new System.EventHandler(this.Detalle_Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDetalle;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboEdificios;
        private System.Windows.Forms.ComboBox comboSalones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboArticulos;
        private System.Windows.Forms.NumericUpDown cantidadArticulos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnCancelarInventario;
        private System.Windows.Forms.Button btnGuardarInvetario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Button btnCancelarArticulo;
    }
}