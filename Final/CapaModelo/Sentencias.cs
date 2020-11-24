using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo
{
   public class Sentencias
    {
        Conexion con = new Conexion();
        //Funcion para devolver los datos para llenar los combos del form
        public string[] funcLlenarCmb(string Tabla, string Campo1)
        {
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT " + Campo1 + " FROM " + Tabla + "  ;";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, con.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {

                    Campos[I] = Reader.GetValue(0).ToString();
                    I++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla + "\n -" + Campo1); }
            return Campos;
        }


    }
}
