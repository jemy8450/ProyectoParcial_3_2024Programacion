using CapaEntidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class RegistroVenta : Form
    {
        VentaLOG _ventaLOG;
        ProductoLOG _productoLOG;
        DataTable detalleVenta;

        public RegistroVenta()
        {
            InitializeComponent();

            CargarProductos();

            detalleVenta = new DataTable();
            detalleVenta.Columns.Add("Codigo", typeof(int));
            detalleVenta.Columns.Add("Nombre", typeof(string));
            detalleVenta.Columns.Add("Precio", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));
        }

        private void CargarProductos()
        {
            _productoLOG = new ProductoLOG();
            productoBindingSource.DataSource = _productoLOG.ObtenerProductos();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCodigo.Text))
            {
                _productoLOG = new ProductoLOG();

                int codigo = int.Parse(txtCodigo.Text);

                var producto = _productoLOG.ObtenerProductoPorId(codigo);

                if(producto != null && producto.Estado == true)
                {
                    cbxNombreProducto.Text = producto.Nombre;
                }
                else
                {
                    cbxNombreProducto.Text = "";
                }
            }
            else
            {
                CargarProductos();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                _productoLOG = new ProductoLOG();

                int codigo = int.Parse(txtCodigo.Text);
                int cantidad = int.Parse(txtCantidad.Text);

                var producto = (Producto)productoBindingSource.Current;

                if(producto != null)
                {
                    detalleVenta.Rows.Add(codigo, producto.Nombre, producto.Precio, 
                        cantidad, (cantidad*producto.Precio));

                    dgvDetalleVenta.DataSource = detalleVenta;

                    decimal montoTotal = 0;

                    foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                    {
                        montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
                    }

                    txtMonto.Text = montoTotal.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Tienda|Zapatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
