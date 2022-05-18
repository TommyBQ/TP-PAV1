using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoPAV1_G02.Clases
{
    class BD_acceso_a_datos
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string cadena = "Data Source = 200.69.137.167,11333; Initial Catalog = BD3K6G02_2022; User ID = BD3K6G02_2022; Password=BDG02_5467";

        public void Conectar()
        {
            conexion.ConnectionString = cadena;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }
        private void Desconectar()
        {
            conexion.Close();
        }
        public DataTable EjecutarSQL(string comando)
        {
            Conectar();
            cmd.CommandText = comando;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            Desconectar();
            return tabla;
        }

        public void CargarDatos(string sqlInsertar)
        {
            Conectar(); 
            cmd.CommandText = sqlInsertar; 
            cmd.ExecuteNonQuery(); 
            Desconectar();
        }
    }
}
