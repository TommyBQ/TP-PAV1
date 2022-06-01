using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoPAV1_G02.ABMs.Productos
{
    public partial class Frm_ModificarProductos : Form
    {
        public int _codProducto { get; set; }
        public Frm_ModificarProductos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkGenerico_CheckedChanged(object sender, EventArgs e)
        {
            verificarGenerico();
        }

        private void verificarGenerico()
        {
            if (!chkGenerico.Checked)
            {
                cmbProdComponente.Enabled = false;
            }
            else
            {
                cmbProdComponente.Enabled = true;
            }

        }

        private void Frm_ModificarProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
