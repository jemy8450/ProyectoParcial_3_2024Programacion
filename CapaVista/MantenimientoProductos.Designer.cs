﻿namespace CapaVista
{
    partial class MantenimientoProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.rdbInactivos = new System.Windows.Forms.RadioButton();
            this.rdbActivos = new System.Windows.Forms.RadioButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.BackColor = System.Drawing.SystemColors.Info;
            this.gbxFiltro.Controls.Add(this.txtFiltroNombre);
            this.gbxFiltro.Controls.Add(this.label2);
            this.gbxFiltro.Controls.Add(this.txtFiltroCodigo);
            this.gbxFiltro.Controls.Add(this.label1);
            this.gbxFiltro.Location = new System.Drawing.Point(12, 24);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(660, 100);
            this.gbxFiltro.TabIndex = 0;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "Filtros por Producto";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(367, 45);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(253, 26);
            this.txtFiltroNombre.TabIndex = 3;
            this.txtFiltroNombre.TextChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged_1);
            this.txtFiltroNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtFiltroCodigo
            // 
            this.txtFiltroCodigo.Location = new System.Drawing.Point(79, 44);
            this.txtFiltroCodigo.Name = "txtFiltroCodigo";
            this.txtFiltroCodigo.Size = new System.Drawing.Size(125, 26);
            this.txtFiltroCodigo.TabIndex = 1;
            this.txtFiltroCodigo.TextChanged += new System.EventHandler(this.txtFiltroCodigo_TextChanged);
            this.txtFiltroCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroCodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoId,
            this.Nombre,
            this.Descripción,
            this.Precio,
            this.Existencias,
            this.Estado,
            this.Editar,
            this.Eliminar});
            this.dgvProductos.Location = new System.Drawing.Point(12, 164);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(982, 407);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNuevo.Location = new System.Drawing.Point(12, 601);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 40);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(898, 601);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 40);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Atras";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gbxEstado
            // 
            this.gbxEstado.BackColor = System.Drawing.SystemColors.Info;
            this.gbxEstado.Controls.Add(this.rdbInactivos);
            this.gbxEstado.Controls.Add(this.rdbActivos);
            this.gbxEstado.Location = new System.Drawing.Point(678, 24);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(316, 100);
            this.gbxEstado.TabIndex = 4;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Filtro por Estado";
            // 
            // rdbInactivos
            // 
            this.rdbInactivos.AutoSize = true;
            this.rdbInactivos.Location = new System.Drawing.Point(153, 47);
            this.rdbInactivos.Name = "rdbInactivos";
            this.rdbInactivos.Size = new System.Drawing.Size(79, 24);
            this.rdbInactivos.TabIndex = 1;
            this.rdbInactivos.Text = "Inactivos";
            this.rdbInactivos.UseVisualStyleBackColor = true;
            this.rdbInactivos.CheckedChanged += new System.EventHandler(this.rdbInactivos_CheckedChanged);
            // 
            // rdbActivos
            // 
            this.rdbActivos.AutoSize = true;
            this.rdbActivos.Checked = true;
            this.rdbActivos.Location = new System.Drawing.Point(23, 47);
            this.rdbActivos.Name = "rdbActivos";
            this.rdbActivos.Size = new System.Drawing.Size(71, 24);
            this.rdbActivos.TabIndex = 0;
            this.rdbActivos.TabStop = true;
            this.rdbActivos.Text = "Activos";
            this.rdbActivos.UseVisualStyleBackColor = true;
            this.rdbActivos.CheckedChanged += new System.EventHandler(this.rdbActivos_CheckedChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaVista.Properties.Resources.edit_v2;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::CapaVista.Properties.Resources.delete;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // ProductoId
            // 
            this.ProductoId.DataPropertyName = "ProductoId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductoId.DefaultCellStyle = dataGridViewCellStyle1;
            this.ProductoId.HeaderText = "Código";
            this.ProductoId.MinimumWidth = 6;
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.ReadOnly = true;
            this.ProductoId.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nombre.HeaderText = "Nombre Producto";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 304;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "Descripcion";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCoral;
            this.Descripción.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Visible = false;
            this.Descripción.Width = 350;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCoral;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Existencias
            // 
            this.Existencias.DataPropertyName = "Existencias";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCoral;
            this.Existencias.DefaultCellStyle = dataGridViewCellStyle5;
            this.Existencias.HeaderText = "Existencias";
            this.Existencias.MinimumWidth = 6;
            this.Existencias.Name = "Existencias";
            this.Existencias.ReadOnly = true;
            this.Existencias.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle6.NullValue = false;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle6;
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Estado.Visible = false;
            this.Estado.Width = 125;
            // 
            // Editar
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            this.Editar.DefaultCellStyle = dataGridViewCellStyle7;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::CapaVista.Properties.Resources.editar__1_;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle8;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::CapaVista.Properties.Resources.eliminar__1_;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 125;
            // 
            // MantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.gbxFiltro);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MantenimientoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda | Mantenimiento de Productos";
            this.Load += new System.EventHandler(this.MantenimientoProductos_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.RadioButton rdbInactivos;
        private System.Windows.Forms.RadioButton rdbActivos;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox txtFiltroCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencias;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}