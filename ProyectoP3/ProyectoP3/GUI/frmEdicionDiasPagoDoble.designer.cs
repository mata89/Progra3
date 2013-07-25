namespace GUI
{
    partial class frmEdicionDiasPagoDoble
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
            this.grpPagoDoble = new System.Windows.Forms.GroupBox();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.txtDescripcionPagoDoble = new System.Windows.Forms.TextBox();
            this.btnAceptarPagoDoble = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpPagoDoble.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPagoDoble
            // 
            this.grpPagoDoble.Controls.Add(this.dateTimePicker1);
            this.grpPagoDoble.Controls.Add(this.CBActivo);
            this.grpPagoDoble.Controls.Add(this.lblActivo);
            this.grpPagoDoble.Controls.Add(this.lblDescripcion);
            this.grpPagoDoble.Controls.Add(this.lblDia);
            this.grpPagoDoble.Controls.Add(this.txtDescripcionPagoDoble);
            this.grpPagoDoble.Location = new System.Drawing.Point(33, 12);
            this.grpPagoDoble.Name = "grpPagoDoble";
            this.grpPagoDoble.Size = new System.Drawing.Size(295, 118);
            this.grpPagoDoble.TabIndex = 0;
            this.grpPagoDoble.TabStop = false;
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.Checked = true;
            this.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBActivo.Location = new System.Drawing.Point(88, 92);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(15, 14);
            this.CBActivo.TabIndex = 21;
            this.CBActivo.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(33, 93);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(40, 13);
            this.lblActivo.TabIndex = 22;
            this.lblActivo.Text = "Activo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(10, 57);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(17, 23);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(56, 13);
            this.lblDia.TabIndex = 3;
            this.lblDia.Text = "Día y Mes";
            // 
            // txtDescripcionPagoDoble
            // 
            this.txtDescripcionPagoDoble.Location = new System.Drawing.Point(88, 53);
            this.txtDescripcionPagoDoble.Name = "txtDescripcionPagoDoble";
            this.txtDescripcionPagoDoble.Size = new System.Drawing.Size(187, 20);
            this.txtDescripcionPagoDoble.TabIndex = 2;
            // 
            // btnAceptarPagoDoble
            // 
            this.btnAceptarPagoDoble.Location = new System.Drawing.Point(61, 149);
            this.btnAceptarPagoDoble.Name = "btnAceptarPagoDoble";
            this.btnAceptarPagoDoble.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarPagoDoble.TabIndex = 1;
            this.btnAceptarPagoDoble.Text = "Aceptar";
            this.btnAceptarPagoDoble.UseVisualStyleBackColor = true;
            this.btnAceptarPagoDoble.Click += new System.EventHandler(this.btnAceptarPagoDoble_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // frmEdicionDiasPagoDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 185);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptarPagoDoble);
            this.Controls.Add(this.grpPagoDoble);
            this.Name = "frmEdicionDiasPagoDoble";
            this.Text = "Edición de días de pago doble";
            this.grpPagoDoble.ResumeLayout(false);
            this.grpPagoDoble.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPagoDoble;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.TextBox txtDescripcionPagoDoble;
        private System.Windows.Forms.Button btnAceptarPagoDoble;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}