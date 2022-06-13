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

namespace TrabajoPracticoPAV1_G02.Procedimientos.Cotizaciones
{
    public partial class Frm_ModificarCotizacion : Form
    {
        public string _numero { get; set; }

        TratamientosEspeciales _TE = new TratamientosEspeciales();
        Ne_Cotizaciones _NCO = new Ne_Cotizaciones();
        Ne_Clientes _NCL = new Ne_Clientes();
        Ne_EstadosCotizaciones _NEC = new Ne_EstadosCotizaciones();
        Ne_Empleados _NE = new Ne_Empleados();
        public Frm_ModificarCotizacion()
        {
            InitializeComponent();
        }

        private void Frm_ModificarCotizacion_Load(object sender, EventArgs e)
        {
            //carga de combobox
            cmbCuitCliente.Cargar(_NCL.DatosCombo());
            cmbEstado.Cargar(_NEC.DatosCombo());
            cmbTipoDocVendedor.Cargar(_NE.DatosCombo()); //empleado
            this.RecuperarCotizacion();
            
        }

        private void RecuperarCotizacion()
        {
            DataTable Tabla = new DataTable();
            Tabla = _NCO.RecuperarCotizacionXNum(_numero);
            _TE.CargarFormulario(this.Controls, Tabla);
        }

        private void cmbCuitCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCuitCliente.SelectedValue.ToString() != "")
            {
                DataTable tabla = new DataTable();
                tabla = _NCO.RecuperarClienteXCuit(cmbCuitCliente.SelectedValue.ToString());
                _NCO.RecargarCliente(this.Controls, tabla);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(datePicker.Value);
            if (_TE.Validar(this.Controls) == true)
            {
                _NCO.numeroCotizacion = int.Parse(this.txtNumero.Text);
                _NCO.año = int.Parse(this.txtAño.Text);
                _NCO.cuitCliente = this.cmbCuitCliente.SelectedValue.ToString();
                _NCO.tipoDocEmpleado = int.Parse(this.cmbTipoDocVendedor.SelectedValue.ToString());
                _NCO.numDocEmpleado = int.Parse(this.txtNumDocVendedor.Text);
                _NCO.codEstado = int.Parse(this.cmbEstado.SelectedValue.ToString());
                _NCO.nombreCliente = this.txtNomCliente.Text;
                _NCO.apellidoCliente = this.txtApeCliente.Text;
                //_NCO.fecha = Convert.ToDateTime(this.txtFecha.Text);
                _NCO.dtpFecha = this.dtpFecha.Value;
                _NCO.observaciones = this.txtObservaciones.Text;
                _NCO.precioTotal = int.Parse(this.txtTotal.Text.ToString());
                _NCO.motivoPerdida = this.txtMotivoPerdida.Text != null ? this.txtMotivoPerdida.Text : "" ;
                _NCO.nombreCompetidor = this.txtNomCompetidor.Text != null ? this.txtNomCompetidor.Text : "";
                _NCO.Modificar();
            }
            //this.Close();

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMotivoPerdida_Click(object sender, EventArgs e)
        {
            this.cmbEstado.SelectedValue = 4;
        }

        private void txtNomCompetidor_Click(object sender, EventArgs e)
        {
            this.cmbEstado.SelectedValue = 4;
        }

        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.cmbEstado.SelectedValue.ToString() != "4")
            {
                this.txtMotivoPerdida.Text = "";
                this.txtNomCompetidor.Text = "";
            }
        }
    }
}
