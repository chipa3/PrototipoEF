using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista.Proceso
{
    public partial class frmTransacciones : Form
    {
        Controlador Cn = new Controlador();
        public frmTransacciones()
        {
            InitializeComponent();
        }

        private void frmTransacciones_Load(object sender, EventArgs e)
        {
            llenarCombos();
            cargarDatos();
        }
        void llenarCombos()
        {
            //codigo reutilizado del proyecto
            procLlenarCmb("cuenta_bancaria", "pk_id_numero_cuenta_bancaria", cmbCodigoCuenta);
            procLlenarCmb("tipo_transaccion", "pk_id_tipo_transaccion", cmbCodigoTransaccion);
            procLlenarCmb("tipo_transaccion", "nombre_tipo_transaccion", cmbTransaccion);
            procLlenarCmb("tipo_moneda", "pk_id_tipo_moneda", cmbCodigoMoneda);
            procLlenarCmb("tipo_moneda", "moneda_tipo_moneda", cmbMoneda);
        }

        public void procLlenarCmb(string Tabla, string Campo1, ComboBox CmbAgregar)
        {
            string[] Items = Cn.funcItems(Tabla, Campo1);
            for (int I = 0; I < Items.Length; I++)
            {
                if (Items[I] != null)
                {
                    if (Items[I] != "")
                    {
                        CmbAgregar.Items.Add(Items[I]);
                    }
                }
            }
        }

        private void cmbCodigoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSaldoActual.Text = Cn.funcValor(Int32.Parse(cmbCodigoCuenta.SelectedItem.ToString())).ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            float Resultado = 0;
            if (txtDescripcion.Text == "" || txtMonto.Text == "" )
            {
                MessageBox.Show("No debe dejar campos vacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int codigo = Cn.Codigo();
                int cuenta = Int32.Parse(cmbCodigoCuenta.SelectedItem.ToString());
                int moneda = Int32.Parse(cmbCodigoMoneda.SelectedItem.ToString());
                int tipoTransaccion = Int32.Parse(cmbCodigoTransaccion.SelectedItem.ToString());
                string fecha = dtpFecha.Value.ToString("yyyy-MM-dd HH:MM"); ;
                float monto = float.Parse(txtMonto.Text);
                string descripcion = txtDescripcion.Text;
                float saldoAnterior = float.Parse(txtSaldoActual.Text);       
                if(tipoTransaccion == 1)
                {
                    Resultado = monto + saldoAnterior;
                    Cn.ParametrosIngresar(codigo, cuenta, fecha, tipoTransaccion, moneda, monto, descripcion);
                    Cn.saldoNuevo(cuenta, Resultado);
                    MessageBox.Show("Todos los datos fueron ingresados Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    llenarCombos();
                    cargarDatos();
                }
                else if(tipoTransaccion == 2)
                {
                    if(monto > saldoAnterior)
                    {
                        MessageBox.Show("El monto que desea restar es mayor al que esta registrado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Resultado = saldoAnterior - monto;
                        Cn.ParametrosIngresar(codigo, cuenta, fecha, tipoTransaccion, moneda, monto, descripcion);
                        Cn.saldoNuevo(cuenta, Resultado);
                        MessageBox.Show("Todos los datos fueron ingresados Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        llenarCombos();
                        cargarDatos();
                    }
                }
             
            }
        }

        void cargarDatos()
        {
            DataTable dt = Cn.enviar();
            dgvDatos.DataSource = dt;
        }

        private void cmbTransaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoTransaccion.SelectedIndex = cmbTransaccion.SelectedIndex;
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoMoneda.SelectedIndex = cmbMoneda.SelectedIndex;
        }

        void Limpiar()
        {
            txtSaldoActual.Text = "";
            txtDescripcion.Text = "";
            txtMonto.Text = "";
            cmbCodigoCuenta.Items.Clear();
            cmbCodigoTransaccion.Items.Clear();
            cmbTransaccion.Items.Clear();
            cmbMoneda.Items.Clear();
            cmbCodigoMoneda.Items.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            llenarCombos();
        }
    }
}
