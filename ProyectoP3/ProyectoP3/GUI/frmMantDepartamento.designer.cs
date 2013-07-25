namespace GUI
{
    partial class frmMantDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantDepartamento));
            this.tollRepuestos = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.grdDepartamento = new System.Windows.Forms.DataGridView();
            this.colCodDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrePor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecCre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollRepuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamento)).BeginInit();
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
            this.tollRepuestos.TabIndex = 2;
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
            this.btnBorrar.Size = new System.Drawing.Size(43, 43);
            this.btnBorrar.Text = "Borrar";
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
            // grdDepartamento
            // 
            this.grdDepartamento.AllowUserToAddRows = false;
            this.grdDepartamento.AllowUserToDeleteRows = false;
            this.grdDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodDep,
            this.colNomDep,
            this.colActDep,
            this.colCrePor,
            this.colFecCre,
            this.colModPor,
            this.colFecMod});
            this.grdDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDepartamento.Location = new System.Drawing.Point(0, 46);
            this.grdDepartamento.Name = "grdDepartamento";
            this.grdDepartamento.ReadOnly = true;
            this.grdDepartamento.Size = new System.Drawing.Size(805, 242);
            this.grdDepartamento.TabIndex = 3;
            // 
            // colCodDep
            // 
            this.colCodDep.DataPropertyName = "id_departamento";
            this.colCodDep.HeaderText = "Código de departamento";
            this.colCodDep.Name = "colCodDep";
            this.colCodDep.ReadOnly = true;
            // 
            // colNomDep
            // 
            this.colNomDep.DataPropertyName = "nombre_departamento";
            this.colNomDep.HeaderText = "Nombre del departamento";
            this.colNomDep.Name = "colNomDep";
            this.colNomDep.ReadOnly = true;
            // 
            // colActDep
            // 
            this.colActDep.DataPropertyName = "activo";
            this.colActDep.HeaderText = "Activo";
            this.colActDep.Name = "colActDep";
            this.colActDep.ReadOnly = true;
            this.colActDep.Visible = false;
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
            this.colFecCre.Width = 180;
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
            this.colFecMod.HeaderText = "Fecha de modificación";
            this.colFecMod.Name = "colFecMod";
            this.colFecMod.ReadOnly = true;
            this.colFecMod.Width = 180;
            // 
            // frmMantDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 288);
            this.Controls.Add(this.grdDepartamento);
            this.Controls.Add(this.tollRepuestos);
            this.Name = "frmMantDepartamento";
            this.Text = "Mantenimiento de departamento";
            this.tollRepuestos.ResumeLayout(false);
            this.tollRepuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollRepuestos;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridView grdDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrePor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecCre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecMod;
    }
}