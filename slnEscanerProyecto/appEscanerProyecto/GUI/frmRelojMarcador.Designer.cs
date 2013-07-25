namespace GUI
{
    partial class frmRelojMarcador
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Green;
            this.lblHora.Location = new System.Drawing.Point(52, 79);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(208, 44);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = " :  :  ";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(52, 150);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(208, 20);
            this.txtIdEmpleado.TabIndex = 1;
            this.txtIdEmpleado.TextChanged += new System.EventHandler(this.txtIdEmpleado_TextChanged);
            this.txtIdEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AllowDrop = true;
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(52, 127);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(208, 20);
            this.lblCodigoEmpleado.TabIndex = 2;
            this.lblCodigoEmpleado.Text = "Código de empleado";
            this.lblCodigoEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblSaludo
            // 
            this.lblSaludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaludo.Location = new System.Drawing.Point(12, 26);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(283, 35);
            this.lblSaludo.TabIndex = 3;
            this.lblSaludo.Text = "BIENVENIDO";
            this.lblSaludo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaludo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Green;
            this.lblFecha.Location = new System.Drawing.Point(106, 182);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(102, 20);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "DD/MM/AAAA";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFecha.TextChanged += new System.EventHandler(this.timer1_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmRelojMarcador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 223);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.lblCodigoEmpleado);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.lblHora);
            this.Name = "frmRelojMarcador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reloj Marcador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

