using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPAV1_G02.Clases;
using System.Data;

namespace TrabajoPracticoPAV1_G02.Negocio
{
    class Ne_Localidad
    {
        BD_acceso_a_datos _BD_localidades = new BD_acceso_a_datos();
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
    }
}
