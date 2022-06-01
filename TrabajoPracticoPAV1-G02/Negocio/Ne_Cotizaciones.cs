using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoPracticoPAV1_G02.Clases;

namespace TrabajoPracticoPAV1_G02.Negocio
{
    public class Ne_Cotizaciones
    {
        public int numeroCotizacion { get; set; }
        public int año { get; set; }
        public string cuitCliente { get; set; }
        public int tipoDocEmpleado { get; set; }
        public int numDocEmpleado { get; set; }
        public int codEstado { get; set; }
        public string nombreCliente { get; set; }
        public string apelldioCliente { get; set; }
        public DateTime fecha { get; set; }
        public string observaciones{ get; set; }
        public float precioTotal { get; set; }
        public string motivoPerdida { get; set; }
        public string nombreCompetido { get; set; }

        BD_acceso_a_datos _BD_cotizaciones = new BD_acceso_a_datos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public EstructuraCombo DatosCombo() // para Estados
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "descripcion";
            Ec.Value = "codEstado";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[EstadosCotizaciones]";
            Ec.Tabla = _BD_cotizaciones.EjecutarSQL(Ec.Sql);
            return Ec;
        }
        public DataTable RecuperarCotizaciones()
        {
            string sql = "SELECT * FROM [BD3K6G02_2022].[dbo].[Cotizaciones]";
            return _BD_cotizaciones.EjecutarSQL(sql);
        }
        public DataTable RecuperarCotizaciones(string numero = "" , string año = "", string cuitCliente = "", int estado = -1)
        {
            System.Data.DataTable rtdo = new DataTable();
            try
            {
                string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cotizaciones]
                               WHERE numero = '" + numero + "' or año = '" + año + "' or cuitCliente = '" + cuitCliente + "' or codEstado = '" + estado + "'";
                rtdo = _BD_cotizaciones.EjecutarSQL(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtdo;
        }
    }
}
