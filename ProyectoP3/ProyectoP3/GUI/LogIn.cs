using Datos;
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
    public partial class LogIn : Form
    {
        private bool aceptar;
        private UsuarioL oUsuario;

        #region Properties
        public bool Aceptar
        {
            get { return aceptar; }
        }

        public UsuarioL OUsuario
        {
            get { return oUsuario; }
        }
#endregion

        private AccesoDatosOracle conexion;

        public LogIn(AccesoDatosOracle conexion)
        {
            this.conexion = conexion;    
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioD usuarios = new UsuarioD(conexion);

            string usuario = textBox1.Text;
            string contrasenna = textBox2.Text;

            DataSet dsetUsuarios = usuarios.ValidarUsuario(usuario, contrasenna);

            if (dsetUsuarios.Tables[0].Rows.Count > 0)
            {
                Boolean perfil;
                if (dsetUsuarios.Tables[0].Rows[0][1].ToString().Equals("A"))
                {
                    perfil = true;
                }
                else
                {
                    perfil = false;
                }
                Principal principal = new Principal(conexion, dsetUsuarios.Tables[0].Rows[0][0].ToString(), perfil);
                this.Visible = false;
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nombre de Usuario y/o Contraseña incorrectos");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }


    }
}
