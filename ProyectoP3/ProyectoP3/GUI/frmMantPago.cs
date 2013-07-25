using Datos;
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
    public partial class frmMantPago : Form
    {
        AccesoDatosOracle cnx;
        private string usuario;

        public frmMantPago(AccesoDatosOracle pConexion, string pUsuario)
        {
            InitializeComponent();
            this.cnx = pConexion;
            this.usuario = pUsuario;
            this.cargarGrid();
        }

        public void cargarGrid()
        {
            try
            {
                PagoD oPagoD = new PagoD(this.cnx);
                this.grdPagos.DataSource = oPagoD.obtenerPagos();
                if (oPagoD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oPagoD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdPagos.RowCount > 0)
            {
                PagoL oPagoOriginal = (PagoL)this.grdPagos.CurrentRow.DataBoundItem;

                frmEdicionPago ofrmEdicion = new frmEdicionPago(oPagoOriginal,usuario);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    PagoD oPagoD = new PagoD(this.cnx);
                    oPagoD.editarPago(ofrmEdicion.OPagoL,oPagoOriginal);
                    if (oPagoD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oPagoD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Empleado actualizado.");
                        this.cargarGrid();
                    }
                }
            }
        }
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionPago ofrmEdicion = new frmEdicionPago(usuario);
            ofrmEdicion.ShowDialog();
            if (ofrmEdicion.Aceptar)
            {
                PagoD oPagoD = new PagoD(this.cnx);
                oPagoD.agregarPago(ofrmEdicion.OPagoL);
                if (oPagoD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oPagoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Departamento agregado.");
                    this.cargarGrid();
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (this.grdPagos.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar este pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;
                PagoL oPagoL = (PagoL)this.grdPagos.CurrentRow.DataBoundItem;

                PagoD oPagoD = new PagoD(this.cnx);
                oPagoD.borrarPago(oPagoL);

                if (oPagoD.Error)
                {
                    MessageBox.Show("Error borrando el departamento:" + oPagoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Departamento borrado");
                    this.cargarGrid();
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
        }
    }
}
