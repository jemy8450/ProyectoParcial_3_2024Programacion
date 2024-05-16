namespace CapaVista
{
    partial class RegistroTransaccion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroTransaccion));
            this.dgvTransacciones = new System.Windows.Forms.DataGridView();
            this.detallesDeVentaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesDeVentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.VentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesDeVentaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesDeVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransacciones
            // 
            this.dgvTransacciones.AllowUserToAddRows = false;
            this.dgvTransacciones.AllowUserToDeleteRows = false;
            this.dgvTransacciones.AutoGenerateColumns = false;
            this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detallesDeVentaIdDataGridViewTextBoxColumn,
            this.ventaIdDataGridViewTextBoxColumn,
            this.productoIdDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.ventaDataGridViewTextBoxColumn});
            this.dgvTransacciones.DataSource = this.detallesDeVentaBindingSource1;
            this.dgvTransacciones.Location = new System.Drawing.Point(12, 103);
            this.dgvTransacciones.Name = "dgvTransacciones";
            this.dgvTransacciones.ReadOnly = true;
            this.dgvTransacciones.RowHeadersWidth = 51;
            this.dgvTransacciones.Size = new System.Drawing.Size(775, 252);
            this.dgvTransacciones.TabIndex = 0;
            // 
            // detallesDeVentaIdDataGridViewTextBoxColumn
            // 
            this.detallesDeVentaIdDataGridViewTextBoxColumn.DataPropertyName = "DetallesDeVentaId";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.detallesDeVentaIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.detallesDeVentaIdDataGridViewTextBoxColumn.HeaderText = "Codigo Registro";
            this.detallesDeVentaIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detallesDeVentaIdDataGridViewTextBoxColumn.Name = "detallesDeVentaIdDataGridViewTextBoxColumn";
            this.detallesDeVentaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.detallesDeVentaIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // ventaIdDataGridViewTextBoxColumn
            // 
            this.ventaIdDataGridViewTextBoxColumn.DataPropertyName = "VentaId";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ventaIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.ventaIdDataGridViewTextBoxColumn.HeaderText = "Codigo Venta";
            this.ventaIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ventaIdDataGridViewTextBoxColumn.Name = "ventaIdDataGridViewTextBoxColumn";
            this.ventaIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ventaIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // productoIdDataGridViewTextBoxColumn
            // 
            this.productoIdDataGridViewTextBoxColumn.DataPropertyName = "ProductoId";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productoIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle23;
            this.productoIdDataGridViewTextBoxColumn.HeaderText = "Codigo Producto";
            this.productoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoIdDataGridViewTextBoxColumn.Name = "productoIdDataGridViewTextBoxColumn";
            this.productoIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cantidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 150;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoDataGridViewTextBoxColumn.Visible = false;
            this.productoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ventaDataGridViewTextBoxColumn
            // 
            this.ventaDataGridViewTextBoxColumn.DataPropertyName = "Venta";
            this.ventaDataGridViewTextBoxColumn.HeaderText = "Venta";
            this.ventaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ventaDataGridViewTextBoxColumn.Name = "ventaDataGridViewTextBoxColumn";
            this.ventaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ventaDataGridViewTextBoxColumn.Visible = false;
            this.ventaDataGridViewTextBoxColumn.Width = 125;
            // 
            // detallesDeVentaBindingSource1
            // 
            this.detallesDeVentaBindingSource1.DataSource = typeof(CapaEntidades.DetallesDeVenta);
            // 
            // DetalleVentaBindingSource
            // 
            this.DetalleVentaBindingSource.DataSource = typeof(CapaEntidades.DetallesDeVenta);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Transacciones";
            // 
            // VentaBindingSource
            // 
            this.VentaBindingSource.DataSource = typeof(CapaEntidades.Venta);
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataSource = typeof(CapaEntidades.Producto);
            // 
            // detallesDeVentaBindingSource
            // 
            this.detallesDeVentaBindingSource.DataSource = typeof(CapaEntidades.DetallesDeVenta);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistroTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTransacciones);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroTransaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda | Registro Transaccion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesDeVentaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesDeVentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransacciones;
        private System.Windows.Forms.BindingSource DetalleVentaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource VentaBindingSource;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private System.Windows.Forms.BindingSource detallesDeVentaBindingSource;
        private System.Windows.Forms.BindingSource detallesDeVentaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallesDeVentaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}