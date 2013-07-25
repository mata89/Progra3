namespace GUI
{
    partial class frmMantEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantEmpleado));
            this.tollRepuestos = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.grdEmpleado = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrePor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecCre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollRepuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // tollRepuestos
            // 
            this.tollRepuestos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnBorrar,
            this.btnRefrescar});
            this.tollRepuestos.Location = new System.Drawing.Point(0, 0);
            this.tollRepuestos.Name = "tollRepuestos";
            this.tollRepuestos.Size = new System.Drawing.Size(805, 46);
            this.tollRepuestos.TabIndex = 3;
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(43, 43);
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
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
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click_1);
            // 
            // grdEmpleado
            // 
            this.grdEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.colNomEmp,
            this.apellido1Empleado,
            this.apellido2Empleado,
            this.generoEmpleado,
            this.direccionEmpleado,
            this.departamentoEmpleado,
            this.salarioEmpleado,
            this.estadoEmpleado,
            this.colCrePor,
            this.colFecCre,
            this.colModPor,
            this.colFecMod});
            this.grdEmpleado.Location = new System.Drawing.Point(0, 49);
            this.grdEmpleado.Name = "grdEmpleado";
            this.grdEmpleado.ReadOnly = true;
            this.grdEmpleado.Size = new System.Drawing.Size(805, 239);
            this.grdEmpleado.TabIndex = 4;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "id_empleado";
            this.idEmpleado.HeaderText = "N° Identificación";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            // 
            // colNomEmp
            // 
            this.colNomEmp.DataPropertyName = "Nombre_empleado";
            this.colNomEmp.HeaderText = "Nombre";
            this.colNomEmp.Name = "colNomEmp";
            this.colNomEmp.ReadOnly = true;
            // 
            // apellido1Empleado
            // 
            this.apellido1Empleado.DataPropertyName = "apellido_1";
            this.apellido1Empleado.HeaderText = "Apellido 1";
            this.apellido1Empleado.Name = "apellido1Empleado";
            this.apellido1Empleado.ReadOnly = true;
            // 
            // apellido2Empleado
            // 
            this.apellido2Empleado.DataPropertyName = "apellido_2";
            this.apellido2Empleado.HeaderText = "Apellido 2";
            this.apellido2Empleado.Name = "apellido2Empleado";
            this.apellido2Empleado.ReadOnly = true;
            // 
            // generoEmpleado
            // 
            this.generoEmpleado.DataPropertyName = "genero";
            this.generoEmpleado.HeaderText = "Genero";
            this.generoEmpleado.Name = "generoEmpleado";
            this.generoEmpleado.ReadOnly = true;
            this.generoEmpleado.Width = 50;
            // 
            // direccionEmpleado
            // 
            this.direccionEmpleado.DataPropertyName = "direccion";
            this.direccionEmpleado.HeaderText = "Dirección";
            this.direccionEmpleado.Name = "direccionEmpleado";
            this.direccionEmpleado.ReadOnly = true;
            // 
            // departamentoEmpleado
            // 
            this.departamentoEmpleado.DataPropertyName = "id_departamento";
            this.departamentoEmpleado.HeaderText = "Departamento";
            this.departamentoEmpleado.Name = "departamentoEmpleado";
            this.departamentoEmpleado.ReadOnly = true;
            // 
            // salarioEmpleado
            // 
            this.salarioEmpleado.DataPropertyName = "salario_por_hora";
            this.salarioEmpleado.HeaderText = "Salario";
            this.salarioEmpleado.Name = "salarioEmpleado";
            this.salarioEmpleado.ReadOnly = true;
            // 
            // estadoEmpleado
            // 
            this.estadoEmpleado.DataPropertyName = "activo";
            this.estadoEmpleado.HeaderText = "Activo";
            this.estadoEmpleado.Name = "estadoEmpleado";
            this.estadoEmpleado.ReadOnly = true;
            // 
            // colCrePor
            // 
            this.colCrePor.DataPropertyName = "creado_por";
            this.colCrePor.HeaderText = "Creado por";
            this.colCrePor.Name = "colCrePor";
            this.colCrePor.ReadOnly = true;
            // 
            // colFecCre
            // 
            this.colFecCre.DataPropertyName = "fecha_creacion";
            this.colFecCre.HeaderText = "Fecha de creación";
            this.colFecCre.Name = "colFecCre";
            this.colFecCre.ReadOnly = true;
            // 
            // colModPor
            // 
            this.colModPor.DataPropertyName = "modificado_por";
            this.colModPor.HeaderText = "Modificado por";
            this.colModPor.Name = "colModPor";
            this.colModPor.ReadOnly = true;
            // 
            // colFecMod
            // 
            this.colFecMod.DataPropertyName = "fecha_modificacion";
            this.colFecMod.HeaderText = "Fecha de modificacion";
            this.colFecMod.Name = "colFecMod";
            this.colFecMod.ReadOnly = true;
            // 
            // frmMantEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 288);
            this.Controls.Add(this.grdEmpleado);
            this.Controls.Add(this.tollRepuestos);
            this.Name = "frmMantEmpleado";
            this.Text = "Mantenimiento Empleado";
            this.tollRepuestos.ResumeLayout(false);
            this.tollRepuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollRepuestos;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridView grdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrePor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecCre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecMod;
    }
}