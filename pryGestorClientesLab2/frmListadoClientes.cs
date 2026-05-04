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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }
        clsArchivoClientes x = new clsArchivoClientes();
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            x.Listar(dgvClientes);
            lblCantidadRTA.Text= x.CantidadClientes().ToString();
            lblTotalRTA.Text = x.TotalDeuda().ToString();
            lblPromedioRTA.Text= x.PromedioDeuda().ToString();
        }
        

        private void btnReportar_Click(object sender, EventArgs e)
        {
            x.GenerarReporte();
            MessageBox.Show("Reporte generado");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            x.OrdenarArchivo();
        }
    }
}
