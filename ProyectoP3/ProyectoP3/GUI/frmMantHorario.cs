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
using Datos;

namespace GUI
{
    public partial class frmMantHorario : Form
    {
        AccesoDatosOracle cnx;
        private string usuario;

        public frmMantHorario(AccesoDatosOracle pCnx,string pUsuario)
        {
            usuario = pUsuario;
            InitializeComponent();
            this.cnx = pCnx;
            cargarGrid();
        }

        public void cargarGrid()
        {
            try
            {
                HorarioD oHorarioD = new HorarioD(this.cnx);
                this.grdHorario.DataSource = oHorarioD.obtenerHorarios();
                if (oHorarioD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oHorarioD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.grdHorario.RowCount > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar este Horario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                HorarioL oHorarioL = (HorarioL)this.grdHorario.CurrentRow.DataBoundItem;

                HorarioD oHorarioD = new HorarioD(this.cnx);
                oHorarioD.borrarHorario(oHorarioL);

                if (oHorarioD.Error)
                {
                    MessageBox.Show("Error borrando el Horario:" + oHorarioD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Horario borrado");
                    this.cargarGrid();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdHorario.RowCount > 0)
            {
                HorarioL oHorarioOriginal = (HorarioL)this.grdHorario.CurrentRow.DataBoundItem;

                frmEdicionHorario ofrmEdicionHorario = new frmEdicionHorario(oHorarioOriginal,usuario);
                ofrmEdicionHorario.ShowDialog();
                if (ofrmEdicionHorario.Aceptar)
                {
                    HorarioD oHorarioD = new HorarioD(this.cnx);
                    oHorarioD.editarHorario(ofrmEdicionHorario.OHorarioL, oHorarioOriginal);
                    if (oHorarioD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oHorarioD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Horario actualizado.");
                        this.cargarGrid();
                    }
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionHorario ofrmEdicionHorario = new frmEdicionHorario(usuario);
            ofrmEdicionHorario.ShowDialog();
            if (ofrmEdicionHorario.Aceptar)
            {
                HorarioD oHorarioD = new HorarioD(this.cnx);
                oHorarioD.agregarHorario(ofrmEdicionHorario.OHorarioL);
                if (oHorarioD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oHorarioD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Horario agregado.");
                    this.cargarGrid();
                }
            }
        }

    }
}
