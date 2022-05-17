using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.ABMs.Localidades;
using TrabajoPracticoPAV1_G02.Negocio;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_Localidades : Form
    {
        public Frm_ABM_Localidades()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void chkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblLocalidad_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Ne_Localidad localidades = new Ne_Localidad();
            this.dataGridViewLocalidades.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewLocalidades.DataSource = localidades.RecuperarLocalidades();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty)
                {
                    this.dataGridViewLocalidades.DataSource = localidades.RecuperarLocalidades(txtBoxNombre.Text);
                    if (dataGridViewLocalidades.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ninguna Localidad", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese nombre a buscar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dataGridViewProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaLocalidades formAltaLocalidades = new Frm_AltaLocalidades();
            formAltaLocalidades.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void grBoxFiltros_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_ModificarLocalidad formModificarLocalidades = new Frm_ModificarLocalidad();
            formModificarLocalidades.Show();
        }
    }
}
