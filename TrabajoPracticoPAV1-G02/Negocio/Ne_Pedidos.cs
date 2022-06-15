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
    class Ne_Pedidos
    {
        TratamientosEspeciales _TE = new TratamientosEspeciales();

        public int numPedido { get; set; }
        public int numCotizacion { get; set; }
        public int anioCotizacion { get; set; }
        public int tipoDocVendedor { get; set; }
        public int numDocVendedor { get; set; }
        public string condicionPago { get; set; }
        public string cuitCliente { get; set; }

        
        BD_acceso_a_datos _BD_Pedidos = new BD_acceso_a_datos();
        TratamientosEspeciales _TE1 = new TratamientosEspeciales();

        public EstructuraCombo DatosCombo()
        {
            EstructuraCombo Ec = new EstructuraCombo();
            Ec.Display = "siglas";
            Ec.Value = "idTipoDoc";
            Ec.Sql = "SELECT " + Ec.Display + ", " + Ec.Value + " FROM [BD3K6G02_2022].[dbo].[TipoDocumento]";
            Ec.Tabla = _BD_Pedidos.EjecutarSQL(Ec.Sql);
            return Ec;
        }
        public DataTable RecuperarPedidos() 
        {
            string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Pedidos]";
            return _BD_Pedidos.EjecutarSQL(sql);
        }

        public DataTable RecuperarPedidos(string numPedido = "", string cuitCliente = "", string numDocVendedor = "", int tipoDocVendedor = -1)
        {
            System.Data.DataTable qsy = new DataTable();
            try
            {
                string sql = @"SELECT * FROM [BD3K6G02_2022].[dbo].[Pedidos]
                               WHERE numeroPedido = '" + numPedido + "' or cuitCliente = '" + cuitCliente + "' or numDniVendedor = '" + numDocVendedor + "' or tipoDniVendedor = '" + tipoDocVendedor + "';";
                qsy = _BD_Pedidos.EjecutarSQL(sql);

                               
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return qsy;
        }

        public void AltaPedidos(Control.ControlCollection controles)
        {
            string sql = _TE1.InsertarDatos(controles, "Pedidos");
            //string sql = @"INSERT INTO Pedidos(numeroPedido,numeroCotizacion,fechaPedido,tipoDniVendedor,numDniVendedor,
            //                condicionPago,cuitCliente,añoCotizacion)
            //                values"+"("+ this.numPedido+ "," + this.numCotizacion + ","+ " "+ "," + this.tipoDocVendedor + ","+ 
            //                this.numDocVendedor + ","+  this.condicionPago + ","+this.cuitCliente + ","+ this.anioCotizacion+")";
            if (sql != "")
            {
                _BD_Pedidos.CargarDatos(sql);
            }
            else
                MessageBox.Show("No se cargó correctamente el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //public bool ValidarNumeroPedido(string nombreTabla, Control.ControlCollection controles)
        //    {
        //        string columna_TD = "";
        //        string columna_ND = "";
        //        int text_TD = -1;
        //        string text_ND = "";
        //        try
        //        {
        //            foreach (var control in controles)
        //            {
        //                string nombre = control.GetType().Name;
        //                if (nombre == "TextBox01" && ((TextBox01)control)._columna == "numDoc")
        //                {
        //                    columna_ND = ((TextBox01)control)._columna;
        //                    text_ND = ((TextBox01)control).Text;
        //                }
        //                if (nombre == "ComboBox01" && ((ComboBox01)control)._columna == "tipoDoc")
        //                {
        //                    columna_TD = ((ComboBox01)control)._columna;
        //                    text_TD = ((ComboBox01)control).SelectedIndex;
        //                }
        //                if (columna_ND != "" && columna_TD != "" && text_TD != -1 && text_ND != "")
        //                {
        //                    DataTable qsy = new DataTable();
        //                    string sql = @"SELECT COUNT(*) FROM " + nombreTabla +
        //                                " WHERE " + columna_TD + " = " + text_TD + " AND " + columna_ND + " = " + text_ND;
        //                    qsy = _BD_Pedidos.EjecutarSQL(sql);
        //                    if (qsy.Rows[0][0].ToString() == "1")
        //                    {
        //                        MessageBox.Show("Ese pedido ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        return false;
        //                    }
        //                    return true;
        //                }
        //            }
        //            MessageBox.Show("Error inesperado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show("Error: " + e, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        return false;
        //    }
        public void Modificar()
        {
            string SqlModificar = "UPDATE Pedidos SET ";
            // SqlModificar += "numeroPedido = " + this.numPedido;
            SqlModificar += " numeroCotizacion = " + this.numCotizacion;
            SqlModificar += ", tipoDniVendedor = " + this.tipoDocVendedor;
            SqlModificar += ", numDniVendedor = " + this.numDocVendedor;
            SqlModificar += ", condicionPago = '" + this.condicionPago + "'";
            SqlModificar += ", cuitCliente = " + this.cuitCliente;
            SqlModificar += ", añoCotizacion = " + this.anioCotizacion;
            SqlModificar += " WHERE numeroPedido = " + numPedido;

            if (_BD_Pedidos.Modificar(SqlModificar) == BD_acceso_a_datos.TipoEstado.correcto)
                MessageBox.Show("Se modificó correctamente");
            else
                MessageBox.Show("No se modificó, hubo error");

        }    
        
        public void Borrar(string numPedido)
        {
            string SqlBorrar = "DELETE FROM [BD3K6G02_2022].[dbo].[Pedidos] WHERE numeroPedido = " + numPedido;
            if (_BD_Pedidos.Borrar(SqlBorrar) == BD_acceso_a_datos.TipoEstado.correcto)
                MessageBox.Show("Se borró exitosamente");
            else
                MessageBox.Show("No se borró, hubo error");
        }

        public DataTable RecuperarPedidoPorCuitCliente(string cuitCliente)
        {
            string sql = "SELECT * FROM [BD3K6G02_2022].[dbo].[Pedidos] WHERE cuitCliente  = '" + cuitCliente + "'";
            return _BD_Pedidos.EjecutarSQL(sql);

        }
             





        }
}
