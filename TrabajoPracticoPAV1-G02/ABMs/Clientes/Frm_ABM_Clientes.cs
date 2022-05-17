using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.ABMs.Clientes;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_Clientes : Form
    {
        public Frm_ABM_Clientes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaClientes formAltaClientes = new Frm_AltaClientes();
            formAltaClientes.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_ModificarCliente formModificarClientes = new Frm_ModificarCliente();
            formModificarClientes.Show();
        }

        private void grBoxFiltros_Enter(object sender, EventArgs e)
        {

        }
    }
}
