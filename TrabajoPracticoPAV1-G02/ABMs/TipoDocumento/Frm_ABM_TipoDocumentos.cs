using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.Clases;
using TrabajoPracticoPAV1_G02.Negocio;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_TipoDocumentos : Form
    {
        BD_acceso_a_datos _BD = new BD_acceso_a_datos();

        public Frm_ABM_TipoDocumentos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal formPaginaPrincipal = new Frm_PaginaPrincipal();
            formPaginaPrincipal.Show();
        }

        private void Frm_ABM_TipoDocumentos_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Ne_TipoDocumento tiposDocumentos = new Ne_TipoDocumento();
            this.dataGridViewTipoDocumento.DataSource = null;
            if (chkBoxTodos.Checked == true)
            {
                this.dataGridViewTipoDocumento.DataSource = tiposDocumentos.RecuperarTipoDocumento();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtBoxNombre.Text != string.Empty)
                {
                    this.dataGridViewTipoDocumento.DataSource = tiposDocumentos.RecuperarTipoDocumento(txtBoxNombre.Text);
                    if (dataGridViewTipoDocumento.Rows.Count == 1)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTipoDocumento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
