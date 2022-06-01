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

namespace TrabajoPracticoPAV1_G02.Procedimientos.Cotizaciones
{
    public partial class Frm_ABMC_Cotizaciones : Form
    {
        Ne_Cotizaciones _NE = new Ne_Cotizaciones();
        public Frm_ABMC_Cotizaciones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_PaginaPrincipal frm_PaginaPrincipal = new Frm_PaginaPrincipal();
            frm_PaginaPrincipal.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridViewCotizaciones.DataSource = null;
            if (txtAño.Text != "" || txtCuitCliente.Text != "" || txtNumero.Text != "" || cmbEstado.SelectedIndex != -1)
            {
                this.dataGridViewCotizaciones.DataSource = _NE.RecuperarCotizaciones(txtNumero.Text, txtAño.Text, txtCuitCliente.Text, cmbEstado.SelectedIndex);
                if (dataGridViewCotizaciones.Rows.Count == 1)
                {
                    MessageBox.Show("No se encontró ningun campo que cumpla los parámetros.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumero.Text = "";
                    txtCuitCliente.Text = "";
                    txtAño.Text = "";
                }
            }
            
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            this.dataGridViewCotizaciones.DataSource = null;
            this.dataGridViewCotizaciones.DataSource = _NE.RecuperarCotizaciones();
        }
    }
}
