using Presentacion.Ventanas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaVentas ventanaVentas = new VentanaVentas();
            ventanaVentas.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaCompras ventanaCompras = new VentanaCompras();
            ventanaCompras.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaProductos ventanaProductos = new VentanaProductos();
            ventanaProductos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentanaClientes ventanaClientes = new VentanaClientes();
            ventanaClientes.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VentanaUsuarios ventanaUsuarios = new VentanaUsuarios();
            ventanaUsuarios.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VentanaReportes ventanaReportes = new VentanaReportes();
            ventanaReportes.ShowDialog();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
