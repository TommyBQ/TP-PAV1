using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPAV1_G02.Clases;
using System.Data;
using System.Windows.Forms;

namespace TrabajoPracticoPAV1_G02.Negocio
{
    class Ne_Localidad
    {
        BD_acceso_a_datos _BD_localidades = new BD_acceso_a_datos();

        TratamientosEspeciales _TE = new TratamientosEspeciales();
        public DataTable RecuperarLocalidades()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Localidad]";
            return _BD_localidades.EjecutarSQL(sql);
        }
        public DataTable RecuperarLocalidades(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Localidad] WHERE nombre = '" + nombre + "'";
            return _BD_localidades.EjecutarSQL(sql);
        }

        public EstructuraCombo DatosCombo()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "codLocalidad";
            Ec.Value = "codLocalidad";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Localidad]";
            Ec.Tabla = _BD_localidades.EjecutarSQL(Ec.Sql);
            return Ec;
        }


        public void AltaLocalidad(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "Localidad");
            if (sql != "")
            {
                _BD_localidades.Insertar(sql);
                MessageBox.Show("Se cargó la localidad.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se cargó la localidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
