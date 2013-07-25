namespace GUI
{
    partial class frmEdicionUsuario
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
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido2Usuario = new System.Windows.Forms.TextBox();
            this.txtApellido1Usuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.AceptarUsuario = new System.Windows.Forms.Button();
            this.CancelarUsuario = new System.Windows.Forms.Button();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUsuario
            // 
            this.grpUsuario.Controls.Add(this.CBActivo);
            this.grpUsuario.Controls.Add(this.label8);
            this.grpUsuario.Controls.Add(this.txtClaveUsuario);
            this.grpUsuario.Controls.Add(this.cmbTipo);
            this.grpUsuario.Controls.Add(this.label6);
            this.grpUsuario.Controls.Add(this.label5);
            this.grpUsuario.Controls.Add(this.label4);
            this.grpUsuario.Controls.Add(this.label3);
            this.grpUsuario.Controls.Add(this.label2);
            this.grpUsuario.Controls.Add(this.label1);
            this.grpUsuario.Controls.Add(this.txtApellido2Usuario);
            this.grpUsuario.Controls.Add(this.txtApellido1Usuario);
            this.grpUsuario.Controls.Add(this.txtNombreUsuario);
            this.grpUsuario.Controls.Add(this.txtIdUsuario);
            this.grpUsuario.Location = new System.Drawing.Point(12, 12);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Size = new System.Drawing.Size(298, 215);
            this.grpUsuario.TabIndex = 0;
            this.grpUsuario.TabStop = false;
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.Checked = true;
            this.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBActivo.Location = new System.Drawing.Point(99, 191);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(15, 14);
            this.CBActivo.TabIndex = 21;
            this.CBActivo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Activo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmbTipo.Location = new System.Drawing.Point(99, 48);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(191, 21);
            this.cmbTipo.TabIndex = 13;
            this.cmbTipo.Text = "Administrador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "2° Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "1° Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuario";
            // 
            // txtApellido2Usuario
            // 
            this.txtApellido2Usuario.Location = new System.Drawing.Point(99, 158);
            this.txtApellido2Usuario.Name = "txtApellido2Usuario";
            this.txtApellido2Usuario.Size = new System.Drawing.Size(191, 20);
            this.txtApellido2Usuario.TabIndex = 4;
            // 
            // txtApellido1Usuario
            // 
            this.txtApellido1Usuario.Location = new System.Drawing.Point(99, 132);
            this.txtApellido1Usuario.Name = "txtApellido1Usuario";
            this.txtApellido1Usuario.Size = new System.Drawing.Size(191, 20);
            this.txtApellido1Usuario.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(99, 105);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(191, 20);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(99, 19);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(191, 20);
            this.txtIdUsuario.TabIndex = 0;
            // 
            // AceptarUsuario
            // 
            this.AceptarUsuario.Location = new System.Drawing.Point(33, 233);
            this.AceptarUsuario.Name = "AceptarUsuario";
            this.AceptarUsuario.Size = new System.Drawing.Size(75, 23);
            this.AceptarUsuario.TabIndex = 1;
            this.AceptarUsuario.Text = "Aceptar";
            this.AceptarUsuario.UseVisualStyleBackColor = true;
            this.AceptarUsuario.Click += new System.EventHandler(this.AceptarUsuario_Click);
            // 
            // CancelarUsuario
            // 
            this.CancelarUsuario.Location = new System.Drawing.Point(206, 233);
            this.CancelarUsuario.Name = "CancelarUsuario";
            this.CancelarUsuario.Size = new System.Drawing.Size(75, 23);
            this.CancelarUsuario.TabIndex = 2;
            this.CancelarUsuario.Text = "Cancelar";
            this.CancelarUsuario.UseVisualStyleBackColor = true;
            this.CancelarUsuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(99, 76);
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Size = new System.Drawing.Size(191, 20);
            this.txtClaveUsuario.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Clave";
            // 
            // frmEdicionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 270);
            this.Controls.Add(this.CancelarUsuario);
            this.Controls.Add(this.AceptarUsuario);
            this.Controls.Add(this.grpUsuario);
            this.Name = "frmEdicionUsuario";
            this.Text = "Edición Usuario";
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido2Usuario;
        private System.Windows.Forms.TextBox txtApellido1Usuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Button AceptarUsuario;
        private System.Windows.Forms.Button CancelarUsuario;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.Label label6;
    }
}