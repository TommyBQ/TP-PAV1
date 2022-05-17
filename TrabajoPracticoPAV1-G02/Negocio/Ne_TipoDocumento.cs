using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPAV1_G02.Clases;
using System.Data;

namespace TrabajoPracticoPAV1_G02.Negocio
{
    class Ne_TipoDocumento
    {
        BD_acceso_a_datos _BD_tipoDocumento = new BD_acceso_a_datos();

        public DataTable RecuperarTipoDocumento()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[TipoDocumento]";
            return _BD_tipoDocumento.EjecutarSQL(sql);
        }
        public DataTable RecuperarTipoDocumento(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[TipoDocumento] WHERE nombre = '" + nombre + "'";
            return _BD_tipoDocumento.EjecutarSQL(sql);
        }
    }
}
