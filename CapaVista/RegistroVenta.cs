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
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                _productoLOG = new ProductoLOG();

                int Codigo = int.Parse(txtCodigo.Text);

                var producto = _productoLOG.ObtenerProductoPorId(Codigo);
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

        ////////////////////////////////////////////////////////////////////
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                _productoLOG = new ProductoLOG();

                int codigo = int.Parse(txtCodigo.Text);
                int cantidad = int.Parse(txtCantidad.Text);

                var producto = (Producto)productoBindingSource.Current;

                if (producto != null)
                {
                    detalleVenta.Rows.Add(codigo, producto.Nombre, producto.Precio,
                        cantidad, (cantidad * producto.Precio));

                    dgvDetalleVenta.DataSource = detalleVenta;
                }

                CalcularMontoTotal();
                }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "UNAB|Chalatenango",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ////////////////////////////////////////////////////////////////////
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                _ventaLOG = new VentaLOG();

                Venta venta = new Venta();

                venta.FechaVenta = DateTime.Now;
                venta.Total = decimal.Parse(txtMonto.Text);

                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                {
                    var detalle = new DetallesDeVenta()
                    {
                        ProductoId = int.Parse(row.Cells["Codigo"].Value.ToString()),
                        Precio = decimal.Parse(row.Cells["Precio"].Value.ToString()),
                        Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString()),
                    };

                    venta.Detalles.Add(detalle);
                }

                int resultado = _ventaLOG.GuardarVenta(venta);

                if (resultado > 0)
                {
                    MessageBox.Show("Venta Guardada con éxito", "Tienda | Registro venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se logro guardar la venta", "Tienda | Registro venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error", "UNAB|Chalatenango",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////////////////////////////////////////////////////////////////////
        private void cbxNombreProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtExistencias_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
