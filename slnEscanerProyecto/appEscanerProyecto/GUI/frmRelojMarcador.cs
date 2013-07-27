using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace GUI
{
    public partial class frmRelojMarcador : Form
    {
        private AccesoDatosOracle conexion;

        public frmRelojMarcador(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            conexion = pConexion;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.Hour.ToString() + " : " +
                                DateTime.Now.Minute.ToString() + " : " +
                                DateTime.Now.Second.ToString();
            this.lblFecha.Text = DateTime.Now.Day.ToString() + " / " +
                                DateTime.Now.Month.ToString() + " / " +
                                DateTime.Now.Year.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.conexion.iniciarTransaccion();

                if (txtIdEmpleado.Text != "")
                {
                    string mensaje = "";
                    MarcaD oMarcaD = new MarcaD(this.conexion, txtIdEmpleado.Text);
                    mensaje = oMarcaD.Marcar();
                    if (oMarcaD.Error == false)
                    {
                        MessageBox.Show("Error al ingreasar marca");
                        frmMensaje msj = new frmMensaje(false, mensaje);
                        msj.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Marca registrada");
                        frmMensaje msj = new frmMensaje(true, mensaje);
                        msj.ShowDialog();
                    }
                }
                else
                {
                    //MessageBox.Show("No ingreso id");
                    //frmMensaje msj = new frmMensaje(true, "No ingreso ningun ID");
                    //msj.ShowDialog();
                }
                this.txtIdEmpleado.Text = "";
            }
        }

        #region eventos
        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
