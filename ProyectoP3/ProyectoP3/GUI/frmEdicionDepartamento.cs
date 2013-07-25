using Lógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmEdicionDepartamento : Form
    {
        private Boolean aceptar;
        private DepartamentoL oDepartamentoL;
        string activo = "";
        private string usuario;

        #region Properties
        public Boolean Aceptar
        {
            get { return aceptar; } 
        }
        public DepartamentoL ODepartamentoL
        {
            get { return oDepartamentoL; }
        }
        #endregion

        public frmEdicionDepartamento(string pUsuario)
        {
            InitializeComponent();
            this.usuario = pUsuario;
            this.aceptar = false;
        }

        public frmEdicionDepartamento(DepartamentoL pDepartamentoL,string pUsuario)
        {
            this.usuario = pUsuario;
            InitializeComponent();
            this.aceptar = false;
            this.txtIdDepartamento.Text = pDepartamentoL.Id_departamento;
            this.txtNombreDepartamento.Text = pDepartamentoL.Nombre_departamento;
            this.oDepartamentoL = pDepartamentoL;
            if (pDepartamentoL.Activo.Equals("SI"))
            {
                this.CBActivo.Checked = true;
            }
            else { this.CBActivo.Checked = false; }
        }

        private void btnAceptarDepartamento_Click(object sender, EventArgs e)
        {
            if ((this.txtIdDepartamento.Text == "") ||
               (this.txtNombreDepartamento.Text == ""))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }

            if (this.CBActivo.Checked)
            {
                activo = "SI";
            }
            else {
                activo = "NO";
            }
 
            this.oDepartamentoL = new DepartamentoL(this.txtIdDepartamento.Text,this.txtNombreDepartamento.Text,activo,
                                      usuario,"",usuario, "");
            this.aceptar = true;
            this.Close();
        }

        private void btnCancelarDepartamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
