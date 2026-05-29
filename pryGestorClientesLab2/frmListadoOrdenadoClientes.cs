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
    public partial class frmListadoOrdenadoClientes : Form
    {
        clsArchivoClientes x = new clsArchivoClientes();
        public frmListadoOrdenadoClientes()
        {
            InitializeComponent();
        }

        private void frmListadoOrdenadoClientes_Load(object sender, EventArgs e)
        {
            cmbCampo.Items.Add("Código");
            cmbCampo.Items.Add("Nombre");
            cmbCampo.Items.Add("Deuda");
            cmbCampo.SelectedIndex = 0; 

            cmbModo.Items.Add("Ascendente");
            cmbModo.Items.Add("Descendente");
            cmbModo.SelectedIndex = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string campoElegido = cmbCampo.Text;
            string modoElegido = cmbModo.Text;

            
            x.ListarOrdenadoPersonalizado(dgvListar, campoElegido, modoElegido);
        }
    }
}
