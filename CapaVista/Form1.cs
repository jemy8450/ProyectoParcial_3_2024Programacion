﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MnMantenimientoProductos_Click(object sender, EventArgs e)
        {
            MantenimientoProductos objMantenimientoProductos = new MantenimientoProductos();
            objMantenimientoProductos.ShowDialog();
        }

        private void MnRegistroVentas_Click(object sender, EventArgs e)
        {
            RegistroVenta objRegitroVenta = new RegistroVenta();
            objRegitroVenta.ShowDialog();
        }
    }
}
