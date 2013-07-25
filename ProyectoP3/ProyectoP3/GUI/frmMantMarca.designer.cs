namespace GUI
{
    partial class frmMantMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantMarca));
            this.tollMarcas = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.coliDMar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipMar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecMar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstMar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.tollMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tollMarcas
            // 
            this.tollMarcas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnBorrar,
            this.btnRefrescar});
            this.tollMarcas.Location = new System.Drawing.Point(0, 0);
            this.tollMarcas.Name = "tollMarcas";
            this.tollMarcas.Size = new System.Drawing.Size(784, 46);
            this.tollMarcas.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 43);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 43);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(46, 43);
            this.btnBorrar.Text = "Anular";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(59, 43);
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coliDMar,
            this.colIdEmp,
            this.colIdUni,
            this.colTipMar,
            this.colFecMar,
            this.colEstMar,
            this.creado,
            this.fechaCre,
            this.modificado,
            this.fechaMod});
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(784, 363);
            this.dataGridView1.TabIndex = 6;
            // 
            // coliDMar
            // 
            this.coliDMar.DataPropertyName = "id_marca";
            this.coliDMar.HeaderText = "N° Marca";
            this.coliDMar.Name = "coliDMar";
            this.coliDMar.ReadOnly = true;
            // 
            // colIdEmp
            // 
            this.colIdEmp.DataPropertyName = "id_empleadomarca";
            this.colIdEmp.HeaderText = "ID Empleado";
            this.colIdEmp.Name = "colIdEmp";
            this.colIdEmp.ReadOnly = true;
            // 
            // colIdUni
            // 
            this.colIdUni.DataPropertyName = "id_unificacionmarca";
            this.colIdUni.HeaderText = "N° Unificacion";
            this.colIdUni.Name = "colIdUni";
            this.colIdUni.ReadOnly = true;
            // 
            // colTipMar
            // 
            this.colTipMar.DataPropertyName = "tipo_marca";
            this.colTipMar.HeaderText = "Tipo de marca";
            this.colTipMar.Name = "colTipMar";
            this.colTipMar.ReadOnly = true;
            // 
            // colFecMar
            // 
            this.colFecMar.DataPropertyName = "fechaHora_marca";
            this.colFecMar.HeaderText = "Fecha/Hora de la marca";
            this.colFecMar.Name = "colFecMar";
            this.colFecMar.ReadOnly = true;
            // 
            // colEstMar
            // 
            this.colEstMar.DataPropertyName = "estado";
            this.colEstMar.HeaderText = "Estado";
            this.colEstMar.Name = "colEstMar";
            this.colEstMar.ReadOnly = true;
            // 
            // creado
            // 
            this.creado.DataPropertyName = "creado_por";
            this.creado.HeaderText = "Creado por";
            this.creado.Name = "creado";
            this.creado.ReadOnly = true;
            // 
            // fechaCre
            // 
            this.fechaCre.DataPropertyName = "fecha_creacion";
            this.fechaCre.HeaderText = "Fecha de creacion";
            this.fechaCre.Name = "fechaCre";
            this.fechaCre.ReadOnly = true;
            // 
            // modificado
            // 
            this.modificado.DataPropertyName = "modificado_por";
            this.modificado.HeaderText = "Modificado por";
            this.modificado.Name = "modificado";
            this.modificado.ReadOnly = true;
            // 
            // fechaMod
            // 
            this.fechaMod.DataPropertyName = "fecha_modificacion";
            this.fechaMod.HeaderText = "Fecha de modificacion";
            this.fechaMod.Name = "fechaMod";
            this.fechaMod.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbCodigo);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDepartamentos);
            this.groupBox1.Controls.Add(this.cmbEmpleados);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.dateFin);
            this.groupBox1.Controls.Add(this.dateInicio);
            this.groupBox1.Location = new System.Drawing.Point(12, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Código:";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(357, 76);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(220, 21);
            this.cmbCodigo.TabIndex = 14;
            this.cmbCodigo.Text = "Todos";
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbCodigo_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(648, 74);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inicio";
            // 
            // cmbDepartamentos
            // 
            this.cmbDepartamentos.FormattingEnabled = true;
            this.cmbDepartamentos.Location = new System.Drawing.Point(357, 19);
            this.cmbDepartamentos.Name = "cmbDepartamentos";
            this.cmbDepartamentos.Size = new System.Drawing.Size(220, 21);
            this.cmbDepartamentos.TabIndex = 6;
            this.cmbDepartamentos.Text = "Todos";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(357, 103);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(220, 21);
            this.cmbEmpleados.TabIndex = 5;
            this.cmbEmpleados.Text = "Todos";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Generada",
            "En trámite",
            "Aprobada"});
            this.cmbEstado.Location = new System.Drawing.Point(357, 48);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(220, 21);
            this.cmbEstado.TabIndex = 4;
            this.cmbEstado.Text = "Generada";
            // 
            // dateFin
            // 
            this.dateFin.Checked = false;
            this.dateFin.Location = new System.Drawing.Point(50, 79);
            this.dateFin.Name = "dateFin";
            this.dateFin.ShowCheckBox = true;
            this.dateFin.Size = new System.Drawing.Size(200, 20);
            this.dateFin.TabIndex = 3;
            // 
            // dateInicio
            // 
            this.dateInicio.Checked = false;
            this.dateInicio.Location = new System.Drawing.Point(50, 29);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.ShowCheckBox = true;
            this.dateInicio.Size = new System.Drawing.Size(200, 20);
            this.dateInicio.TabIndex = 2;
            // 
            // frmMantMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tollMarcas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMantMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.tollMarcas.ResumeLayout(false);
            this.tollMarcas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollMarcas;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartamentos;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn coliDMar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipMar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecMar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstMar;
        private System.Windows.Forms.DataGridViewTextBoxColumn creado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCre;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCodigo;

    }
}