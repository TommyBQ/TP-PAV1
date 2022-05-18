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
using TrabajoPracticoPAV1_G02.Negocio;

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Ne_Clientes clientes = new Ne_Clientes();
            this.dataGridViewClientes.DataSource = null;
            if (chkBoxActivo.Checked)
            {
                this.dataGridViewClientes.DataSource = clientes.RecuperarTodosClientesActivo();
            }
            else if (chkBoxTodos.Checked)
            {
                this.dataGridViewClientes.DataSource = clientes.RecuperarTodosClientes();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty)
                {
                    this.dataGridViewClientes.DataSource = clientes.RecuperarClienteXNombre(txtBoxNombre.Text);
                    if (dataGridViewClientes.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun cliente.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                if (txtBoxApellido.Text != string.Empty)
                {
                    this.dataGridViewClientes.DataSource = clientes.RecuperarClienteXApellido(txtBoxApellido.Text);
                    if (dataGridViewClientes.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun cliente.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                if (txtBoxCUIT.Text != string.Empty)
                {
                    this.dataGridViewClientes.DataSource = clientes.RecuperarClienteXCUIT(txtBoxCUIT.Text);
                    if (dataGridViewClientes.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun cliente.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese nombre a buscar o marque la opcion de Todos.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
