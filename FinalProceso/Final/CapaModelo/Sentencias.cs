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

        public float saldoCuentaActual(int cuenta)
        {
            float valor = 0;
            try
            {
                //Se obtine el monto actual de la cuenta
                string Banco = "SELECT * FROM CUENTA_BANCARIA WHERE pk_id_numero_cuenta_bancaria = " + cuenta;
                OdbcCommand ComandBanco = new OdbcCommand(Banco, con.conexion());
                OdbcDataReader MostarBanco = ComandBanco.ExecuteReader();
                while (MostarBanco.Read())
                {
                    valor = float.Parse(MostarBanco.GetFloat(4).ToString());
                }
            }catch(Exception ex)
            {

            }

            return valor;

            }

             public void ingresar(int codigo, int cuenta, string fecha, int  tipoT, int moneda, double monto, string descripcion)
            {
            string sql = " insert into transaccion values (" + codigo + " , " + cuenta + " , '" + fecha + "', " + tipoT + ", " + moneda + "," + monto + ",'"+descripcion+"') ;";
            try
            {
                OdbcCommand comm = new OdbcCommand(sql, con.conexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
                Console.WriteLine("Los Datos se guardaron correctamente");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo existe la tabla o los campos indicados transaccion ");

            }

        }

        public  int procCodigoA()
        {
            int numero = 0;
            int codigoA = 0;
            try
            //esta funcion hace un conteo de los datos que se encuentran en la tabla pelicula y almacena ese valor en la variable numero

            {
                string contador = "SELECT count(pk_id_transaccion) FROM TRANSACCION ";
                OdbcCommand comando = new OdbcCommand(contador, con.conexion());
                numero = Convert.ToInt32(comando.ExecuteScalar());
                //si numero = 0, no encuentra ningun registro convierte el cidigoA en 1 y envia ese codigo para guardado como ID
                if (numero == 0)
                {
                    codigoA = 1;
                }
                else
                {
                    //de lo contrario se ira incrementando + 1 codigoA
                    codigoA = numero + 1;
                }
            }
            catch (Exception ex)
            {
              
            }
            return codigoA;
        }

        public OdbcDataAdapter obtener()
        {
            try
            {
                string sql = " SELECT T.pk_id_transaccion AS CODIGO, C.pk_id_numero_cuenta_bancaria AS CUENTA_BANCARIA , T.monto_transaccion AS MONTO,TT.nombre_tipo_transaccion AS TIPO_DE_TRANSACCION ,T.descripcion_transaccion AS DESCRIPCION, T.fecha_transaccion AS FECHA FROM transaccion T ,cuenta_bancaria C ,tipo_transaccion TT WHERE T.fk_id_numero_cuenta_bancaria = C.pk_id_numero_cuenta_bancaria AND T.fk_id_tipo_transaccion = TT.pk_id_tipo_transaccion;  ";
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Puede que los parametros seas erroneos, verifique los parametro enviados" + ex);
                return null;
            }
        }

        public void NuevoSaldo(int codigo, float saldoNuevo)
        {
            try
            {
                //se realiza la consulta de insertar en tabla pelicula con sus respectivos campos
                string Insertar = "UPDATE cuenta_bancaria set saldo_cuenta_bancaria = " + saldoNuevo + " where pk_id_numero_cuenta_bancaria = " + codigo  + " ";
                OdbcCommand comm = new OdbcCommand(Insertar, con.conexion());
                OdbcDataReader mostrarC = comm.ExecuteReader();
            }
            catch (Exception ex)
            {
       

            }

        }

    } 
}
