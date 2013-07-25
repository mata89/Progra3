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
    public partial class frmEdicionPago : Form
    {
        private Boolean aceptar;
        private PagoL oPagoL;
        string anulado = "";
        private string usuario;


        #region Properties
        public Boolean Aceptar
        {
            get { return aceptar; }
        }

        internal PagoL OPagoL
        {
            get { return oPagoL; }
        }
        #endregion
        

        public frmEdicionPago(string pUsuario)
        {
            InitializeComponent();
            this.usuario = pUsuario;
            this.aceptar = false;
        }

        public frmEdicionPago(PagoL pPagoL, string pUsuario)
        {
            InitializeComponent();
            this.usuario = pUsuario;
            this.aceptar = false;
            this.txtDescripcionPago.Text = pPagoL.Descripcion;
            this.txtIdPago.Text = pPagoL.Id_pago;
            this.nudPago.Text = pPagoL.TotalPagoNeto.ToString();
            this.oPagoL = pPagoL;
            if (pPagoL.Anulado.Equals("SI"))
            {
                this.CBActivo.Checked = true;
            }
            else { this.CBActivo.Checked = false; }
        }

        private void btnAceptarPago_Click(object sender, EventArgs e)
        {
            if ((this.txtIdPago.Text == "")||(this.txtDescripcionPago.Text=="")||(nudPago.Value<=0))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }

            if (this.CBActivo.Checked)
            {
                anulado = "SI";
            }
            else
            {
                anulado = "NO";
            }

            this.oPagoL = new PagoL(this.txtIdPago.Text,DateTime.Parse(dtFechaPago.Value.ToString()),this.txtDescripcionPago.Text,Double.Parse(nudPago.Value.ToString()),anulado,usuario,DateTime.Now,usuario,DateTime.Now);
            this.aceptar = true;
            this.Close();
        }

        private void btnCancelarPago_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
