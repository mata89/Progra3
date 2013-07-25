namespace GUI
{
    partial class frmMantPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantPago));
            this.tollPago = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.grdPagos = new System.Windows.Forms.DataGridView();
            this.colIDPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTolPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnuPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCrePor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecCre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // tollPago
            // 
            this.tollPago.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnBorrar,
            this.btnRefrescar});
            this.tollPago.Location = new System.Drawing.Point(0, 0);
            this.tollPago.Name = "tollPago";
            this.tollPago.Size = new System.Drawing.Size(805, 46);
            this.tollPago.TabIndex = 2;
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
            // grdPagos
            // 
            this.grdPagos.AllowUserToAddRows = false;
            this.grdPagos.AllowUserToDeleteRows = false;
            this.grdPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPago,
            this.colFecCor,
            this.colDesPag,
            this.colTolPag,
            this.colAnuPag,
            this.colCrePor,
            this.colFecCre,
            this.colModPor,
            this.colFecMod});
            this.grdPagos.Location = new System.Drawing.Point(0, 49);
            this.grdPagos.Name = "grdPagos";
            this.grdPagos.ReadOnly = true;
            this.grdPagos.Size = new System.Drawing.Size(805, 237);
            this.grdPagos.TabIndex = 3;
            // 
            // colIDPago
            // 
            this.colIDPago.DataPropertyName = "id_pago";
            this.colIDPago.HeaderText = "ID del pago";
            this.colIDPago.Name = "colIDPago";
            this.colIDPago.ReadOnly = true;
            // 
            // colFecCor
            // 
            this.colFecCor.DataPropertyName = "fechaCorte";
            this.colFecCor.HeaderText = "Fecha de corte";
            this.colFecCor.Name = "colFecCor";
            this.colFecCor.ReadOnly = true;
            // 
            // colDesPag
            // 
            this.colDesPag.DataPropertyName = "descripcion";
            this.colDesPag.HeaderText = "Descripcion";
            this.colDesPag.Name = "colDesPag";
            this.colDesPag.ReadOnly = true;
            // 
            // colTolPag
            // 
            this.colTolPag.DataPropertyName = "TotalPagoNeto";
            this.colTolPag.HeaderText = "Total a pagar neto";
            this.colTolPag.Name = "colTolPag";
            this.colTolPag.ReadOnly = true;
            // 
            // colAnuPag
            // 
            this.colAnuPag.DataPropertyName = "anulado";
            this.colAnuPag.HeaderText = "Anulado";
            this.colAnuPag.Name = "colAnuPag";
            this.colAnuPag.ReadOnly = true;
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
            // frmMantPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 288);
            this.Controls.Add(this.grdPagos);
            this.Controls.Add(this.tollPago);
            this.Name = "frmMantPago";
            this.Text = "frmMantPago";
            this.tollPago.ResumeLayout(false);
            this.tollPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollPago;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridView grdPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTolPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnuPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCrePor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecCre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecMod;
    }
}