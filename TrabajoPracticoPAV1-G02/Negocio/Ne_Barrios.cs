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
    class Ne_Barrios
    {
        BD_acceso_a_datos _BD_barrios = new BD_acceso_a_datos();

        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public DataTable RecuperarBarrios()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Barrio]";
            return _BD_barrios.EjecutarSQL(sql);
        }
        public DataTable RecuperarBarrios(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Barrio] WHERE nombre = '" + nombre + "'";
            return _BD_barrios.EjecutarSQL(sql);
        }

        public void InsertarBarrio(string NombreBarrio,string CodigoLocalidad)
        {
            //  string sql = @"Insert into dbo.Barrio (codBarrio,nombre,codLocalidad) values (9,'Parque la Gruta Oeste1',15)"

            string sql = @"Insert into [BD3K6G02_2022].[dbo].[Barrio] (nombre,codLocalidad) values ("+ "'" + NombreBarrio + "'" + "," + CodigoLocalidad.ToString() + ")";

           // return (sql);

            _BD_barrios.Insertar(sql);
        }

        public void AltaBarrios(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "Barrio");
            if (sql != "")
            {
                _BD_barrios.Insertar(sql);
                MessageBox.Show("Se cargó el Barrio.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se cargó el Barrio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public EstructuraCombo DatosCombo()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "nombre";
            Ec.Value = "codBarrio";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Barrio]";
            Ec.Tabla = _BD_barrios.EjecutarSQL(Ec.Sql);
            return Ec;
        }
        public EstructuraCombo DatosCombo1()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "codLocalidad";
            Ec.Value = "codLocalidad";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Barrio]";
            Ec.Tabla = _BD_barrios.EjecutarSQL(Ec.Sql);
            return Ec;
        }
    }
}
