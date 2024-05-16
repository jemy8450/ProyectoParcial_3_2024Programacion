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
    
    public partial class MantenimientoProductos : Form
    {
        ProductoLOG _productoLOG;

        public MantenimientoProductos()
        {
            InitializeComponent();

            CargarProductos();
        }

        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RegistroProducto objRegistroProducto = new RegistroProducto();
            objRegistroProducto.ShowDialog();
            CargarProductos();
        }

        private void CargarProductos()
        {
            _productoLOG = new ProductoLOG();

            if (rdbActivos.Checked)
            {
                dgvProductos.DataSource = _productoLOG.ObtenerProductos();

            }
            else if (rdbInactivos.Checked)
            {
                dgvProductos.DataSource = _productoLOG.ObtenerProductos(true);

            }

        }
        
        ////////////////////////////////////////////////
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvProductos.Rows[e.RowIndex].Cells["ProductoId"].Value.ToString());

                    if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Editar")) // Equals compara Strings
                    {
                        RegistroProducto objRegistroProducto = new RegistroProducto(id);
                        objRegistroProducto.ShowDialog();
                        CargarProductos();
                    }
                    else if (dgvProductos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var dialogo = MessageBox.Show("¿Esta seguro que desea eliminar el producto?", "Tienda | Eliminar Producto",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialogo != DialogResult.Yes)
                        {
                            MessageBox.Show("Operacion cancelada", "Tienda | Eliminar Producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            _productoLOG = new ProductoLOG();

                            int resultado = _productoLOG.EliminarProducto(id);

                            if (resultado > 0)
                            {
                                MessageBox.Show("Producto eliminado con exito", "Tienda | Eliminar Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CargarProductos();
                            }
                            else
                            {
                                MessageBox.Show("No se logro eliminar el producto", "Tienda | Eliminar Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void gpbxFiltro_Enter(object sender, EventArgs e)
        {

        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////

        private void txtFiltroCodigo_TextChanged(object sender, EventArgs e)
        {
            
            if (txtFiltroCodigo.Text == "")
            {
                //MessageBox.Show("Ocurrio un XDDDDDDDDDD");
                
                CargarProductos();

            }
            else if (int.TryParse(txtFiltroCodigo.Text, out int codigo))
            {
                var producto = _productoLOG.ObtenerProductoPorId(codigo);

                if (producto != null)
                {

                    dgvProductos.DataSource = new List<Producto> { producto };

                    
                    _productoLOG = new ProductoLOG();

                }
                else
                {
                    try
                    {
                        List<DataGridViewColumn> columnas = new List<DataGridViewColumn>();
                        List<DataGridViewColumn> columnasEs = new List<DataGridViewColumn>();
                        foreach (DataGridViewColumn columna in dgvProductos.Columns)
                        {
                            if (columna.Name != "Editar" && columna.Name != "Eliminar")
                            {
                                columnas.Add(columna.Clone() as DataGridViewColumn);
                            }
                            else
                            {
                                columnasEs.Add(columna.Clone() as DataGridViewColumn);
                            }
                        }

                        dgvProductos.DataSource = null;
                        dgvProductos.Rows.Clear();
                        dgvProductos.Columns.Clear();

                        foreach (var columna in columnas)
                        {
                            dgvProductos.Columns.Add(columna.Clone() as DataGridViewColumn);
                        }

                        DataGridViewColumn columnb = dgvProductos.Columns[dgvProductos.ColumnCount - 1];
                        foreach (var columna in columnasEs)
                        {

                            dgvProductos.Columns.Add(columna.Clone() as DataGridViewColumn);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error de filtrado: {ex.Message}", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtFiltroCodigo.Text = "";
                    }
                }
            }
            Editar.DisplayIndex = dgvProductos.Columns.Count - 1;
            Eliminar.DisplayIndex = dgvProductos.Columns.Count - 1;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        private void txtFiltroCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////

        private void txtFiltroNombre_TextChanged_1(object sender, EventArgs e)
        {
            FiltroPorNombre(txtFiltroNombre.Text);
        }

        private void FiltroPorNombre(string nombre)
        {
            try
            {
                if (string.IsNullOrEmpty(nombre))
                {
                    CargarProductos();
                }
                else
                {
                    _productoLOG = new ProductoLOG();
                    List<Producto> FiltroNombre = _productoLOG.ObtenerProductos().Where(p => p.Nombre.Contains(nombre)).ToList();
                    dgvProductos.DataSource = FiltroNombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de filtrado: {ex.Message}", "Tienda | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////
        private void txtFiltroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtFiltroNombre.Text == "Hola")
            {
                MessageBox.Show("Desbloqueaste un enigma :)", "Enigmatico | elEnemigos",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
