namespace MainForm
{
    partial class PrestamosForm
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
            this.lstTipoPrestamos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.txtTNA = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.txtCuotaTotal = new System.Windows.Forms.TextBox();
            this.txtCuotaInteres = new System.Windows.Forms.TextBox();
            this.txtCuotaCapital = new System.Windows.Forms.TextBox();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.txtComisionTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTipoPrestamos
            // 
            this.lstTipoPrestamos.FormattingEnabled = true;
            this.lstTipoPrestamos.Location = new System.Drawing.Point(17, 38);
            this.lstTipoPrestamos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstTipoPrestamos.Name = "lstTipoPrestamos";
            this.lstTipoPrestamos.Size = new System.Drawing.Size(207, 329);
            this.lstTipoPrestamos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCuotaTotal);
            this.groupBox1.Controls.Add(this.txtCuotaInteres);
            this.groupBox1.Controls.Add(this.txtCuotaCapital);
            this.groupBox1.Controls.Add(this.txtPlazo);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtTNA);
            this.groupBox1.Controls.Add(this.txtLinea);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnSimular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstTipoPrestamos);
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(458, 387);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPOS PRESTAMO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComisionTotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lstPrestamos);
            this.groupBox2.Location = new System.Drawing.Point(495, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(325, 387);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRESTAMOS DADOS DE ALTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TNA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plazo";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(244, 167);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(196, 29);
            this.btnSimular.TabIndex = 5;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "ALTA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cuota Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cuota (Interés)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cuota (Capital)";
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(334, 42);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.ReadOnly = true;
            this.txtLinea.Size = new System.Drawing.Size(106, 20);
            this.txtLinea.TabIndex = 10;
            // 
            // txtTNA
            // 
            this.txtTNA.Location = new System.Drawing.Point(334, 71);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.ReadOnly = true;
            this.txtTNA.Size = new System.Drawing.Size(106, 20);
            this.txtTNA.TabIndex = 11;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(334, 100);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(106, 20);
            this.txtMonto.TabIndex = 12;
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(334, 129);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(106, 20);
            this.txtPlazo.TabIndex = 13;
            // 
            // txtCuotaTotal
            // 
            this.txtCuotaTotal.Location = new System.Drawing.Point(334, 295);
            this.txtCuotaTotal.Name = "txtCuotaTotal";
            this.txtCuotaTotal.ReadOnly = true;
            this.txtCuotaTotal.Size = new System.Drawing.Size(106, 20);
            this.txtCuotaTotal.TabIndex = 16;
            // 
            // txtCuotaInteres
            // 
            this.txtCuotaInteres.Location = new System.Drawing.Point(334, 266);
            this.txtCuotaInteres.Name = "txtCuotaInteres";
            this.txtCuotaInteres.ReadOnly = true;
            this.txtCuotaInteres.Size = new System.Drawing.Size(106, 20);
            this.txtCuotaInteres.TabIndex = 15;
            // 
            // txtCuotaCapital
            // 
            this.txtCuotaCapital.Location = new System.Drawing.Point(334, 237);
            this.txtCuotaCapital.Name = "txtCuotaCapital";
            this.txtCuotaCapital.ReadOnly = true;
            this.txtCuotaCapital.Size = new System.Drawing.Size(106, 20);
            this.txtCuotaCapital.TabIndex = 14;
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(14, 28);
            this.lstPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(293, 290);
            this.lstPrestamos.TabIndex = 17;
            // 
            // txtComisionTotal
            // 
            this.txtComisionTotal.Location = new System.Drawing.Point(140, 336);
            this.txtComisionTotal.Name = "txtComisionTotal";
            this.txtComisionTotal.ReadOnly = true;
            this.txtComisionTotal.Size = new System.Drawing.Size(167, 20);
            this.txtComisionTotal.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Comision Total";
            // 
            // PrestamosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrestamosForm";
            this.Text = "PrestamosForm";
            this.Load += new System.EventHandler(this.PrestamosForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTipoPrestamos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCuotaTotal;
        private System.Windows.Forms.TextBox txtCuotaInteres;
        private System.Windows.Forms.TextBox txtCuotaCapital;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTNA;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComisionTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstPrestamos;
    }
}