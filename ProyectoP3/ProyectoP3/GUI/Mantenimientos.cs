using Datos;
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
    public partial class Mantenimientos : Form
    { 
        AccesoDatosOracle cnx;
        string usuario;

        public Mantenimientos(AccesoDatosOracle pConexion, string pUsuario)
        {
            this.usuario = pUsuario;
            this.cnx = pConexion;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMantDepartamento ofrmMantDepartamento = new frmMantDepartamento(this.cnx,this.usuario);
            ofrmMantDepartamento.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMantDeducciones ofrmMantDeducciones = new frmMantDeducciones(this.cnx, this.usuario);
            ofrmMantDeducciones.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmMantUsuario ofrmMantUsuario = new frmMantUsuario(this.cnx, this.usuario);
            ofrmMantUsuario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMantDiasPagoDoble ofrmMantDiasPagoDoble = new frmMantDiasPagoDoble(this.cnx, this.usuario);
            ofrmMantDiasPagoDoble.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMantEmpleado ofrmMantEmpleado = new frmMantEmpleado(this.cnx, this.usuario);
            ofrmMantEmpleado.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMantHorario ofrmMantHorario = new frmMantHorario(cnx, this.usuario);
            ofrmMantHorario.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmMantPago ofrmMantPago = new frmMantPago(this.cnx, this.usuario);
            ofrmMantPago.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmMantMarca ofrmMantMarca = new frmMantMarca(this.cnx, usuario);
            ofrmMantMarca.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
