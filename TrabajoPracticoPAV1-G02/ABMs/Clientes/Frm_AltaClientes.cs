using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.Negocio;

namespace TrabajoPracticoPAV1_G02.ABMs.Clientes
{
    public partial class Frm_AltaClientes : Form
    {
        public Frm_AltaClientes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ne_Clientes neg_clientes = new Ne_Clientes();

            neg_clientes.CUIT = this.txtBoxCuit.Text;
            neg_clientes.nombre = this.txtNombre.Text;
            neg_clientes.apellido = this.txtApellido.Text;
            neg_clientes.activo = this.chkActivo.Checked;

            neg_clientes.Insertar();

            MessageBox.Show("Se guardó correctamente!");
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
