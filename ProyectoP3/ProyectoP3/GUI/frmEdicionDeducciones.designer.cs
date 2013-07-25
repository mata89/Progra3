namespace GUI
{
    partial class frmEdicionDeducciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDeducciones = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionDeduccion = new System.Windows.Forms.TextBox();
            this.txtIdDeduccion = new System.Windows.Forms.TextBox();
            this.btnAceptarDeduccion = new System.Windows.Forms.Button();
            this.btnCancelarDeduccion = new System.Windows.Forms.Button();
            this.nudPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.grpDeducciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // grpDeducciones
            // 
            this.grpDeducciones.Controls.Add(this.nudPorcentaje);
            this.grpDeducciones.Controls.Add(this.label4);
            this.grpDeducciones.Controls.Add(this.CBActivo);
            this.grpDeducciones.Controls.Add(this.label3);
            this.grpDeducciones.Controls.Add(this.txtDescripcionDeduccion);
            this.grpDeducciones.Controls.Add(this.txtIdDeduccion);
            this.grpDeducciones.Controls.Add(this.label2);
            this.grpDeducciones.Controls.Add(this.label1);
            this.grpDeducciones.Location = new System.Drawing.Point(12, 12);
            this.grpDeducciones.Name = "grpDeducciones";
            this.grpDeducciones.Size = new System.Drawing.Size(253, 140);
            this.grpDeducciones.TabIndex = 3;
            this.grpDeducciones.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Activo:";
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.Location = new System.Drawing.Point(82, 105);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(15, 14);
            this.CBActivo.TabIndex = 7;
            this.CBActivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Porcentaje:";
            // 
            // txtDescripcionDeduccion
            // 
            this.txtDescripcionDeduccion.Location = new System.Drawing.Point(82, 42);
            this.txtDescripcionDeduccion.Name = "txtDescripcionDeduccion";
            this.txtDescripcionDeduccion.Size = new System.Drawing.Size(153, 20);
            this.txtDescripcionDeduccion.TabIndex = 3;
            // 
            // txtIdDeduccion
            // 
            this.txtIdDeduccion.Location = new System.Drawing.Point(82, 13);
            this.txtIdDeduccion.Name = "txtIdDeduccion";
            this.txtIdDeduccion.Size = new System.Drawing.Size(153, 20);
            this.txtIdDeduccion.TabIndex = 2;
            // 
            // btnAceptarDeduccion
            // 
            this.btnAceptarDeduccion.Location = new System.Drawing.Point(55, 158);
            this.btnAceptarDeduccion.Name = "btnAceptarDeduccion";
            this.btnAceptarDeduccion.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarDeduccion.TabIndex = 4;
            this.btnAceptarDeduccion.Text = "Aceptar";
            this.btnAceptarDeduccion.UseVisualStyleBackColor = true;
            this.btnAceptarDeduccion.Click += new System.EventHandler(this.btnAceptarDeduccion_Click);
            // 
            // btnCancelarDeduccion
            // 
            this.btnCancelarDeduccion.Location = new System.Drawing.Point(168, 158);
            this.btnCancelarDeduccion.Name = "btnCancelarDeduccion";
            this.btnCancelarDeduccion.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDeduccion.TabIndex = 5;
            this.btnCancelarDeduccion.Text = "Cancelar";
            this.btnCancelarDeduccion.UseVisualStyleBackColor = true;
            this.btnCancelarDeduccion.Click += new System.EventHandler(this.btnCancelarDeduccion_Click);
            // 
            // nudPorcentaje
            // 
            this.nudPorcentaje.DecimalPlaces = 2;
            this.nudPorcentaje.Location = new System.Drawing.Point(82, 72);
            this.nudPorcentaje.Name = "nudPorcentaje";
            this.nudPorcentaje.Size = new System.Drawing.Size(153, 20);
            this.nudPorcentaje.TabIndex = 9;
            // 
            // frmEdicionDeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.btnCancelarDeduccion);
            this.Controls.Add(this.btnAceptarDeduccion);
            this.Controls.Add(this.grpDeducciones);
            this.Name = "frmEdicionDeducciones";
            this.Text = "Edición Deducciones";
            this.grpDeducciones.ResumeLayout(false);
            this.grpDeducciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDeducciones;
        private System.Windows.Forms.TextBox txtDescripcionDeduccion;
        private System.Windows.Forms.TextBox txtIdDeduccion;
        private System.Windows.Forms.Button btnAceptarDeduccion;
        private System.Windows.Forms.Button btnCancelarDeduccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPorcentaje;
    }
}