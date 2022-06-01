using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.ABMs.Productos;
using TrabajoPracticoPAV1_G02.Negocio;
using TrabajoPracticoPAV1_G02.Clases;

namespace TrabajoPracticoPAV1_G02.ABMs
{
    public partial class Frm_ABM_Productos : Form
    {

        Ne_Productos _NP = new Ne_Productos();
        public Frm_ABM_Productos()
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
            Frm_AltaProductos formAltaProductos = new Frm_AltaProductos();
            formAltaProductos.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Frm_ModificarProductos formModificarProductos = new Frm_ModificarProductos();
            formModificarProductos.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dataGridViewProveedores.DataSource = null;
            if (chkBoxTodos.Checked)
            {
                this.dataGridViewProveedores.DataSource = _NP.RecuperarProductos();
            }
            else // busca por campo de busqueda si no esta tildado el [X]Todos
            {
                if (txtNombre.Text != string.Empty)
                {
                    this.dataGridViewProveedores.DataSource = _NP.RecuperarProductoXNombre(txtNombre.Text);
                    if (dataGridViewProveedores.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun Producto.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                if (txtBoxNumPedido.Text != string.Empty)
                {
                    this.dataGridViewProveedores.DataSource = _NP.RecuperarProductoXcodProducto(txtBoxNumPedido.Text);
                    if (dataGridViewProveedores.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun Producto.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                if (txtBoxNumPedido.Text != string.Empty || txtNombre.Text != string.Empty)
                {
                    this.dataGridViewProveedores.DataSource = _NP.RecuperarProductos(txtNombre.Text, txtBoxNumPedido.Text);
                    if (dataGridViewProveedores.Rows.Count == 1)
                    {
                        MessageBox.Show("No se encontró ningun campo que cumpla los parámetros.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Text = "";
                        txtBoxNumPedido.Text = "";
                        
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese parámetros en los campos a buscar.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
