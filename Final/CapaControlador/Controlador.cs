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

    }
}
