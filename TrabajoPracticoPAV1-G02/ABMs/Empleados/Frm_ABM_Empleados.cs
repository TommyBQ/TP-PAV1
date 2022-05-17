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
        public Frm_ABM_Empleados()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Empleados_Load(object sender, EventArgs e)
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
            Ne_Empleado empleados = new Ne_Empleado();
            this.dataGridViewEmpleados.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewEmpleados.DataSource = empleados.RecuperarEmpleados();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty)
                {
                    this.dataGridViewEmpleados.DataSource = empleados.RecuperarEmpleados(txtBoxNombre.Text);
                    if (dataGridViewEmpleados.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun Tipo de Documento.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese nombre a buscar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
