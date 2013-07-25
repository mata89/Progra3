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
    public partial class frmEdicionUsuario : Form
    {
        private Boolean aceptar;
        private UsuarioL oUsuarioL;
        private string activo = "";
        private string tipo;
        private string usuario;

        #region Properties

        public Boolean Aceptar
        {
            get { return aceptar; }
        }
        internal UsuarioL OUsuarioL
        {
            get { return oUsuarioL; }
        }
        #endregion

        public frmEdicionUsuario(string pUsuario)
        {
            InitializeComponent();
            this.usuario = pUsuario;
        }

        public frmEdicionUsuario(UsuarioL pUsuarioL, string pUsuario)
        {
            InitializeComponent();
            this.usuario = pUsuario;
            this.aceptar = false;
            this.txtNombreUsuario.Text = pUsuarioL.Nombre_usuario;
            this.txtIdUsuario.Text = pUsuarioL.Id_usuario;
            this.txtClaveUsuario.Text = pUsuarioL.Contrasenia;
            this.txtApellido1Usuario.Text = pUsuarioL.Apellido1_usuario;
            this.txtApellido2Usuario.Text = pUsuarioL.Apellido2_usuario;
            this.oUsuarioL = pUsuarioL;
            if (pUsuarioL.Activo.Equals("SI"))
            {
                this.CBActivo.Checked = true;
            }
            else { this.CBActivo.Checked = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptarUsuario_Click(object sender, EventArgs e)
        {
            if ((this.txtIdUsuario.Text == "")||
                (this.txtNombreUsuario.Text == "")||
                (this.txtApellido1Usuario.Text=="")||
                (this.txtApellido2Usuario.Text=="")||(this.txtClaveUsuario.Text==""))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }

            if (cmbTipo.Text.Equals("Administrador"))
            {
                this.tipo = "A";
            }
            else
            {
                this.tipo = "U";
            } 

            if (this.CBActivo.Checked)
            {
                activo = "SI";
            }
            else
            {
                activo = "NO";
            }
            this.oUsuarioL = new UsuarioL(this.txtIdUsuario.Text,tipo,this.txtNombreUsuario.Text,this.txtApellido1Usuario.Text,this.txtApellido2Usuario.Text,this.txtClaveUsuario.Text,activo,"",DateTime.Now,"",DateTime.Now);
            this.aceptar = true;
            this.Close();
        }
    }
}
