using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.ABMs.Empleados;
using TrabajoPracticoPAV1_G02.Clases;
using TrabajoPracticoPAV1_G02.Negocio;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_Empleados : Form
    {
        Ne_Empleados _NE = new Ne_Empleados();
        public Frm_ABM_Empleados()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Empleados_Load(object sender, EventArgs e)
        {
            cmbTipoDocumento.Cargar(_NE.DatosCombo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Frm_AltaEmpleados formAltaEmpleados = new Frm_AltaEmpleados();
            formAltaEmpleados.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_ModificarEmpleado formModificarEmpleados = new Frm_ModificarEmpleado();
            formModificarEmpleados.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Ne_Empleados empleados = new Ne_Empleados();
            this.dataGridViewEmpleados.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewEmpleados.DataSource = empleados.RecuperarEmpleados();
                chkBoxTodos.Checked = false;
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty || txtBoxApellido.Text != string.Empty || txtBoxNumDoc.Text != string.Empty || cmbTipoDocumento.SelectedIndex != -1)
                {
                    //string x = ComboBox01.SelectedIndex.ToString();
                    this.dataGridViewEmpleados.DataSource = empleados.RecuperarEmpleados(txtBoxNombre.Text, txtBoxApellido.Text, txtBoxNumDoc.Text, cmbTipoDocumento.SelectedIndex);
                    if (dataGridViewEmpleados.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun campo que cumpla los parámetros.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxApellido.Text = "";
                        txtBoxNombre.Text = "";
                        txtBoxNumDoc.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese parámetros en los campos a buscar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void txtBoxApellido_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Text = "";
            txtBoxNumDoc.Text = "";
            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void txtBoxNombre_Click(object sender, EventArgs e)
        {
            txtBoxApellido.Text = "";
            txtBoxNumDoc.Text = "";
            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void txtBoxNumDoc_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Text = "";
            txtBoxApellido.Text = "";
            cmbTipoDocumento.SelectedIndex = -1;
        }

        private void cmbTipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            txtBoxNombre.Text = "";
            txtBoxNumDoc.Text = "";
            txtBoxNumDoc.Text = "";
        }
    }
}
