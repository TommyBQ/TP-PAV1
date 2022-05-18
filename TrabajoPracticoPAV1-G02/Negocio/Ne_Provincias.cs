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
    class Ne_Provincias
    {
        BD_acceso_a_datos _BD_provincias = new BD_acceso_a_datos();

        public int codProvincia { get; set; }
        public string nombre { get; set; }

        public DataTable RecuperarProvincias()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Provincia]";
            return _BD_provincias.EjecutarSQL(sql);
        }
        public DataTable RecuperarProvincias(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Provincia] WHERE nombre LIKE '%" + nombre + "%'";
            return _BD_provincias.EjecutarSQL(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = @"INSERT INTO Provincia (nombre) " + " VALUES (" + "'" + nombre + "'" + ")";
            _BD_provincias.CargarDatos(sqlInsertar);

        }
    }
}
