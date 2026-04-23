using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestorClientesLab2
{
    public partial class frmGestorClientes : Form
    {
        public frmGestorClientes()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmCargarClientes();
            formulario.Show();
        }
    }
}
