using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Ventanas
{
    public partial class VentanaClientes : Form
    {
        public VentanaClientes()
        {
            InitializeComponent();
        }

        ClienteImpl clienteImpl = new ClienteImpl();
    
        private void VentanaClientes_Load(object sender, EventArgs e)
        {
            DatosCliente.DataSource = clienteImpl.Listar();
        }
    }
}
