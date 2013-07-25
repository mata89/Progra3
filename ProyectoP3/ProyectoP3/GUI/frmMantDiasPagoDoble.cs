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
    public partial class frmMantDiasPagoDoble : Form
    {
        AccesoDatosOracle cnx;
        private string usuario;

        public frmMantDiasPagoDoble(AccesoDatosOracle pConexion, string pUsuario)
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
                DiasPagoDobleD oDiasPagoDobleD = new DiasPagoDobleD(this.cnx);
                this.grdDiasDobles.DataSource = oDiasPagoDobleD.obtenerDiasPagoDoble();
                if (oDiasPagoDobleD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oDiasPagoDobleD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionDiasPagoDoble ofrmEdicion = new frmEdicionDiasPagoDoble(usuario);
            ofrmEdicion.ShowDialog();
            if (ofrmEdicion.Aceptar)
            {
                DiasPagoDobleD oDiasPagoDobleD = new DiasPagoDobleD(this.cnx);
                oDiasPagoDobleD.agregarDiasPagoDoble(ofrmEdicion.ODiasPagoDobleL);
                if (oDiasPagoDobleD.Error)
                {
                    MessageBox.Show("Error agregando los datos: " + oDiasPagoDobleD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Deduccion agregada.");
                    this.cargarGrid();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdDiasDobles.RowCount > 0)
            {
                DiasPagoDobleL oDiasPagoDobleOriginal = (DiasPagoDobleL)this.grdDiasDobles.CurrentRow.DataBoundItem;

                frmEdicionDiasPagoDoble ofrmEdicion = new frmEdicionDiasPagoDoble(oDiasPagoDobleOriginal,usuario);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    DiasPagoDobleD oDiasPagoDobleD = new DiasPagoDobleD(this.cnx);
                    oDiasPagoDobleD.editarDiasPagoDoble(ofrmEdicion.ODiasPagoDobleL, oDiasPagoDobleOriginal);
                    if (oDiasPagoDobleD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos: " + oDiasPagoDobleD.ErrorDescription);
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
            if (this.grdDiasDobles.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar este departamento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                //se pueden obtener los valores directamente de las celdas
                //como si fuera una matriz, acá los valores se recuperan como
                //strings, en caso de otro tipo de datos habría que hacer
                //la respectiva convesión, no los vamos a usar en este ejemplo, 
                //agrego estas líneas solo para que conozcan esta posibilidad:
                int fila = this.grdDiasDobles.CurrentRow.Index;
                string codigo = this.grdDiasDobles[1, fila].Value.ToString();
                string descripcion = this.grdDiasDobles[2, fila].Value.ToString();

                //o se puede obtener un objeto que representa el dato
                //de la fila, recuerden que se cargo originalmente con un
                //arreglo de objetos, este es mejor cuando se maneja campos 
                //con formato, como fechas, numéricos con decimales, etc.
                DiasPagoDobleL oDepartamentoL = (DiasPagoDobleL)this.grdDiasDobles.CurrentRow.DataBoundItem;

                DiasPagoDobleD oDiasPagoDobleD = new DiasPagoDobleD(this.cnx);
                oDiasPagoDobleD.borrarDiasPagoDoble(oDepartamentoL);

                if (oDiasPagoDobleD.Error)
                {
                    MessageBox.Show("Error borrando Dia de pago doble: " + oDiasPagoDobleD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Dia de pago doble borrado");
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
