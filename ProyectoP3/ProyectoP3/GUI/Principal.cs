using Datos;
using GUI;
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
    public partial class Principal : Form
    {
        AccesoDatosOracle conexion;
        Boolean administrador;
        string usuario;

        public Principal(AccesoDatosOracle conexion,string pUsuario,Boolean pAdministrador)
        {
            this.conexion = conexion;
            this.administrador = pAdministrador;
            this.usuario = pUsuario;
            InitializeComponent();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (administrador)
            {
                Mantenimientos mante = new Mantenimientos(conexion, usuario);
                mante.ShowDialog();
            }
            else
            {
                MessageBox.Show("Permisos insuficientes para acceder a mantenimientos del sistema");
            }
            
        }

    }
}
