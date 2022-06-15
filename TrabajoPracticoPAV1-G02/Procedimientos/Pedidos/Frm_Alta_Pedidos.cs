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
using TrabajoPracticoPAV1_G02.ABMs.Pedidos;

namespace TrabajoPracticoPAV1_G02.ABMs.Pedidos
{
    public partial class Frm_Alta_Pedidos : Form
    {
        Negocio.Ne_Pedidos ne = new Negocio.Ne_Pedidos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public Frm_Alta_Pedidos()
        {
            InitializeComponent();
        }


        private void Frm_Alta_Pedidos_Load(object sender, EventArgs e)
        {
            cmbBoxTipoDocVendedor.Cargar(ne.DatosCombo());

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_TE.controlar(this.Controls, "[BD3K6G02_2022].[dbo].[Pedidos]"))
            {
               ne.AltaPedidos(this.Controls); 
            }
        }
    }
}
