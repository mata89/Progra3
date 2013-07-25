namespace GUI
{
    partial class frmEdicionDepartamento
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
            this.grpDepartamento = new System.Windows.Forms.GroupBox();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.txtIdDepartamento = new System.Windows.Forms.TextBox();
            this.btnAceptarDepartamento = new System.Windows.Forms.Button();
            this.btnCancelarDepartamento = new System.Windows.Forms.Button();
            this.grpDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDepartamento
            // 
            this.grpDepartamento.Controls.Add(this.CBActivo);
            this.grpDepartamento.Controls.Add(this.label8);
            this.grpDepartamento.Controls.Add(this.label2);
            this.grpDepartamento.Controls.Add(this.label1);
            this.grpDepartamento.Controls.Add(this.txtNombreDepartamento);
            this.grpDepartamento.Controls.Add(this.txtIdDepartamento);
            this.grpDepartamento.Location = new System.Drawing.Point(13, 12);
            this.grpDepartamento.Name = "grpDepartamento";
            this.grpDepartamento.Size = new System.Drawing.Size(267, 114);
            this.grpDepartamento.TabIndex = 0;
            this.grpDepartamento.TabStop = false;
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.Checked = true;
            this.CBActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBActivo.Location = new System.Drawing.Point(59, 76);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(15, 14);
            this.CBActivo.TabIndex = 19;
            this.CBActivo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Activo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Location = new System.Drawing.Point(59, 43);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(185, 20);
            this.txtNombreDepartamento.TabIndex = 1;
            // 
            // txtIdDepartamento
            // 
            this.txtIdDepartamento.Location = new System.Drawing.Point(59, 16);
            this.txtIdDepartamento.Name = "txtIdDepartamento";
            this.txtIdDepartamento.Size = new System.Drawing.Size(185, 20);
            this.txtIdDepartamento.TabIndex = 0;
            // 
            // btnAceptarDepartamento
            // 
            this.btnAceptarDepartamento.Location = new System.Drawing.Point(37, 146);
            this.btnAceptarDepartamento.Name = "btnAceptarDepartamento";
            this.btnAceptarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarDepartamento.TabIndex = 1;
            this.btnAceptarDepartamento.Text = "Aceptar";
            this.btnAceptarDepartamento.UseVisualStyleBackColor = true;
            this.btnAceptarDepartamento.Click += new System.EventHandler(this.btnAceptarDepartamento_Click);
            // 
            // btnCancelarDepartamento
            // 
            this.btnCancelarDepartamento.Location = new System.Drawing.Point(182, 146);
            this.btnCancelarDepartamento.Name = "btnCancelarDepartamento";
            this.btnCancelarDepartamento.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDepartamento.TabIndex = 2;
            this.btnCancelarDepartamento.Text = "Cancelar";
            this.btnCancelarDepartamento.UseVisualStyleBackColor = true;
            this.btnCancelarDepartamento.Click += new System.EventHandler(this.btnCancelarDepartamento_Click);
            // 
            // frmEdicionDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 181);
            this.Controls.Add(this.btnCancelarDepartamento);
            this.Controls.Add(this.btnAceptarDepartamento);
            this.Controls.Add(this.grpDepartamento);
            this.Name = "frmEdicionDepartamento";
            this.Text = "Edición de departamento";
            this.grpDepartamento.ResumeLayout(false);
            this.grpDepartamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.TextBox txtIdDepartamento;
        private System.Windows.Forms.Button btnAceptarDepartamento;
        private System.Windows.Forms.Button btnCancelarDepartamento;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.Label label8;
    }
}