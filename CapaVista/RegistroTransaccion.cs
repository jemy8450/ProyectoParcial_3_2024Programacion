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
    public partial class RegistroTransaccion : Form
    {
        TransaccionLOG _transaccionLOG;

        public RegistroTransaccion()
        {
            InitializeComponent();

            CargarProductos();
        }

        private void CargarProductos()
        {
            _transaccionLOG = new TransaccionLOG();

            dgvTransacciones.DataSource = _transaccionLOG.ObtenerProductos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
