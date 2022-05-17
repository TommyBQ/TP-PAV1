using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.ABMs.Proveedores;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_Proveedores : Form
    {
        public Frm_ABM_Proveedores()
        {
            InitializeComponent();
        }

        private void chkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grBoxFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_ABM_Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaProveedores formAltaProveedores = new Frm_AltaProveedores();
            formAltaProveedores.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_ModificarProveedor formModificarProveedor = new Frm_ModificarProveedor();
            formModificarProveedor.Show();
        }
    }
}
