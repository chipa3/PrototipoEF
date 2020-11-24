namespace CapaVista.Proceso
{
    partial class frmTransacciones
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.lblSaldoActual = new System.Windows.Forms.Label();
            this.cmbCodigoMoneda = new System.Windows.Forms.ComboBox();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbCodigoTransaccion = new System.Windows.Forms.ComboBox();
            this.cmbTransaccion = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbCodigoCuenta = new System.Windows.Forms.ComboBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.lblTipoTransaccion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(276, 437);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(212, 56);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Enabled = false;
            this.txtSaldoActual.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoActual.Location = new System.Drawing.Point(878, 451);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.Size = new System.Drawing.Size(249, 27);
            this.txtSaldoActual.TabIndex = 59;
            // 
            // lblSaldoActual
            // 
            this.lblSaldoActual.AutoSize = true;
            this.lblSaldoActual.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoActual.Location = new System.Drawing.Point(766, 458);
            this.lblSaldoActual.Name = "lblSaldoActual";
            this.lblSaldoActual.Size = new System.Drawing.Size(106, 20);
            this.lblSaldoActual.TabIndex = 58;
            this.lblSaldoActual.Text = "Saldo Actual";
            // 
            // cmbCodigoMoneda
            // 
            this.cmbCodigoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoMoneda.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoMoneda.FormattingEnabled = true;
            this.cmbCodigoMoneda.Location = new System.Drawing.Point(505, 215);
            this.cmbCodigoMoneda.Name = "cmbCodigoMoneda";
            this.cmbCodigoMoneda.Size = new System.Drawing.Size(87, 28);
            this.cmbCodigoMoneda.TabIndex = 57;
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(276, 215);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(210, 28);
            this.cmbMoneda.TabIndex = 56;
            this.cmbMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbMoneda_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(12, 437);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(212, 56);
            this.btnGuardar.TabIndex = 55;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(878, 109);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(425, 143);
            this.txtDescripcion.TabIndex = 54;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(878, 68);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(244, 27);
            this.txtMonto.TabIndex = 53;
            // 
            // cmbCodigoTransaccion
            // 
            this.cmbCodigoTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoTransaccion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoTransaccion.FormattingEnabled = true;
            this.cmbCodigoTransaccion.Location = new System.Drawing.Point(505, 167);
            this.cmbCodigoTransaccion.Name = "cmbCodigoTransaccion";
            this.cmbCodigoTransaccion.Size = new System.Drawing.Size(87, 28);
            this.cmbCodigoTransaccion.TabIndex = 52;
            // 
            // cmbTransaccion
            // 
            this.cmbTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransaccion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransaccion.FormattingEnabled = true;
            this.cmbTransaccion.Location = new System.Drawing.Point(276, 164);
            this.cmbTransaccion.Name = "cmbTransaccion";
            this.cmbTransaccion.Size = new System.Drawing.Size(210, 28);
            this.cmbTransaccion.TabIndex = 51;
            this.cmbTransaccion.SelectedIndexChanged += new System.EventHandler(this.cmbTransaccion_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(276, 116);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(435, 27);
            this.dtpFecha.TabIndex = 50;
            // 
            // cmbCodigoCuenta
            // 
            this.cmbCodigoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigoCuenta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCodigoCuenta.FormattingEnabled = true;
            this.cmbCodigoCuenta.Location = new System.Drawing.Point(276, 68);
            this.cmbCodigoCuenta.Name = "cmbCodigoCuenta";
            this.cmbCodigoCuenta.Size = new System.Drawing.Size(282, 28);
            this.cmbCodigoCuenta.TabIndex = 49;
            this.cmbCodigoCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoCuenta_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(717, 117);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(123, 20);
            this.lblDescripcion.TabIndex = 48;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(717, 71);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(74, 20);
            this.lblMonto.TabIndex = 47;
            this.lblMonto.Text = "MONTO";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(9, 205);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(128, 20);
            this.lblMoneda.TabIndex = 46;
            this.lblMoneda.Text = "TIPO MONEDA";
            // 
            // lblTipoTransaccion
            // 
            this.lblTipoTransaccion.AutoSize = true;
            this.lblTipoTransaccion.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTransaccion.Location = new System.Drawing.Point(9, 163);
            this.lblTipoTransaccion.Name = "lblTipoTransaccion";
            this.lblTipoTransaccion.Size = new System.Drawing.Size(174, 20);
            this.lblTipoTransaccion.TabIndex = 45;
            this.lblTipoTransaccion.Text = "TIPO TRANSACCION";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(9, 117);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(192, 20);
            this.lblFecha.TabIndex = 44;
            this.lblFecha.Text = "FECHA TRANSACCION";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.Location = new System.Drawing.Point(9, 76);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(169, 20);
            this.lblCuenta.TabIndex = 43;
            this.lblCuenta.Text = "CUENTA BANCARIA";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(489, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(248, 31);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "TRANSACCIONES";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(13, 258);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(933, 160);
            this.dgvDatos.TabIndex = 41;
            // 
            // frmTransacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1330, 534);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtSaldoActual);
            this.Controls.Add(this.lblSaldoActual);
            this.Controls.Add(this.cmbCodigoMoneda);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cmbCodigoTransaccion);
            this.Controls.Add(this.cmbTransaccion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbCodigoCuenta);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.lblTipoTransaccion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvDatos);
            this.Name = "frmTransacciones";
            this.Text = "frmTransacciones";
            this.Load += new System.EventHandler(this.frmTransacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.Label lblSaldoActual;
        private System.Windows.Forms.ComboBox cmbCodigoMoneda;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cmbCodigoTransaccion;
        private System.Windows.Forms.ComboBox cmbTransaccion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbCodigoCuenta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblTipoTransaccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}