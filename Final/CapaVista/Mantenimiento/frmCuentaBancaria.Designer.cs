namespace CapaVista.Mantenimiento
{
    partial class frmCuentaBancaria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.cmbCodigoMoneda = new System.Windows.Forms.ComboBox();
            this.cmbCodigoPropietario = new System.Windows.Forms.ComboBox();
            this.cmbCodigoBanco = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(13, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 123);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.Location = new System.Drawing.Point(350, 380);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(92, 24);
            this.rbtnInactivo.TabIndex = 78;
            this.rbtnInactivo.TabStop = true;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            this.rbtnInactivo.CheckedChanged += new System.EventHandler(this.rbtnInactivo_CheckedChanged);
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActivo.Location = new System.Drawing.Point(226, 380);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(80, 24);
            this.rbtnActivo.TabIndex = 77;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            this.rbtnActivo.CheckedChanged += new System.EventHandler(this.rbtnActivo_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(517, 373);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(65, 27);
            this.txtEstado.TabIndex = 76;
            this.txtEstado.Tag = "estado_apertura_cuenta_bancaria";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(226, 278);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(282, 28);
            this.cmbMoneda.TabIndex = 75;
            this.cmbMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbMoneda_SelectedIndexChanged);
            // 
            // cmbPropietario
            // 
            this.cmbPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropietario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPropietario.FormattingEnabled = true;
            this.cmbPropietario.Location = new System.Drawing.Point(226, 233);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(282, 28);
            this.cmbPropietario.TabIndex = 74;
            this.cmbPropietario.SelectedIndexChanged += new System.EventHandler(this.cmbPropietario_SelectedIndexChanged);
            // 
            // cmbBanco
            // 
            this.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(226, 192);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(282, 28);
            this.cmbBanco.TabIndex = 73;
            this.cmbBanco.SelectedIndexChanged += new System.EventHandler(this.cmbBanco_SelectedIndexChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(630, 149);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(812, 270);
            this.dgvDatos.TabIndex = 72;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(23, 380);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(77, 20);
            this.lblEstado.TabIndex = 71;
            this.lblEstado.Text = "ESTADO";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(23, 432);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(157, 20);
            this.lblFecha.TabIndex = 70;
            this.lblFecha.Text = "FECHA APERTURA";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(23, 328);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(65, 20);
            this.lblSaldo.TabIndex = 69;
            this.lblSaldo.Text = "SALDO";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(23, 278);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(85, 20);
            this.lblMoneda.TabIndex = 68;
            this.lblMoneda.Text = "MONEDA";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropietario.Location = new System.Drawing.Point(23, 230);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(120, 20);
            this.lblPropietario.TabIndex = 67;
            this.lblPropietario.Text = "PROPIETARIO";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(23, 189);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(70, 20);
            this.lblBanco.TabIndex = 66;
            this.lblBanco.Text = "BANCO";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(19, 146);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(81, 20);
            this.lblCodigo.TabIndex = 65;
            this.lblCodigo.Text = "CODIGO";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(255, 432);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(442, 27);
            this.dtpFecha.TabIndex = 64;
            this.dtpFecha.Tag = "fecha_apertura_cuenta_bancaria";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.Location = new System.Drawing.Point(226, 325);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(282, 27);
            this.txtSueldo.TabIndex = 63;
            this.txtSueldo.Tag = "saldo_cuenta_bancaria";
            // 
            // cmbCodigoMoneda
            // 
            this.cmbCodigoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoMoneda.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoMoneda.FormattingEnabled = true;
            this.cmbCodigoMoneda.Location = new System.Drawing.Point(517, 275);
            this.cmbCodigoMoneda.Name = "cmbCodigoMoneda";
            this.cmbCodigoMoneda.Size = new System.Drawing.Size(61, 28);
            this.cmbCodigoMoneda.TabIndex = 62;
            this.cmbCodigoMoneda.Tag = "fk_id_tipo_moneda";
            this.cmbCodigoMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoMoneda_SelectedIndexChanged);
            // 
            // cmbCodigoPropietario
            // 
            this.cmbCodigoPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoPropietario.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoPropietario.FormattingEnabled = true;
            this.cmbCodigoPropietario.Location = new System.Drawing.Point(517, 230);
            this.cmbCodigoPropietario.Name = "cmbCodigoPropietario";
            this.cmbCodigoPropietario.Size = new System.Drawing.Size(61, 28);
            this.cmbCodigoPropietario.TabIndex = 61;
            this.cmbCodigoPropietario.Tag = "fk_id_propietario";
            this.cmbCodigoPropietario.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoPropietario_SelectedIndexChanged);
            // 
            // cmbCodigoBanco
            // 
            this.cmbCodigoBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoBanco.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoBanco.FormattingEnabled = true;
            this.cmbCodigoBanco.Location = new System.Drawing.Point(517, 194);
            this.cmbCodigoBanco.Name = "cmbCodigoBanco";
            this.cmbCodigoBanco.Size = new System.Drawing.Size(61, 28);
            this.cmbCodigoBanco.TabIndex = 60;
            this.cmbCodigoBanco.Tag = "fk_id_banco";
            this.cmbCodigoBanco.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoBanco_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(222, 143);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(110, 27);
            this.txtCodigo.TabIndex = 59;
            this.txtCodigo.Tag = "pk_id_numero_cuenta_bancaria";
            // 
            // frmCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1440, 491);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.cmbPropietario);
            this.Controls.Add(this.cmbBanco);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.lblPropietario);
            this.Controls.Add(this.lblBanco);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.cmbCodigoMoneda);
            this.Controls.Add(this.cmbCodigoPropietario);
            this.Controls.Add(this.cmbCodigoBanco);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.navegador1);
            this.Name = "frmCuentaBancaria";
            this.Text = "frmCuentaBancaria";
            this.Load += new System.EventHandler(this.frmCuentaBancaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.ComboBox cmbPropietario;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.ComboBox cmbCodigoMoneda;
        private System.Windows.Forms.ComboBox cmbCodigoPropietario;
        private System.Windows.Forms.ComboBox cmbCodigoBanco;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}