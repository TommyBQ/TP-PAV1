using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.ABMs;
using TrabajoPracticoPAV1_G02.Procedimientos.Factura;

namespace TrabajoPracticoPAV1_G02
{
    public partial class Frm_PaginaPrincipal : Form
    {
        public Frm_PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Proveedores formABMProveedores = new Frm_ABM_Proveedores();
            formABMProveedores.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Empleados formABMEmpleados = new Frm_ABM_Empleados();
            formABMEmpleados.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Clientes formABMClientes = new Frm_ABM_Clientes();
            formABMClientes.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Productos formABMProductos = new Frm_ABM_Productos();
            formABMProductos.Show();
        }

        private void Frm_PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnBarrio_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Barrios formABMBarrios = new Frm_ABM_Barrios();
            formABMBarrios.Show();
        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Localidades formABMLocalidades = new Frm_ABM_Localidades();
            formABMLocalidades.Show();
        }

        private void btnProvincia_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_Provincias formABMProvincia = new Frm_ABM_Provincias();
            formABMProvincia.Show();
        }

        private void btnTipoDocumento_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_ABM_TipoDocumentos formABMTipoDocumentos = new Frm_ABM_TipoDocumentos();
            formABMTipoDocumentos.Show();
        }

        private void btnCargarFactura_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_CargarFactura formFactura = new Frm_CargarFactura();
            formFactura.Show();
        }
    }
}
