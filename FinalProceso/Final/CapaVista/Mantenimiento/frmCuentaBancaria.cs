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

namespace CapaVista.Mantenimiento
{
    public partial class frmCuentaBancaria : Form
    {
        string UsuarioAplicacion;
        static Form FormularioPadre;
        Controlador Cn = new Controlador();
        public frmCuentaBancaria(string usuario, Form formularioPadre)
        {
            InitializeComponent();
            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
        }

        private void rbtnActivo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  1
            if (rbtnActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void rbtnInactivo_CheckedChanged(object sender, EventArgs e)
        {
            //si se selecciona el radioButon de inactivo, el dato que se reflejara en el campo de texto sera e estado  0
            if (rbtnInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            //si el campo estado esta vacio coloca los 2 radioButons en falso, para que se puedan volver a seleccionar
            if (txtEstado.Text == "")
            {
                rbtnActivo.Checked = false;
                rbtnInactivo.Checked = false;
            }
            if (txtEstado.Text == "1")
            {
                rbtnActivo.Checked = true;
            }
        }
     
        private void cmbBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoBanco.SelectedIndex = cmbBanco.SelectedIndex;
        }

        private void cmbCodigoBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBanco.SelectedIndex = cmbCodigoBanco.SelectedIndex;
        }

        private void cmbPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoPropietario.SelectedIndex = cmbPropietario.SelectedIndex;
        }

        private void cmbCodigoPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPropietario.SelectedIndex = cmbCodigoPropietario.SelectedIndex;
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCodigoMoneda.SelectedIndex = cmbMoneda.SelectedIndex;
        }

        private void cmbCodigoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMoneda.SelectedIndex = cmbCodigoMoneda.SelectedIndex;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //el numero de aplicacion se debe cambiar por el numero asignado en la base de datos 
            navegador1.aplicacion = 1305;
            //banco se debe cambiar por la tabla a la que se quiere hacer el mantenimiento
            navegador1.tbl = "cuenta_bancaria";
            //estado_banco se debe cambiar por el estado de la tabla a la que se desea hacer mantenimiento
            navegador1.campoEstado = "estado_apertura_cuenta_bancaria";
            navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if ((C.Tag != null) && (!C.Tag.ToString().Equals("")))
                {
                    if (C is TextBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is ComboBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is DateTimePicker)
                    {
                        lista.Add(C);
                    }
                }
            }
            navegador1.control = lista;
            navegador1.formulario = this;
            //el dataGridView1 se debe cambiar por el que se tiene en el formulario
            navegador1.DatosActualizar = dgvDatos;
            navegador1.procActualizarData();
            try
            {
                navegador1.procCargar();
            }
            catch (Exception ex)
            {

            }
            //en la variable ayuda ruta debe colocar la carpeta y el archivo.chm de su proyecto de ayuda
            navegador1.ayudaRuta = "AyudaFRM/AyudaFRM.chm";
            navegador1.ruta = "Cuenta.html";
        }

        private void frmCuentaBancaria_Load(object sender, EventArgs e)
        {
            procLlenarCmb("banco", "pk_id_banco", cmbCodigoBanco);
            procLlenarCmb("banco", "nombre_banco", cmbBanco);
            procLlenarCmb("propietario", "pk_id_propietario", cmbCodigoPropietario);
            procLlenarCmb("propietario", "nombre_propietario", cmbPropietario);
            procLlenarCmb("tipo_moneda", "pk_id_tipo_moneda", cmbCodigoMoneda);
            procLlenarCmb("tipo_moneda", "moneda_tipo_moneda", cmbMoneda);
        }

        //funcion reutilizada del proyecto
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
    }
}
