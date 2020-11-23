namespace MainForm
{
    partial class CuentasForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listCuentas = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaApertura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaModificacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.activo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.txtNumeroCuenta = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModificarSaldo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.txtNuevoSaldo = new System.Windows.Forms.MaskedTextBox();
            this.txtCtaSeleccionada = new System.Windows.Forms.TextBox();
            this.saldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listCuentas);
            this.groupBox2.Location = new System.Drawing.Point(317, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 407);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de cuentas";
            // 
            // listCuentas
            // 
            this.listCuentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.numero,
            this.saldo,
            this.descripcion,
            this.fechaApertura,
            this.fechaModificacion,
            this.activo});
            this.listCuentas.FullRowSelect = true;
            this.listCuentas.HideSelection = false;
            this.listCuentas.Location = new System.Drawing.Point(17, 31);
            this.listCuentas.MultiSelect = false;
            this.listCuentas.Name = "listCuentas";
            this.listCuentas.Size = new System.Drawing.Size(426, 359);
            this.listCuentas.TabIndex = 0;
            this.listCuentas.UseCompatibleStateImageBehavior = false;
            this.listCuentas.SelectedIndexChanged += new System.EventHandler(this.listCuentas_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // numero
            // 
            this.numero.Text = "Numero";
            // 
            // descripcion
            // 
            this.descripcion.Text = "Descripcion";
            // 
            // fechaApertura
            // 
            this.fechaApertura.Text = "Apertura";
            // 
            // fechaModificacion
            // 
            this.fechaModificacion.Text = "Ultima modificación";
            // 
            // activo
            // 
            this.activo.Text = "Activo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbClientes);
            this.groupBox1.Controls.Add(this.txtNumeroCuenta);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 187);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta cuenta";
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(104, 106);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(158, 21);
            this.cmbClientes.TabIndex = 20;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(104, 31);
            this.txtNumeroCuenta.Mask = "999999999999";
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(158, 20);
            this.txtNumeroCuenta.TabIndex = 17;
            this.txtNumeroCuenta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Crear cuenta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 69);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(158, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCtaSeleccionada);
            this.groupBox3.Controls.Add(this.txtNuevoSaldo);
            this.groupBox3.Controls.Add(this.btnModificarSaldo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSaldoActual);
            this.groupBox3.Location = new System.Drawing.Point(22, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 187);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modificar saldo";
            // 
            // btnModificarSaldo
            // 
            this.btnModificarSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModificarSaldo.Enabled = false;
            this.btnModificarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarSaldo.ForeColor = System.Drawing.Color.White;
            this.btnModificarSaldo.Location = new System.Drawing.Point(27, 147);
            this.btnModificarSaldo.Name = "btnModificarSaldo";
            this.btnModificarSaldo.Size = new System.Drawing.Size(235, 23);
            this.btnModificarSaldo.TabIndex = 7;
            this.btnModificarSaldo.Text = "Modificar saldo";
            this.btnModificarSaldo.UseVisualStyleBackColor = false;
            this.btnModificarSaldo.Click += new System.EventHandler(this.btnModificarSaldo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Seleccionado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saldo actual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nuevo saldo";
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Location = new System.Drawing.Point(124, 69);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.ReadOnly = true;
            this.txtSaldoActual.Size = new System.Drawing.Size(138, 20);
            this.txtSaldoActual.TabIndex = 9;
            // 
            // txtNuevoSaldo
            // 
            this.txtNuevoSaldo.Location = new System.Drawing.Point(124, 107);
            this.txtNuevoSaldo.Mask = "9999999999999";
            this.txtNuevoSaldo.Name = "txtNuevoSaldo";
            this.txtNuevoSaldo.Size = new System.Drawing.Size(138, 20);
            this.txtNuevoSaldo.TabIndex = 21;
            this.txtNuevoSaldo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtNuevoSaldo.ValidatingType = typeof(int);
            // 
            // txtCtaSeleccionada
            // 
            this.txtCtaSeleccionada.Location = new System.Drawing.Point(124, 31);
            this.txtCtaSeleccionada.Name = "txtCtaSeleccionada";
            this.txtCtaSeleccionada.ReadOnly = true;
            this.txtCtaSeleccionada.Size = new System.Drawing.Size(138, 20);
            this.txtCtaSeleccionada.TabIndex = 22;
            // 
            // saldo
            // 
            this.saldo.Text = "Saldo";
            // 
            // CuentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CuentasForm";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.CuentasForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtNumeroCuenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ListView listCuentas;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.ColumnHeader descripcion;
        private System.Windows.Forms.ColumnHeader fechaApertura;
        private System.Windows.Forms.ColumnHeader fechaModificacion;
        private System.Windows.Forms.ColumnHeader activo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txtNuevoSaldo;
        private System.Windows.Forms.Button btnModificarSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.TextBox txtCtaSeleccionada;
        private System.Windows.Forms.ColumnHeader saldo;
    }
}