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
using GUI;

namespace GUI
{
    public partial class frmMantDepartamento : Form
    {
        AccesoDatosOracle cnx;
        private string usuario;

        public frmMantDepartamento(AccesoDatosOracle pConexion, string pUsuario)
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
                DepartamentoD oDepartamentoD = new DepartamentoD(this.cnx);
                this.grdDepartamento.DataSource = oDepartamentoD.obtenerDepartamentos();
                if (oDepartamentoD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oDepartamentoD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionDepartamento ofrmEdicion = new frmEdicionDepartamento(usuario);
            ofrmEdicion.ShowDialog();
            if (ofrmEdicion.Aceptar)
            {
                DepartamentoD oDepartamentoD = new DepartamentoD(this.cnx);
                oDepartamentoD.agregarDepartamento(ofrmEdicion.ODepartamentoL);
                if (oDepartamentoD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oDepartamentoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Departamento agregado.");
                    this.cargarGrid();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdDepartamento.RowCount > 0)
            {
                DepartamentoL oDepartamentoOriginal = (DepartamentoL)this.grdDepartamento.CurrentRow.DataBoundItem;

                frmEdicionDepartamento ofrmEdicion = new frmEdicionDepartamento(oDepartamentoOriginal,usuario);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    DepartamentoD oDepartamentoD = new DepartamentoD(this.cnx);
                    oDepartamentoD.editarDepartamento(ofrmEdicion.ODepartamentoL, oDepartamentoOriginal);
                    if (oDepartamentoD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oDepartamentoD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Departamento actualizado.");
                        this.cargarGrid();
                    }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.grdDepartamento.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar este departamento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                //se pueden obtener los valores directamente de las celdas
                //como si fuera una matriz, acá los valores se recuperan como
                //strings, en caso de otro tipo de datos habría que hacer
                //la respectiva convesión, no los vamos a usar en este ejemplo, 
                //agrego estas líneas solo para que conozcan esta posibilidad:
                int fila = this.grdDepartamento.CurrentRow.Index;
                string codigo = this.grdDepartamento[1, fila].Value.ToString();
                string descripcion = this.grdDepartamento[2, fila].Value.ToString();

                //o se puede obtener un objeto que representa el dato
                //de la fila, recuerden que se cargo originalmente con un
                //arreglo de objetos, este es mejor cuando se maneja campos 
                //con formato, como fechas, numéricos con decimales, etc.
                DepartamentoL oDepartamentoL = (DepartamentoL)this.grdDepartamento.CurrentRow.DataBoundItem;

                DepartamentoD oDepartamentoD = new DepartamentoD(this.cnx);
                oDepartamentoD.borrarDepartamento(oDepartamentoL);

                if (oDepartamentoD.Error)
                {
                    MessageBox.Show("Error borrando el departamento:" + oDepartamentoD.ErrorDescription);
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
