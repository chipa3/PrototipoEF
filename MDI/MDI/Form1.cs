using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista.Mantenimiento;
using CapaVistaSeguridad;
using CapaVistaSeguridad.Formularios;

namespace MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
        clsVistaBitacora bit = new clsVistaBitacora();

        private void cuentaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se muestran la ventana del mantenimiento de cuentas bancarias
            if (seguridad.PermisosAcceso("1305", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Cuenta Bancaria", 1305);
                frmCuentaBancaria asignacion = new frmCuentaBancaria(txtUsuario.Text, this);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion Cuenta Bancaria", 1305);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Se muestra la ventana del proceso de transaccion
            if (seguridad.PermisosAcceso("1305", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Cuenta Bancaria", 1305);
                frmCuentaBancaria asignacion = new frmCuentaBancaria(txtUsuario.Text, this);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion Cuenta Bancaria", 1305);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }
    }
}
