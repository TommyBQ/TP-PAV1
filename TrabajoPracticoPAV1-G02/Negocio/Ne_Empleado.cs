using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPAV1_G02.Clases;
using System.Data;

namespace TrabajoPracticoPAV1_G02.Negocio
{
    class Ne_Empleado
    {
        BD_acceso_a_datos _BD_empleados = new BD_acceso_a_datos();

        public DataTable RecuperarEmpleados()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Empleados]";
            return _BD_empleados.EjecutarSQL(sql);
        }
        public DataTable RecuperarEmpleados(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Empleados] WHERE nombre = '" + nombre + "'";
            return _BD_empleados.EjecutarSQL(sql);
        }
    }
}
