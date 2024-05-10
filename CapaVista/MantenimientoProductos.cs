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
    }
}
