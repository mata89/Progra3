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
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

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

                FacturaD oFacturaD = new FacturaD(this.conexion);
                string numero = oFacturaD.agregarFactura(this.factura);
                if (oFacturaD.Error)
                {
                    this.conexion.rollbackTransaccion();
                    MessageBox.Show("Error, detalle:" + oFacturaD.ErrorDescription);
                    return;
                }

                this.factura.Numero = Int32.Parse(numero);
                FacturaDetalleD oDetalle = new FacturaDetalleD(this.conexion);
                for (int i = 0; i < this.factura.obtenerDetalle().Count; i++)
                {
                    oDetalle.agregarDetalle(this.factura.obtenerDetalle()[i]);
                    if (oDetalle.Error)
                    {
                        this.conexion.rollbackTransaccion();
                        MessageBox.Show("Error, detalle:" + oDetalle.ErrorDescription);
                        return;
                    }
                }

                this.conexion.commitTransaccion();

                if ((this.txtIdEmpleado.Text != ""))
                {
                    //this.conexion.iniciarTransaccion();


                    //this.conexion.commitTransaccion();
                    
                    MessageBox.Show("It's OK!");
                   
                    
                }
                else
                { 
                    MessageBox.Show("Error al generar Marca","",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
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


    }
}
