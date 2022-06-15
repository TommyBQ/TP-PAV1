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
using TrabajoPracticoPAV1_G02.ABMs.Pedidos;
using System.Data;

namespace TrabajoPracticoPAV1_G02.ABMs.Pedidos
{
    
    public partial class Frm_Modificar_Pedidos : Form

    { 
        public string _cuitCliente1 { get; set; }
        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Pedidos _Np = new Ne_Pedidos();
        Ne_TipoDocumento _Nt = new Ne_TipoDocumento();
        
        
        public Frm_Modificar_Pedidos()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Pedidos_Load(object sender, EventArgs e)
        {
            cmbBoxTDVendedor.Cargar(_Np.DatosCombo());
            //cmbTDVendedor.Cargar(_Nt.DatosCombo());
            this.RecuperarPedido();
                
        }

        public void RecuperarPedido()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = _Np.RecuperarPedidoPorCuitCliente(_cuitCliente1);
            _TE.CargarFormulario(this.Controls, tabla1);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarPedido_Click(object sender, EventArgs e)
        {
            if (_TE.Validar(this.Controls) == true)
            {
                _Np.numPedido = int.Parse(this.txtBoxNumPedido.Text);
                _Np.numCotizacion = int.Parse(this.txtBoxNumCotizacion.Text);
                _Np.anioCotizacion = int.Parse(this.txtBoxAnioCotizacion.Text);
                _Np.cuitCliente = this.txtBoxCuitCliente.Text;
                _Np.numDocVendedor = int.Parse(this.txtBoxDocVendedor.Text);
                _Np.tipoDocVendedor = (int)this.cmbBoxTDVendedor.SelectedValue;
                _Np.condicionPago = this.txtBoxCondPago.Text;

                _Np.Modificar();
            }
            this.Close();
            


        }


    }
}
