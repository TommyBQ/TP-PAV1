using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.ABMs.Barrios;
using TrabajoPracticoPAV1_G02.Negocio;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_Barrios : Form
    {
        public Frm_ABM_Barrios()
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
            Frm_AltaBarrios formAltaBarrios = new Frm_AltaBarrios();
            formAltaBarrios.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_ModificarBarrio formModificarBarrios = new Frm_ModificarBarrio();
            formModificarBarrios.Show();
        }

        private void grBoxFiltros_Enter(object sender, EventArgs e)
        {

        }

       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Ne_Barrios barrios = new Ne_Barrios();
            this.dataGridViewBarrios.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewBarrios.DataSource = barrios.RecuperarBarrios();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty)
                {
                    this.dataGridViewBarrios.DataSource = barrios.RecuperarBarrios(txtBoxNombre.Text);
                    if (dataGridViewBarrios.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun Barrio", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese nombre a buscar o marque la opcion de Todos.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void dataGridViewBarrios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void chkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
