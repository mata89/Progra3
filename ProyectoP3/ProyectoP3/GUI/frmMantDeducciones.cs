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
    public partial class frmMantDeducciones : Form
    {
        AccesoDatosOracle cnx;
        private string usuario;

        public frmMantDeducciones(AccesoDatosOracle pConexion,string pUsuario)
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
                DeduccionesD oDeduccionesD = new DeduccionesD(this.cnx);
                this.grdDeducciones.DataSource = oDeduccionesD.obtenerDeducciones();
                if (oDeduccionesD.Error)
                {
                    MessageBox.Show("Error cargando los datos: " + oDeduccionesD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos: " + e.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionDeducciones ofrmEdicion = new frmEdicionDeducciones(usuario);
            ofrmEdicion.ShowDialog();
            if (ofrmEdicion.Aceptar)
            {
                DeduccionesD oDeduccionesD = new DeduccionesD(this.cnx);
                oDeduccionesD.agregarDeduccion(ofrmEdicion.ODeduccionesL);
                if (oDeduccionesD.Error)
                {
                    MessageBox.Show("Error agregando los datos: " + oDeduccionesD.ErrorDescription);
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
            if (this.grdDeducciones.RowCount > 0)
            {
                DeduccionesL oDeduccionOriginal = (DeduccionesL)this.grdDeducciones.CurrentRow.DataBoundItem;

                frmEdicionDeducciones ofrmEdicion = new frmEdicionDeducciones(oDeduccionOriginal,usuario);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    DeduccionesD oDeduccionesD = new DeduccionesD(this.cnx);
                    oDeduccionesD.editarDeduccion(ofrmEdicion.ODeduccionesL, oDeduccionOriginal);
                    if (oDeduccionesD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oDeduccionesD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Deducción actualizada.");
                        this.cargarGrid();
                    }
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.grdDeducciones.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar esta deducción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                //se pueden obtener los valores directamente de las celdas
                //como si fuera una matriz, acá los valores se recuperan como
                //strings, en caso de otro tipo de datos habría que hacer
                //la respectiva convesión, no los vamos a usar en este ejemplo, 
                //agrego estas líneas solo para que conozcan esta posibilidad:
                int fila = this.grdDeducciones.CurrentRow.Index;
                string codigo = this.grdDeducciones[1, fila].Value.ToString();
                string descripcion = this.grdDeducciones[2, fila].Value.ToString();

                //o se puede obtener un objeto que representa el dato
                //de la fila, recuerden que se cargo originalmente con un
                //arreglo de objetos, este es mejor cuando se maneja campos 
                //con formato, como fechas, numéricos con decimales, etc.
                DeduccionesL oDeduccionesL = (DeduccionesL)this.grdDeducciones.CurrentRow.DataBoundItem;

                DeduccionesD oDeduccionesD = new DeduccionesD(this.cnx);
                oDeduccionesD.borrarDeduccion(oDeduccionesL);

                if (oDeduccionesD.Error)
                {
                    MessageBox.Show("Error borrando la deducción:" + oDeduccionesD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Deducción borrada");
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
