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
        int _id = 0;

        public RegistroProducto(int id = 0)
        {
            InitializeComponent();

            _id = id;

            if (_id > 0)
            {
                this.Text = "Tienda | Edicion de Productos";
                btnGuardar.Text = "Actualizar";

                CargarDatos(_id);
            }
            else
            {
            ProductoBindingSource.MoveLast();
            ProductoBindingSource.AddNew();
            }
        }

        private void CargarDatos(int id)
        {
            _productoLOG = new ProductoLOG();

            ProductoBindingSource.DataSource = _productoLOG.ObtenerProductoPorId(id);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        //// Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //// Guardar nuevo producto
        private void GuardarProducto()
        {
            // Control de excepciones
            try
            {
                _productoLOG = new ProductoLOG();

                //// Nombre
                // throw new Exception();
                if (String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Se requiere el nombre del producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    txtNombre.BackColor = Color.LightCyan;
                    return;
                }

                //// Descripcion
                if (String.IsNullOrEmpty(txtDescripción.Text))
                {
                    MessageBox.Show("Se requiere la descripción del producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescripción.Focus();
                    txtDescripción.BackColor = Color.LightCyan;
                    return;
                }

                //// Precio
                if (String.IsNullOrEmpty(txtPrecio.Text) || Convert.ToDecimal(txtPrecio.Text) == 0)
                {
                    MessageBox.Show("Se requiere el precio del producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                    txtPrecio.BackColor = Color.LightCyan;
                    return;
                }

                //// Existencias
                if (String.IsNullOrEmpty(txtExistencias.Text) || Convert.ToDecimal(txtExistencias.Text) == 0)
                {
                    MessageBox.Show("Se requiere agregar existencias del producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtExistencias.Focus();
                    //txtExistencias.BackColor = Color.LightCyan;
                    return;
                }

                //// Estado
                if (!chkEstado.Checked)
                {
                    var dialogo = MessageBox.Show("¿Esta seguro que desea guardar el producto inactivo?", "Tienda | Registro Productos",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro Estado como activo", "Tienda | Registro Productos",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                int resultado;

                if (_id > 0)
                {
                    Producto producto;

                    producto = (Producto)ProductoBindingSource.Current; // Hay que hacer el casteo a producto

                    resultado = _productoLOG.ActualizarProducto(producto, _id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto actualizado con exito", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro actualizar el producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    ProductoBindingSource.EndEdit();

                    Producto producto;
                    producto = (Producto)ProductoBindingSource.Current;

                    resultado = _productoLOG.GuardarProducto(producto);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto agregado con exito", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro guardar el producto", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////

    }
}
