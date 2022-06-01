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
    public class Ne_Productos
    {
        public int codProducto { get; set; }
        public int nombre { get; set; }
        public int precio { get; set; }
        public int cantStock { get; set; }
        public int cuitProveedor { get; set; }
        public int descripcion { get; set; }
        public int codProductoEquivalente { get; set; }

        BD_acceso_a_datos _BD_Productos = new BD_acceso_a_datos();
        TratamientosEspeciales _TE = new TratamientosEspeciales();


        public DataTable RecuperarProductoXcodProducto(string codProducto)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Productos] WHERE codProducto LIKE '%" + codProducto + "%'";
            return _BD_Productos.EjecutarSQL(sql);
        }
        public DataTable RecuperarProductoXNombre(string nombre)
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Productos] WHERE nombre LIKE '%" + nombre + "%'";
            return _BD_Productos.EjecutarSQL(sql);
        }
        public DataTable RecuperarProductos() //Todos los productos
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Productos]";
            return _BD_Productos.EjecutarSQL(sql);
        }

        public DataTable RecuperarProductos(string nombre = "", string codProducto = "") // Los productos por parametro
        {
            System.Data.DataTable rtdo = new DataTable();
            try
            {
                string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Productos] 
                        WHERE nombre LIKE '" + nombre + "' or codProducto LIKE '" + codProducto + "';";
                rtdo = _BD_Productos.EjecutarSQL(sql);

            }

            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtdo;
        }

        public void AltaProducto(Control.ControlCollection controles)//aca recibe todos los txtbox cmbbox
        {
            string sql = _TE.InsertarDatos(controles, "Productos");
            if (sql != "")
            {
                _BD_Productos.Insertar(sql);
                MessageBox.Show("Se cargó el Producto.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se cargó el Producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public EstructuraCombo DatosCombo()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "razonSocial";
            Ec.Value = "cuitProveedor";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Proveedor]";
            Ec.Tabla = _BD_Productos.EjecutarSQL(Ec.Sql);
            return Ec;
        }

        public EstructuraCombo DatosCombo1()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "nombre";
            Ec.Value = "codProducto";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[Productos] WHERE esGenerico = 0";
            Ec.Tabla = _BD_Productos.EjecutarSQL(Ec.Sql);
            return Ec;
        }
    }

}
