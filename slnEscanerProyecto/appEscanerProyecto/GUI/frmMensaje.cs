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
    public partial class frmMensaje : Form
    {
        public frmMensaje(bool pCondidicion, string pMensaje)
        {
            InitializeComponent();
            lblError.Visible = false;
            generarMensaje(pCondidicion, pMensaje);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generarMensaje(bool pCondidicion, string pMensaje)
        {
            if (pCondidicion == false)
            {
                lblError.Visible = true;
                lblMensaje.Text = "Error al generar la marca. /nIntente nuevamente ";
            }
            else
            {
                lblMensaje.Text = pMensaje;
            }
        }


    }
}
