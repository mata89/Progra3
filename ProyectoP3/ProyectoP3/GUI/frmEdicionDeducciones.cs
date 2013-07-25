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
    public partial class frmEdicionDeducciones : Form
    {
        public Boolean aceptar;
        private DeduccionesL oDeduccionesL;
        string activo = "";
        private string usuario;

        #region properties
        public Boolean Aceptar
        {
            get { return aceptar; }
        }
        public DeduccionesL ODeduccionesL
        {
            get { return oDeduccionesL; }
        }
        #endregion

        public  frmEdicionDeducciones(string pUsuario)
        {
            InitializeComponent();
            this.usuario = pUsuario;
            this.aceptar = false;
        }

        public frmEdicionDeducciones(DeduccionesL pDeduccionesL,string pUsuario)
        {
            this.usuario = pUsuario;
            InitializeComponent();
            this.aceptar = false;
            this.txtIdDeduccion.Text = pDeduccionesL.Id_deduccion;
            this.txtDescripcionDeduccion.Text = pDeduccionesL.Nombre_deduccion;
            this.nudPorcentaje.Text = pDeduccionesL.Porcentaje.ToString();
            this.oDeduccionesL = pDeduccionesL;
            if (pDeduccionesL.Activo.Equals("SI"))
            {
                this.CBActivo.Checked = true;
            }
            else { this.CBActivo.Checked = false; }
        }

        private void btnAceptarDeduccion_Click(object sender, EventArgs e)
        {
            if ((this.txtDescripcionDeduccion.Text == "") ||
               (this.txtIdDeduccion.Text == "") || (this.nudPorcentaje.Value<=0))
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

            this.oDeduccionesL = new DeduccionesL(this.txtIdDeduccion.Text, this.txtDescripcionDeduccion.Text,double.Parse(nudPorcentaje.Value.ToString()),activo,usuario,DateTime.Now,usuario,DateTime.Now);
            this.aceptar = true;
            this.Close();
        }

        private void btnCancelarDeduccion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
