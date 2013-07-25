namespace GUI
{
    partial class frmMantUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantUsuario));
            this.tollRepuestos = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.colIdUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApeUsu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApe2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrePor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coFecCre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollRepuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
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
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUserToAddRows = false;
            this.grdUsuarios.AllowUserToDeleteRows = false;
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdUsu,
            this.colTipUsu,
            this.colNomUsu,
            this.colApeUsu1,
            this.colApe2,
            this.colConUsu,
            this.colActUsu,
            this.colCrePor,
            this.coFecCre,
            this.colModPor,
            this.colFecMod});
            this.grdUsuarios.Location = new System.Drawing.Point(0, 49);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            this.grdUsuarios.Size = new System.Drawing.Size(805, 239);
            this.grdUsuarios.TabIndex = 3;
            // 
            // colIdUsu
            // 
            this.colIdUsu.DataPropertyName = "id_usuario";
            this.colIdUsu.HeaderText = "Usuario";
            this.colIdUsu.Name = "colIdUsu";
            this.colIdUsu.ReadOnly = true;
            // 
            // colTipUsu
            // 
            this.colTipUsu.DataPropertyName = "tipo_usuario";
            this.colTipUsu.HeaderText = "Tipo de Usuario";
            this.colTipUsu.Name = "colTipUsu";
            this.colTipUsu.ReadOnly = true;
            // 
            // colNomUsu
            // 
            this.colNomUsu.DataPropertyName = "nombre_usuario";
            this.colNomUsu.HeaderText = "Nombre";
            this.colNomUsu.Name = "colNomUsu";
            this.colNomUsu.ReadOnly = true;
            // 
            // colApeUsu1
            // 
            this.colApeUsu1.DataPropertyName = "apellido1_usuario";
            this.colApeUsu1.HeaderText = "1° Apellido";
            this.colApeUsu1.Name = "colApeUsu1";
            this.colApeUsu1.ReadOnly = true;
            // 
            // colApe2
            // 
            this.colApe2.DataPropertyName = "apellido2_usuario";
            this.colApe2.HeaderText = "2° Apellido";
            this.colApe2.Name = "colApe2";
            this.colApe2.ReadOnly = true;
            // 
            // colConUsu
            // 
            this.colConUsu.DataPropertyName = "contrasenia";
            this.colConUsu.HeaderText = "Contraseña";
            this.colConUsu.Name = "colConUsu";
            this.colConUsu.ReadOnly = true;
            // 
            // colActUsu
            // 
            this.colActUsu.DataPropertyName = "activo";
            this.colActUsu.HeaderText = "Activo";
            this.colActUsu.Name = "colActUsu";
            this.colActUsu.ReadOnly = true;
            // 
            // colCrePor
            // 
            this.colCrePor.DataPropertyName = "creado_por";
            this.colCrePor.HeaderText = "Creado por";
            this.colCrePor.Name = "colCrePor";
            this.colCrePor.ReadOnly = true;
            // 
            // coFecCre
            // 
            this.coFecCre.DataPropertyName = "fecha_creacion";
            this.coFecCre.HeaderText = "Fecha de creación";
            this.coFecCre.Name = "coFecCre";
            this.coFecCre.ReadOnly = true;
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
            // 
            // frmMantUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 288);
            this.Controls.Add(this.grdUsuarios);
            this.Controls.Add(this.tollRepuestos);
            this.Name = "frmMantUsuario";
            this.Text = "Mantenimiento de Usuario";
            this.tollRepuestos.ResumeLayout(false);
            this.tollRepuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollRepuestos;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApeUsu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApe2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrePor;
        private System.Windows.Forms.DataGridViewTextBoxColumn coFecCre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecMod;
    }
}