using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPAV1_G02.Clases;
using System.Data;

namespace TrabajoPracticoPAV1_G02.Negocio
{
    class Ne_Barrios
    {
        BD_acceso_a_datos _BD_barrios = new BD_acceso_a_datos();
        public DataTable RecuperarBarrios()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Barrio]";
            return _BD_barrios.EjecutarSQL(sql);
        }
        public DataTable RecuperarBarrios(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Barrio] WHERE nombre LIKE '%" + nombre + "%'";
            return _BD_barrios.EjecutarSQL(sql);
        }
    }
}
