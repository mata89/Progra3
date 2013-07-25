namespace GUI
{
    partial class frmEdicionPago
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
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.dtFechaPago = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcionPago = new System.Windows.Forms.TextBox();
            this.txtIdPago = new System.Windows.Forms.TextBox();
            this.btnAceptarPago = new System.Windows.Forms.Button();
            this.btnCancelarPago = new System.Windows.Forms.Button();
            this.nudPago = new System.Windows.Forms.NumericUpDown();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.grpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPago)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.CBActivo);
            this.grpPago.Controls.Add(this.lblActivo);
            this.grpPago.Controls.Add(this.nudPago);
            this.grpPago.Controls.Add(this.dtFechaPago);
            this.grpPago.Controls.Add(this.label4);
            this.grpPago.Controls.Add(this.label3);
            this.grpPago.Controls.Add(this.label2);
            this.grpPago.Controls.Add(this.label1);
            this.grpPago.Controls.Add(this.txtDescripcionPago);
            this.grpPago.Controls.Add(this.txtIdPago);
            this.grpPago.Location = new System.Drawing.Point(12, 12);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(344, 151);
            this.grpPago.TabIndex = 0;
            this.grpPago.TabStop = false;
            // 
            // dtFechaPago
            // 
            this.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPago.Location = new System.Drawing.Point(99, 42);
            this.dtFechaPago.Name = "dtFechaPago";
            this.dtFechaPago.Size = new System.Drawing.Size(222, 20);
            this.dtFechaPago.TabIndex = 8;
            this.dtFechaPago.Value = new System.DateTime(2013, 6, 15, 16, 8, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pago Neto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha corte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // txtDescripcionPago
            // 
            this.txtDescripcionPago.Location = new System.Drawing.Point(99, 68);
            this.txtDescripcionPago.Name = "txtDescripcionPago";
            this.txtDescripcionPago.Size = new System.Drawing.Size(222, 20);
            this.txtDescripcionPago.TabIndex = 2;
            // 
            // txtIdPago
            // 
            this.txtIdPago.Location = new System.Drawing.Point(99, 16);
            this.txtIdPago.Name = "txtIdPago";
            this.txtIdPago.Size = new System.Drawing.Size(222, 20);
            this.txtIdPago.TabIndex = 0;
            // 
            // btnAceptarPago
            // 
            this.btnAceptarPago.Location = new System.Drawing.Point(63, 169);
            this.btnAceptarPago.Name = "btnAceptarPago";
            this.btnAceptarPago.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarPago.TabIndex = 1;
            this.btnAceptarPago.Text = "Aceptar";
            this.btnAceptarPago.UseVisualStyleBackColor = true;
            this.btnAceptarPago.Click += new System.EventHandler(this.btnAceptarPago_Click);
            // 
            // btnCancelarPago
            // 
            this.btnCancelarPago.Location = new System.Drawing.Point(211, 169);
            this.btnCancelarPago.Name = "btnCancelarPago";
            this.btnCancelarPago.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPago.TabIndex = 2;
            this.btnCancelarPago.Text = "Cancelar";
            this.btnCancelarPago.UseVisualStyleBackColor = true;
            this.btnCancelarPago.Click += new System.EventHandler(this.btnCancelarPago_Click);
            // 
            // nudPago
            // 
            this.nudPago.DecimalPlaces = 2;
            this.nudPago.Location = new System.Drawing.Point(99, 95);
            this.nudPago.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudPago.Name = "nudPago";
            this.nudPago.Size = new System.Drawing.Size(222, 20);
            this.nudPago.TabIndex = 9;
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.Location = new System.Drawing.Point(99, 131);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(15, 14);
            this.CBActivo.TabIndex = 23;
            this.CBActivo.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(6, 135);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(49, 13);
            this.lblActivo.TabIndex = 24;
            this.lblActivo.Text = "Anulado:";
            // 
            // frmEdicionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 203);
            this.Controls.Add(this.btnCancelarPago);
            this.Controls.Add(this.btnAceptarPago);
            this.Controls.Add(this.grpPago);
            this.Name = "frmEdicionPago";
            this.Text = "Edición Pago";
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcionPago;
        private System.Windows.Forms.TextBox txtIdPago;
        private System.Windows.Forms.Button btnAceptarPago;
        private System.Windows.Forms.Button btnCancelarPago;
        private System.Windows.Forms.DateTimePicker dtFechaPago;
        private System.Windows.Forms.NumericUpDown nudPago;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.Label lblActivo;
    }
}