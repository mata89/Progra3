namespace GUI
{
    partial class frmEdicionEmpleado
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
            this.grpEmpleado = new System.Windows.Forms.GroupBox();
            this.nudSalario = new System.Windows.Forms.NumericUpDown();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.txtApellido2Empleado = new System.Windows.Forms.TextBox();
            this.txtApellido1Empleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.txtSalarioEmpleado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarEmpleado = new System.Windows.Forms.Button();
            this.btnCancelarEmpleado = new System.Windows.Forms.Button();
            this.grpEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmpleado
            // 
            this.grpEmpleado.Controls.Add(this.nudSalario);
            this.grpEmpleado.Controls.Add(this.CBActivo);
            this.grpEmpleado.Controls.Add(this.cmbDepartamento);
            this.grpEmpleado.Controls.Add(this.cmbGenero);
            this.grpEmpleado.Controls.Add(this.label9);
            this.grpEmpleado.Controls.Add(this.txtDireccionEmpleado);
            this.grpEmpleado.Controls.Add(this.txtApellido2Empleado);
            this.grpEmpleado.Controls.Add(this.txtApellido1Empleado);
            this.grpEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.grpEmpleado.Controls.Add(this.txtCodigoEmpleado);
            this.grpEmpleado.Controls.Add(this.txtSalarioEmpleado);
            this.grpEmpleado.Controls.Add(this.label7);
            this.grpEmpleado.Controls.Add(this.label6);
            this.grpEmpleado.Controls.Add(this.label5);
            this.grpEmpleado.Controls.Add(this.label4);
            this.grpEmpleado.Controls.Add(this.label3);
            this.grpEmpleado.Controls.Add(this.label2);
            this.grpEmpleado.Controls.Add(this.label1);
            this.grpEmpleado.Location = new System.Drawing.Point(12, 5);
            this.grpEmpleado.Name = "grpEmpleado";
            this.grpEmpleado.Size = new System.Drawing.Size(349, 264);
            this.grpEmpleado.TabIndex = 0;
            this.grpEmpleado.TabStop = false;
            // 
            // nudSalario
            // 
            this.nudSalario.DecimalPlaces = 2;
            this.nudSalario.Location = new System.Drawing.Point(123, 206);
            this.nudSalario.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudSalario.Name = "nudSalario";
            this.nudSalario.Size = new System.Drawing.Size(210, 20);
            this.nudSalario.TabIndex = 21;
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.Checked = true;
            this.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBActivo.Location = new System.Drawing.Point(123, 235);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(15, 14);
            this.CBActivo.TabIndex = 20;
            this.CBActivo.UseVisualStyleBackColor = true;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(123, 178);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(210, 21);
            this.cmbDepartamento.TabIndex = 19;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(123, 124);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(210, 21);
            this.cmbGenero.TabIndex = 18;
            this.cmbGenero.Text = "Femenino";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Activo";
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(123, 151);
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(210, 20);
            this.txtDireccionEmpleado.TabIndex = 13;
            // 
            // txtApellido2Empleado
            // 
            this.txtApellido2Empleado.Location = new System.Drawing.Point(123, 97);
            this.txtApellido2Empleado.Name = "txtApellido2Empleado";
            this.txtApellido2Empleado.Size = new System.Drawing.Size(210, 20);
            this.txtApellido2Empleado.TabIndex = 11;
            // 
            // txtApellido1Empleado
            // 
            this.txtApellido1Empleado.Location = new System.Drawing.Point(123, 70);
            this.txtApellido1Empleado.Name = "txtApellido1Empleado";
            this.txtApellido1Empleado.Size = new System.Drawing.Size(210, 20);
            this.txtApellido1Empleado.TabIndex = 10;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(123, 44);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(210, 20);
            this.txtNombreEmpleado.TabIndex = 9;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(123, 18);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(210, 20);
            this.txtCodigoEmpleado.TabIndex = 8;
            // 
            // txtSalarioEmpleado
            // 
            this.txtSalarioEmpleado.AutoSize = true;
            this.txtSalarioEmpleado.Location = new System.Drawing.Point(15, 212);
            this.txtSalarioEmpleado.Name = "txtSalarioEmpleado";
            this.txtSalarioEmpleado.Size = new System.Drawing.Size(81, 13);
            this.txtSalarioEmpleado.TabIndex = 7;
            this.txtSalarioEmpleado.Text = "Salario por hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "N° departamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "2° Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "1° Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Identificación";
            // 
            // btnAceptarEmpleado
            // 
            this.btnAceptarEmpleado.Location = new System.Drawing.Point(49, 275);
            this.btnAceptarEmpleado.Name = "btnAceptarEmpleado";
            this.btnAceptarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarEmpleado.TabIndex = 1;
            this.btnAceptarEmpleado.Text = "Aceptar";
            this.btnAceptarEmpleado.UseVisualStyleBackColor = true;
            this.btnAceptarEmpleado.Click += new System.EventHandler(this.btnAceptarEmpleado_Click);
            // 
            // btnCancelarEmpleado
            // 
            this.btnCancelarEmpleado.Location = new System.Drawing.Point(234, 275);
            this.btnCancelarEmpleado.Name = "btnCancelarEmpleado";
            this.btnCancelarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEmpleado.TabIndex = 2;
            this.btnCancelarEmpleado.Text = "Cancelar";
            this.btnCancelarEmpleado.UseVisualStyleBackColor = true;
            this.btnCancelarEmpleado.Click += new System.EventHandler(this.btnCancelarEmpleado_Click);
            // 
            // frmEdicionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 316);
            this.Controls.Add(this.btnCancelarEmpleado);
            this.Controls.Add(this.btnAceptarEmpleado);
            this.Controls.Add(this.grpEmpleado);
            this.Name = "frmEdicionEmpleado";
            this.Text = "Edición Empleado";
            this.grpEmpleado.ResumeLayout(false);
            this.grpEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDireccionEmpleado;
        private System.Windows.Forms.TextBox txtApellido2Empleado;
        private System.Windows.Forms.TextBox txtApellido1Empleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.Label txtSalarioEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarEmpleado;
        private System.Windows.Forms.Button btnCancelarEmpleado;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.NumericUpDown nudSalario;
    }
}