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

namespace GUI
{
    public partial class frmEdicionHorario : Form
    {
        #region atributos
        private Boolean aceptar;
        private HorarioL oHorarioL;
        string Domingo = "";
        string Lunes = "";
        string Martes = "";
        string Miercoles = "";
        string Jueves = "";
        string Viernes = "";
        string Sabado = "";
        string Activo = "";
        string usuario;
        #endregion

        public HorarioL OHorarioL
        {
            get { return oHorarioL; }
        }

        public Boolean Aceptar
        {
            get { return aceptar; }
        }
        
        public frmEdicionHorario(string pUsuario)
        {
            this.usuario = pUsuario;
            InitializeComponent();
        }

        public frmEdicionHorario(HorarioL pHorarioL, string pUsuario)
        {
            this.usuario = pUsuario;
            InitializeComponent();
            this.aceptar = false;
            this.txtIdHorario.Text = pHorarioL.Id_horario;

            this.oHorarioL = pHorarioL;
            if (pHorarioL.Domingo.Equals("SI"))
            {
                this.chDomingo.Checked = true;
            }
            else { this.chDomingo.Checked = false; }
            if (pHorarioL.Lunes.Equals("SI"))
            {
                this.chLunes.Checked = true;
            }
            else { this.chLunes.Checked = false; }
            if (pHorarioL.Martes.Equals("SI"))
            {
                this.chMartes.Checked = true;
            }
            else { this.chMartes.Checked = false; }
            if (pHorarioL.Miercoles.Equals("SI"))
            {
                this.chMiercoles.Checked = true;
            }
            else { this.chMiercoles.Checked = false; }
            if (pHorarioL.Jueves.Equals("SI"))
            {
                this.chJueves.Checked = true;
            }
            else { this.chJueves.Checked = false; }
            if (pHorarioL.Viernes.Equals("SI"))
            {
                this.chViernes.Checked = true;
            }
            else { this.chViernes.Checked = false; }
            if (pHorarioL.Sabado.Equals("SI"))
            {
                this.chSabado.Checked = true;
            }
            else { this.chSabado.Checked = false; }
            if (pHorarioL.Estado.Equals("SI"))
            {
                this.chActivo.Checked = true;
            }
            else { this.chActivo.Checked = false; }
        }

        private void btnAceptarHorario_Click(object sender, EventArgs e)
        {

            if ((this.txtIdHorario.Text == ""))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }
            #region Dias
            if (this.chDomingo.Checked)
            {
                Domingo = "SI";
            }
            else
            {
                Domingo = "NO";
            }
            if (this.chLunes.Checked)
            {
                Lunes = "SI";
            }
            else
            {
                Lunes = "NO";
            }
            if (this.chMartes.Checked)
            {
                Martes = "SI";
            }
            else
            {
                Martes = "NO";
            }
            if (this.chMiercoles.Checked)
            {
                Miercoles = "SI";
            }
            else
            {
                Miercoles = "NO";
            }
            if (this.chJueves.Checked)
            {
                Jueves = "SI";
            }
            else
            {
                Jueves = "NO";
            }
            if (this.chViernes.Checked)
            {
                Viernes = "SI";
            }
            else
            {
                Viernes = "NO";
            }
            if (this.chSabado.Checked)
            {
                Sabado = "SI";
            }
            else
            {
                Sabado = "NO";
            }
            #endregion
            if (this.chActivo.Checked)
            {
                Activo = "SI";
            }
            else
            {
                Activo = "NO";
            }
            this.oHorarioL = new HorarioL(this.txtIdHorario.Text, Domingo, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado,
                                      dtpEntrada.Value,dtpSalida.Value, Activo, 
                                      usuario, DateTime.Now, usuario, DateTime.Now);
            this.aceptar = true;
            this.Close();
        }

        private void btnCancelarHorario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
