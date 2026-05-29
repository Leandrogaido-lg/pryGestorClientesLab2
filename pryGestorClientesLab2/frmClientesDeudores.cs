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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }
        clsArchivoClientes x = new clsArchivoClientes();
        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
           
            x.ListarDeudores(dgvClientes);
            int cantidad = 0;
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvClientes.Rows)
            {
                
                if (fila.Cells[0].Value != null)
                {
                    cantidad++;
                    total += Convert.ToDecimal(fila.Cells[2].Value);
                }
            }

            decimal promedio = 0;
            if (cantidad > 0)
            {
                promedio = total / cantidad;
            }


            lblCantidadC.Text = (dgvClientes.Rows.Count - 1).ToString();
            lblTotal.Text = x.DeudaClientes().ToString();
            lblPromed.Text = x.PromedioDeuda().ToString();




        }
    }
}
