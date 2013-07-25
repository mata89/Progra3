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
    public partial class frmEdicionDiasPagoDoble : Form
    {
        private Boolean aceptar;
        private string activo = "";
        private DiasPagoDobleL oDiasPagoDobleL;
        private string usuario;

        #region Properties
        public Boolean Aceptar
        {
            get { return aceptar; }
        }
        

        internal DiasPagoDobleL ODiasPagoDobleL
        {
            get { return oDiasPagoDobleL; }
        }
        

        public string Activo
        {
            get { return activo; }
        }
        #endregion

        public frmEdicionDiasPagoDoble(string pUsuario)
        {
            this.usuario=pUsuario;
            InitializeComponent();
            this.aceptar = false;
        }

        public frmEdicionDiasPagoDoble(DiasPagoDobleL pDiasPagoDobleL,string pUsuario)
        {
            InitializeComponent();
            this.usuario = pUsuario;
            this.aceptar = false;;
            this.txtDescripcionPagoDoble.Text = pDiasPagoDobleL.Descripcion_dia;
            if (pDiasPagoDobleL.Activo.Equals("SI"))
            {
                this.CBActivo.Checked = true;
            }
            else { this.CBActivo.Checked = false; }
            this.oDiasPagoDobleL = pDiasPagoDobleL;
        }

        private void btnAceptarPagoDoble_Click(object sender, EventArgs e)
        {
            if (this.txtDescripcionPagoDoble.Text == "")
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }

            if (this.CBActivo.Checked)
            {
                activo = "SI";
            }
            else
            {
                activo = "NO";
            }

            this.oDiasPagoDobleL = new DiasPagoDobleL(dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, this.txtDescripcionPagoDoble.Text, activo,
                                      usuario, DateTime.Now, usuario, DateTime.Now);
            this.aceptar = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
