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
using Lógica;

namespace GUI
{
    public partial class frmMantEmpleado : Form
    {
        AccesoDatosOracle cnx;
        private string usuario;

        public frmMantEmpleado(AccesoDatosOracle pConexion, string pUsuario)
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
                EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                this.grdEmpleado.DataSource = oEmpleadoD.obtenerEmpleados();
                if (oEmpleadoD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oEmpleadoD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            this.cargarGrid();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (this.grdEmpleado.RowCount > 0)
            {
                
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar este Empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                int fila = this.grdEmpleado.CurrentRow.Index;
                string codigo = this.grdEmpleado[0, fila].Value.ToString();
                string nombre = this.grdEmpleado[1, fila].Value.ToString();
                string apellido1 = this.grdEmpleado[2, fila].Value.ToString();
                string apellido2 = this.grdEmpleado[3, fila].Value.ToString();
                string genero = this.grdEmpleado[4, fila].Value.ToString();
                string direccion = this.grdEmpleado[5, fila].Value.ToString();
                string departamento = this.grdEmpleado[6, fila].Value.ToString();
                string salario = this.grdEmpleado[7, fila].Value.ToString();
                string estado = this.grdEmpleado[8, fila].Value.ToString();

                EmpleadoL oEmpleadoL = (EmpleadoL)this.grdEmpleado.CurrentRow.DataBoundItem;

                EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                oEmpleadoD.borrarEmpleado(oEmpleadoL);

                if (oEmpleadoD.Error)
                {
                    MessageBox.Show("Error borrando el empleado:" + oEmpleadoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Empleado borrado");
                    this.cargarGrid();
                }
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (this.grdEmpleado.RowCount > 0)
            {
                EmpleadoL oEmpleadoOriginal = (EmpleadoL)this.grdEmpleado.CurrentRow.DataBoundItem;

                frmEdicionEmpleado ofrmEdicion = new frmEdicionEmpleado(oEmpleadoOriginal,cnx,usuario);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                    oEmpleadoD.editarEmpleado(ofrmEdicion.OEmpleadoL,oEmpleadoOriginal);
                    if (oEmpleadoD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oEmpleadoD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Empleado actualizado.");
                        this.cargarGrid();
                    }
                }
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmEdicionEmpleado ofrmEdicion = new frmEdicionEmpleado(this.cnx,usuario);
            ofrmEdicion.ShowDialog();
            if (ofrmEdicion.Aceptar)
            {
                EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                oEmpleadoD.agregarEmpleado(ofrmEdicion.OEmpleadoL);
                if (oEmpleadoD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oEmpleadoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Empleado agregado.");
                    this.cargarGrid();
                }
            }
        }
    }
}
