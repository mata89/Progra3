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
    public partial class frmMantUsuario : Form
    {
        AccesoDatosOracle cnx;
        private string usuario;

        public frmMantUsuario(AccesoDatosOracle pConexion, string pUsuario)
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
                UsuarioD oUsuarioD = new UsuarioD(this.cnx);
                this.grdUsuarios.DataSource = oUsuarioD.obtenerUsuarios();
                if (oUsuarioD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oUsuarioD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionUsuario ofrmEdicion = new frmEdicionUsuario(usuario);
            ofrmEdicion.ShowDialog();
            if (ofrmEdicion.Aceptar)
            {
                UsuarioD oUsuarioD = new UsuarioD(this.cnx);
                oUsuarioD.agregarUsuario(ofrmEdicion.OUsuarioL);
                if (oUsuarioD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oUsuarioD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Usuario agregado.");
                    this.cargarGrid();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdUsuarios.RowCount > 0)
            {
                UsuarioL oUsuarioOriginal = (UsuarioL)this.grdUsuarios.CurrentRow.DataBoundItem;

                frmEdicionUsuario ofrmEdicion = new frmEdicionUsuario(oUsuarioOriginal,usuario);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    UsuarioD oUsuarioD = new UsuarioD(this.cnx);
                    oUsuarioD.editarUsuario(ofrmEdicion.OUsuarioL, oUsuarioOriginal);
                    if (oUsuarioD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oUsuarioD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Usuario actualizado.");
                        this.cargarGrid();
                    }
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.grdUsuarios.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar esta deducción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;
                UsuarioL oUsuarioL = (UsuarioL)this.grdUsuarios.CurrentRow.DataBoundItem;

                UsuarioD oUsuarioD = new UsuarioD(this.cnx);
                oUsuarioD.borrarUsuario(oUsuarioL);

                if (oUsuarioD.Error)
                {
                    MessageBox.Show("Error borrando el usuario:" + oUsuarioD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Usuario borrada");
                    this.cargarGrid();
                }
            }
        }
    }
}
