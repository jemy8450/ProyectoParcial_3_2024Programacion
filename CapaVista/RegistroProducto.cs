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
    public partial class RegistroProducto : Form
    {
        ProductoLOG _productoLOG;

        public RegistroProducto()
        {
            InitializeComponent();

            ProductoBindingSource.MoveLast();
            ProductoBindingSource.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarProducto()
        {
            try
            {
                _productoLOG = new ProductoLOG();

                //throw new Exception();
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Se requiere el nombre del producto","Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    txtNombre.BackColor = Color.LightCyan;
                    return;
                }

                if (String.IsNullOrEmpty(txtDescripción.Text))
                {
                    MessageBox.Show("Se requiere la descripción del producto","Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripción.Focus();
                    txtDescripción.BackColor = Color.LightCyan;
                    return;
                }

                if (String.IsNullOrEmpty(txtPrecio.Text) || Convert.ToDecimal(txtPrecio.Text) == 0)
                {
                    MessageBox.Show("Se requiere el precio del producto","Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                    txtPrecio.BackColor = Color.LightCyan;
                    return;
                }

                if (String.IsNullOrEmpty(txtExistencias.Text) || Convert.ToDecimal(txtExistencias.Text) == 0)
                {
                    MessageBox.Show("Se requiere agregar existencias del producto","Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtExistencias.Focus();
                    txtExistencias.BackColor = Color.LightCyan;
                    return;
                }

                if (!chkEstado.Checked)
                {
                    var dialogo = MessageBox.Show("¿Esta seguro que desa guardar el producto inactivo?","Tienda | Registro Productos",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro Estado como activo","Tienda | Registro Productos",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                ProductoBindingSource.EndEdit();

                Producto producto;
                producto = (Producto)ProductoBindingSource.Current;

                int resultado = _productoLOG.GuardarProducto(producto);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto agregado con exito","Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se logro guardar el producto","Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //

            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error","Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
