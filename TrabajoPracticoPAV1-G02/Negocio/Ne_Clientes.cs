using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPracticoPAV1_G02.Clases;

namespace TrabajoPracticoPAV1_G02.Negocio
{
    class Ne_Clientes
    {
        BD_acceso_a_datos _BD_clientes = new BD_acceso_a_datos();

        public string CUIT { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public bool activo { get; set; }

        public DataTable RecuperarTodosClientes()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cliente]";
            return _BD_clientes.EjecutarSQL(sql);
        }
        public DataTable RecuperarTodosClientesActivo()
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cliente] WHERE activo = 1";
            return _BD_clientes.EjecutarSQL(sql);
        }
        public DataTable RecuperarClienteXNombre(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cliente] WHERE nombre LIKE '%" + nombre + "%'";
            return _BD_clientes.EjecutarSQL(sql);
        }
        public DataTable RecuperarClienteXApellido(string apellido)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cliente] WHERE apellido LIKE '%" + apellido + "%'";
            return _BD_clientes.EjecutarSQL(sql);
        }
        public DataTable RecuperarClienteXCUIT(string cuitCliente)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Cliente] WHERE cuitCliente LIKE '%" + cuitCliente + "%'";
            return _BD_clientes.EjecutarSQL(sql);
        }

        public void Insertar()
        {
            int activoBool = activo ? 1 : 0;
            string sqlInsertar = @"INSERT INTO Cliente (cuitCliente, nombre, apellido, activo) " + " VALUES (" + "'" + CUIT + "', " + "'" + nombre + "', " + "'" + apellido + "', " + activoBool + ")";
            _BD_clientes.Insertar(sqlInsertar);

        }

    }
}
