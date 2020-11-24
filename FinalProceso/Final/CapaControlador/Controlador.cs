using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias Sn = new Sentencias();
        //Funcion para obtener los items con los que se van a llenar los combobox del form
        public string[] funcItems(string Tabla, string Campo1)
        {
            string[] Items = Sn.funcLlenarCmb(Tabla, Campo1);
            return Items;
        }

        public float funcValor(int cuenta)
        {
            float valor = Sn.saldoCuentaActual(cuenta);      
            return valor;
        }

        public void ParametrosIngresar(int codigo, int cuenta, string fecha, int tipoT, int moneda, double monto, string descripcion)
        {
            Sn.ingresar(codigo, cuenta, fecha, tipoT, moneda, monto, descripcion);
        }

        public int Codigo()
        {
            int  codigoA = Sn.procCodigoA();
            return codigoA;
        }

        public DataTable enviar()
        {
            try
            {
                OdbcDataAdapter dt = Sn.obtener();
                DataTable table = new DataTable();
                dt.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puede que los parametros seas erroneos, verifique los parametro enviados" + ex);
                return null;
            }

        }
        public void saldoNuevo(int codigo,float saldo)
        {
            Sn.NuevoSaldo(codigo, saldo);
        }

    }
}
