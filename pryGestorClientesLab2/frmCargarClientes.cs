using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace pryGestorClientesLab2
{
    public partial class frmCargarClientes : Form
    {
        public frmCargarClientes()
        {
            InitializeComponent();
        }
        clsArchivoClientes x = new clsArchivoClientes();
        private void btnCargar_Click(object sender, EventArgs e)
        {
           x.Grabar(txtCodigo.Text, txtNombreApellido.Text, txtDeuda.Text, txtLimiteCredito.Text); 
            MessageBox.Show("Cliente cargado");

            txtCodigo.Text = "";    
            txtNombreApellido.Text = "";
            txtDeuda.Text = "";
            txtLimiteCredito.Text = "";

        }

        private void Comprobar()
        {
            if (txtCodigo.Text != "" && txtNombreApellido.Text != "" && txtDeuda.Text != "" && txtLimiteCredito.Text != "")
            {
               
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtLimiteCredito_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }
    }
}
