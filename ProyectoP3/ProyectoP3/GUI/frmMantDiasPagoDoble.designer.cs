namespace GUI
{
    partial class frmMantDiasPagoDoble
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantDiasPagoDoble));
            this.tollRepuestos = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.grdDiasDobles = new System.Windows.Forms.DataGridView();
            this.colIdDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrePo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecCre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tollRepuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDiasDobles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            // grdDiasDobles
            // 
            this.grdDiasDobles.AllowUserToAddRows = false;
            this.grdDiasDobles.AllowUserToDeleteRows = false;
            this.grdDiasDobles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDiasDobles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdDia,
            this.colIdMes,
            this.colDesDia,
            this.colAct,
            this.colCrePo,
            this.colFecCre,
            this.colModPor,
            this.colFecMod});
            this.grdDiasDobles.Location = new System.Drawing.Point(0, 49);
            this.grdDiasDobles.Name = "grdDiasDobles";
            this.grdDiasDobles.ReadOnly = true;
            this.grdDiasDobles.Size = new System.Drawing.Size(805, 236);
            this.grdDiasDobles.TabIndex = 3;
            // 
            // colIdDia
            // 
            this.colIdDia.DataPropertyName = "id_dia";
            this.colIdDia.HeaderText = "Dia";
            this.colIdDia.Name = "colIdDia";
            this.colIdDia.ReadOnly = true;
            // 
            // colIdMes
            // 
            this.colIdMes.DataPropertyName = "id_mes";
            this.colIdMes.HeaderText = "Mes";
            this.colIdMes.Name = "colIdMes";
            this.colIdMes.ReadOnly = true;
            // 
            // colDesDia
            // 
            this.colDesDia.DataPropertyName = "descripcion_dia";
            this.colDesDia.HeaderText = "Descripción";
            this.colDesDia.Name = "colDesDia";
            this.colDesDia.ReadOnly = true;
            // 
            // colAct
            // 
            this.colAct.DataPropertyName = "activo";
            this.colAct.HeaderText = "Activo";
            this.colAct.Name = "colAct";
            this.colAct.ReadOnly = true;
            // 
            // colCrePo
            // 
            this.colCrePo.DataPropertyName = "creado_por";
            this.colCrePo.HeaderText = "Creado Por";
            this.colCrePo.Name = "colCrePo";
            this.colCrePo.ReadOnly = true;
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
            this.colFecMod.HeaderText = "Fecha de modificación";
            this.colFecMod.Name = "colFecMod";
            this.colFecMod.ReadOnly = true;
            // 
            // frmMantDiasPagoDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 288);
            this.Controls.Add(this.grdDiasDobles);
            this.Controls.Add(this.tollRepuestos);
            this.Name = "frmMantDiasPagoDoble";
            this.Text = "Mantenimiento de dias de pago doble";
            this.tollRepuestos.ResumeLayout(false);
            this.tollRepuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDiasDobles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollRepuestos;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView grdDiasDobles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrePo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecCre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecMod;
    }
}