namespace GUI
{
    partial class frmMantHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantHorario));
            this.tollHorario = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.grdHorario = new System.Windows.Forms.DataGridView();
            this.colIdHor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDomHor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLunHor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarHor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMieHor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJueHor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVieHor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSabHor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHorEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHorSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActHor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrePor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecCre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollHorario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // tollHorario
            // 
            this.tollHorario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnBorrar,
            this.btnRefrescar});
            this.tollHorario.Location = new System.Drawing.Point(0, 0);
            this.tollHorario.Name = "tollHorario";
            this.tollHorario.Size = new System.Drawing.Size(805, 46);
            this.tollHorario.TabIndex = 5;
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
            // grdHorario
            // 
            this.grdHorario.AllowUserToAddRows = false;
            this.grdHorario.AllowUserToDeleteRows = false;
            this.grdHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdHor,
            this.colDomHor,
            this.colLunHor,
            this.colMarHor,
            this.colMieHor,
            this.colJueHor,
            this.colVieHor,
            this.colSabHor,
            this.colHorEnt,
            this.colHorSal,
            this.colActHor,
            this.colCrePor,
            this.colFecCre,
            this.colModPor,
            this.colFecMod});
            this.grdHorario.Location = new System.Drawing.Point(0, 49);
            this.grdHorario.Name = "grdHorario";
            this.grdHorario.ReadOnly = true;
            this.grdHorario.Size = new System.Drawing.Size(805, 238);
            this.grdHorario.TabIndex = 6;
            // 
            // colIdHor
            // 
            this.colIdHor.DataPropertyName = "id_horario";
            this.colIdHor.HeaderText = "Código del Horario";
            this.colIdHor.Name = "colIdHor";
            this.colIdHor.ReadOnly = true;
            // 
            // colDomHor
            // 
            this.colDomHor.DataPropertyName = "domingo";
            this.colDomHor.HeaderText = "Domingo";
            this.colDomHor.Name = "colDomHor";
            this.colDomHor.ReadOnly = true;
            // 
            // colLunHor
            // 
            this.colLunHor.DataPropertyName = "lunes";
            this.colLunHor.HeaderText = "Lunes";
            this.colLunHor.Name = "colLunHor";
            this.colLunHor.ReadOnly = true;
            // 
            // colMarHor
            // 
            this.colMarHor.DataPropertyName = "martes";
            this.colMarHor.HeaderText = "Martes";
            this.colMarHor.Name = "colMarHor";
            this.colMarHor.ReadOnly = true;
            // 
            // colMieHor
            // 
            this.colMieHor.DataPropertyName = "miercoles";
            this.colMieHor.HeaderText = "Miércoles";
            this.colMieHor.Name = "colMieHor";
            this.colMieHor.ReadOnly = true;
            // 
            // colJueHor
            // 
            this.colJueHor.DataPropertyName = "jueves";
            this.colJueHor.HeaderText = "Jueves";
            this.colJueHor.Name = "colJueHor";
            this.colJueHor.ReadOnly = true;
            // 
            // colVieHor
            // 
            this.colVieHor.DataPropertyName = "viernes";
            this.colVieHor.HeaderText = "Viernes";
            this.colVieHor.Name = "colVieHor";
            this.colVieHor.ReadOnly = true;
            // 
            // colSabHor
            // 
            this.colSabHor.DataPropertyName = "sabado";
            this.colSabHor.HeaderText = "Sábado";
            this.colSabHor.Name = "colSabHor";
            this.colSabHor.ReadOnly = true;
            // 
            // colHorEnt
            // 
            this.colHorEnt.DataPropertyName = "horaEntrada";
            this.colHorEnt.HeaderText = "Hora de entrada";
            this.colHorEnt.Name = "colHorEnt";
            this.colHorEnt.ReadOnly = true;
            // 
            // colHorSal
            // 
            this.colHorSal.DataPropertyName = "horaSalida";
            this.colHorSal.HeaderText = "Hora de salida";
            this.colHorSal.Name = "colHorSal";
            this.colHorSal.ReadOnly = true;
            // 
            // colActHor
            // 
            this.colActHor.DataPropertyName = "estado";
            this.colActHor.HeaderText = "Activo";
            this.colActHor.Name = "colActHor";
            this.colActHor.ReadOnly = true;
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
            this.colFecMod.HeaderText = "Fecha de modificación";
            this.colFecMod.Name = "colFecMod";
            this.colFecMod.ReadOnly = true;
            // 
            // frmMantHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 288);
            this.Controls.Add(this.grdHorario);
            this.Controls.Add(this.tollHorario);
            this.Name = "frmMantHorario";
            this.Text = "Mantenimiento Horario";
            this.tollHorario.ResumeLayout(false);
            this.tollHorario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollHorario;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridView grdHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdHor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDomHor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLunHor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarHor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMieHor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJueHor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVieHor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSabHor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHorSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActHor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrePor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecCre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecMod;
    }
}