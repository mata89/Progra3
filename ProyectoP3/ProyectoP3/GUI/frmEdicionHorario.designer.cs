namespace GUI
{
    partial class frmEdicionHorario
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
            this.grpHorario = new System.Windows.Forms.GroupBox();
            this.chActivo = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chDomingo = new System.Windows.Forms.CheckBox();
            this.chSabado = new System.Windows.Forms.CheckBox();
            this.chViernes = new System.Windows.Forms.CheckBox();
            this.chJueves = new System.Windows.Forms.CheckBox();
            this.chMiercoles = new System.Windows.Forms.CheckBox();
            this.chMartes = new System.Windows.Forms.CheckBox();
            this.chLunes = new System.Windows.Forms.CheckBox();
            this.txtIdHorario = new System.Windows.Forms.TextBox();
            this.btnAcepetarHorario = new System.Windows.Forms.Button();
            this.btnCancelarHorario = new System.Windows.Forms.Button();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.grpHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHorario
            // 
            this.grpHorario.Controls.Add(this.dtpSalida);
            this.grpHorario.Controls.Add(this.dtpEntrada);
            this.grpHorario.Controls.Add(this.chActivo);
            this.grpHorario.Controls.Add(this.label11);
            this.grpHorario.Controls.Add(this.label10);
            this.grpHorario.Controls.Add(this.label9);
            this.grpHorario.Controls.Add(this.label8);
            this.grpHorario.Controls.Add(this.label7);
            this.grpHorario.Controls.Add(this.label6);
            this.grpHorario.Controls.Add(this.label5);
            this.grpHorario.Controls.Add(this.label4);
            this.grpHorario.Controls.Add(this.label3);
            this.grpHorario.Controls.Add(this.label2);
            this.grpHorario.Controls.Add(this.label1);
            this.grpHorario.Controls.Add(this.chDomingo);
            this.grpHorario.Controls.Add(this.chSabado);
            this.grpHorario.Controls.Add(this.chViernes);
            this.grpHorario.Controls.Add(this.chJueves);
            this.grpHorario.Controls.Add(this.chMiercoles);
            this.grpHorario.Controls.Add(this.chMartes);
            this.grpHorario.Controls.Add(this.chLunes);
            this.grpHorario.Controls.Add(this.txtIdHorario);
            this.grpHorario.Location = new System.Drawing.Point(2, -1);
            this.grpHorario.Name = "grpHorario";
            this.grpHorario.Size = new System.Drawing.Size(280, 291);
            this.grpHorario.TabIndex = 1;
            this.grpHorario.TabStop = false;
            // 
            // chActivo
            // 
            this.chActivo.AutoSize = true;
            this.chActivo.Checked = true;
            this.chActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chActivo.Location = new System.Drawing.Point(104, 260);
            this.chActivo.Name = "chActivo";
            this.chActivo.Size = new System.Drawing.Size(15, 14);
            this.chActivo.TabIndex = 25;
            this.chActivo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Domingo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sábado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Viernes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Jueves";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Miércoles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Martes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lunes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Hora salida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hora entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código";
            // 
            // chDomingo
            // 
            this.chDomingo.AutoSize = true;
            this.chDomingo.Location = new System.Drawing.Point(104, 240);
            this.chDomingo.Name = "chDomingo";
            this.chDomingo.Size = new System.Drawing.Size(15, 14);
            this.chDomingo.TabIndex = 11;
            this.chDomingo.UseVisualStyleBackColor = true;
            // 
            // chSabado
            // 
            this.chSabado.AutoSize = true;
            this.chSabado.Location = new System.Drawing.Point(104, 217);
            this.chSabado.Name = "chSabado";
            this.chSabado.Size = new System.Drawing.Size(15, 14);
            this.chSabado.TabIndex = 10;
            this.chSabado.UseVisualStyleBackColor = true;
            // 
            // chViernes
            // 
            this.chViernes.AutoSize = true;
            this.chViernes.Checked = true;
            this.chViernes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chViernes.Location = new System.Drawing.Point(104, 194);
            this.chViernes.Name = "chViernes";
            this.chViernes.Size = new System.Drawing.Size(15, 14);
            this.chViernes.TabIndex = 9;
            this.chViernes.UseVisualStyleBackColor = true;
            // 
            // chJueves
            // 
            this.chJueves.AutoSize = true;
            this.chJueves.Checked = true;
            this.chJueves.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chJueves.Location = new System.Drawing.Point(104, 169);
            this.chJueves.Name = "chJueves";
            this.chJueves.Size = new System.Drawing.Size(15, 14);
            this.chJueves.TabIndex = 8;
            this.chJueves.UseVisualStyleBackColor = true;
            // 
            // chMiercoles
            // 
            this.chMiercoles.AutoSize = true;
            this.chMiercoles.Checked = true;
            this.chMiercoles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chMiercoles.Location = new System.Drawing.Point(104, 145);
            this.chMiercoles.Name = "chMiercoles";
            this.chMiercoles.Size = new System.Drawing.Size(15, 14);
            this.chMiercoles.TabIndex = 7;
            this.chMiercoles.UseVisualStyleBackColor = true;
            // 
            // chMartes
            // 
            this.chMartes.AutoSize = true;
            this.chMartes.Checked = true;
            this.chMartes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chMartes.Location = new System.Drawing.Point(104, 121);
            this.chMartes.Name = "chMartes";
            this.chMartes.Size = new System.Drawing.Size(15, 14);
            this.chMartes.TabIndex = 6;
            this.chMartes.UseVisualStyleBackColor = true;
            // 
            // chLunes
            // 
            this.chLunes.AutoSize = true;
            this.chLunes.Checked = true;
            this.chLunes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chLunes.Location = new System.Drawing.Point(104, 97);
            this.chLunes.Name = "chLunes";
            this.chLunes.Size = new System.Drawing.Size(15, 14);
            this.chLunes.TabIndex = 5;
            this.chLunes.UseVisualStyleBackColor = true;
            // 
            // txtIdHorario
            // 
            this.txtIdHorario.Location = new System.Drawing.Point(104, 13);
            this.txtIdHorario.Name = "txtIdHorario";
            this.txtIdHorario.Size = new System.Drawing.Size(166, 20);
            this.txtIdHorario.TabIndex = 0;
            // 
            // btnAcepetarHorario
            // 
            this.btnAcepetarHorario.Location = new System.Drawing.Point(26, 308);
            this.btnAcepetarHorario.Name = "btnAcepetarHorario";
            this.btnAcepetarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnAcepetarHorario.TabIndex = 2;
            this.btnAcepetarHorario.Text = "Aceptar";
            this.btnAcepetarHorario.UseVisualStyleBackColor = true;
            this.btnAcepetarHorario.Click += new System.EventHandler(this.btnAceptarHorario_Click);
            // 
            // btnCancelarHorario
            // 
            this.btnCancelarHorario.Location = new System.Drawing.Point(167, 308);
            this.btnCancelarHorario.Name = "btnCancelarHorario";
            this.btnCancelarHorario.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarHorario.TabIndex = 3;
            this.btnCancelarHorario.Text = "Cancelar";
            this.btnCancelarHorario.UseVisualStyleBackColor = true;
            this.btnCancelarHorario.Click += new System.EventHandler(this.btnCancelarHorario_Click);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntrada.Location = new System.Drawing.Point(104, 42);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(166, 20);
            this.dtpEntrada.TabIndex = 28;
            this.dtpEntrada.Value = new System.DateTime(2013, 7, 3, 3, 30, 0, 0);
            // 
            // dtpSalida
            // 
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSalida.Location = new System.Drawing.Point(104, 67);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(166, 20);
            this.dtpSalida.TabIndex = 29;
            // 
            // frmEdicionHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 343);
            this.Controls.Add(this.btnCancelarHorario);
            this.Controls.Add(this.btnAcepetarHorario);
            this.Controls.Add(this.grpHorario);
            this.Name = "frmEdicionHorario";
            this.Text = "Edición Horario";
            this.grpHorario.ResumeLayout(false);
            this.grpHorario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHorario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chDomingo;
        private System.Windows.Forms.CheckBox chSabado;
        private System.Windows.Forms.CheckBox chViernes;
        private System.Windows.Forms.CheckBox chJueves;
        private System.Windows.Forms.CheckBox chMiercoles;
        private System.Windows.Forms.CheckBox chMartes;
        private System.Windows.Forms.CheckBox chLunes;
        private System.Windows.Forms.TextBox txtIdHorario;
        private System.Windows.Forms.Button btnAcepetarHorario;
        private System.Windows.Forms.Button btnCancelarHorario;
        private System.Windows.Forms.CheckBox chActivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
    }
}