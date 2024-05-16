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

        ////////////////////////////////////////////////////////////////////
        private void CargarProductos()
        {
            _productoLOG = new ProductoLOG();
            productoBindingSource.DataSource = _productoLOG.ObtenerProductos();
        }

        //private void CargarProductos2()
        //{
        //    _ventaLOG = new VentaLOG();
        //    ventaBindingSource.DataSource = _ventaLOG.ObtenerProductos();
        //}

        ////////////////////////////////////////////////////////////////////
        private void cbxProductoId_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxProductoId.Text))
            {
                _productoLOG = new ProductoLOG();

                int Codigo = int.Parse(cbxProductoId.Text);

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

                int codigo = int.Parse(cbxProductoId.Text);
                int cantidad = int.Parse(txtCantidad.Text);

                var producto = (Producto)productoBindingSource.Current;

                if (producto != null)
                {
                    detalleVenta.Rows.Add(codigo, producto.Nombre, producto.PrecioUnitario,
                        cantidad, (cantidad * producto.PrecioUnitario));

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
                    detalleVenta.Rows.Clear();
                    CargarProductos();
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
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////////////////////////////////////////////////////////////////////
        private void dgvDetalleVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0 )
                {
                    bool precioValido = decimal.TryParse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Precio"].Value.ToString(), out decimal precio);
                    int cantidad = int.Parse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());

                    if (precioValido && cantidad > 0)
                    {
                        decimal Subtotal = precio * cantidad;
                        dgvDetalleVenta.Rows[e.RowIndex].Cells["SubTotal"].Value = Subtotal;

                        CalcularMontoTotal();
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un precio válido", "UNAB|Chalatenango",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error", "UNAB|Chalatenango",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////////////////////////////////////////////////////////////////////
        private void CalcularMontoTotal()
        {
            decimal montoTotal = 0;

            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
            }

            //foreach (DataRow row in detalleVenta.Rows)
            //{
            //    montoTotal += (int)row["Subtotal"];
            //}

            txtMonto.Text = montoTotal.ToString();

        }

        ////////////////////////////////////////////////////////////////////
        private void cbxProductoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbxProductoId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////
        //private void dgvDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        //        {
        //            int id = int.Parse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());

        //            if (dgvDetalleVenta.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
        //            {
        //                var dialogo = MessageBox.Show("¿Esta seguro que desea eliminar el producto?", "Tienda | Eliminar Producto",
        //                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        //                if (dialogo != DialogResult.Yes)
        //                {
        //                    MessageBox.Show("Operacion cancelada", "Tienda | Eliminar Producto",
        //                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    return;
        //                }
        //                else
        //                {///
        //                    _ventaLOG = new VentaLOG();

        //                    detalleVenta.Rows.Add(codigo, producto.Nombre, producto.Precio,
        //                cantidad, (cantidad * producto.Precio));

        //                    dgvDetalleVenta.DataSource = detalleVenta;

        //                    if (resultado > 0)
        //                    {
        //                        MessageBox.Show("Producto eliminado con exito", "Tienda | Eliminar Producto",
        //                        MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                        CargarProductos();
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("No se logro eliminar el producto", "Tienda | Eliminar Producto",
        //                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Ocurrio un error", "UNAB|Chalatenango",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        ////////////////////////////////////////////////////////////////////
    }
}
