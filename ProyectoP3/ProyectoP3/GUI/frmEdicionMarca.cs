using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lógica;
using Datos;

namespace GUI
{
    public partial class frmNuevaMarca : Form
    {
        private Boolean aceptar;
        private MarcaL oMarcaL;
        AccesoDatosOracle cnx;
        private string activo;
        private string usuario;

        public frmNuevaMarca(AccesoDatosOracle pCnx,string pUsuario)
        {
            this.usuario = pUsuario;
            InitializeComponent();
            this.cnx = pCnx;
            this.aceptar = false;
        }

        public frmNuevaMarca(MarcaL pMarcaL, AccesoDatosOracle pCnx, string pUsuario)
        {
            this.usuario = pUsuario;
            InitializeComponent();
            this.cnx = pCnx;
            this.aceptar = false;
            this.txtCodigo.Text = pMarcaL.Id_marca;
            this.txtEmpleado.Text = pMarcaL.Id_empleado;
            this.txtUnificacion.Text = pMarcaL.Id_unificacion;
            this.txtTipoMarca.Text = pMarcaL.TipoMarca;
            if (pMarcaL.Estado == "SI")
            {
                this.cbActivo.ThreeState = true;
            }        // No estoy seguro si asi se "checkea" 
            
            this.oMarcaL = pMarcaL;
        }

        public Boolean Aceptar
        {
            get { return aceptar; }
        }

        public MarcaL OMarcaL
        {
            get { return oMarcaL; }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            if ((this.txtCodigo.Text == "") ||
                (this.txtEmpleado.Text == "") ||
                (this.txtUnificacion.Text == "") ||
                (this.txtTipoMarca.Text == ""))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }
            if (this.cbActivo.Checked)  {
                activo = "SI";
            }
            else
            {
                activo = "NO";
            }
            this.oMarcaL = new MarcaL(this.txtCodigo.Text, this.txtEmpleado.Text,
                                      this.txtUnificacion.Text, this.txtTipoMarca.Text,
                                      DateTime.Now, activo,usuario, DateTime.Now, usuario, DateTime.Now);
            this.aceptar = true;
            this.Close();
        }
        private void frmEdicionMarca_Load(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}
