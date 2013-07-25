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
    public partial class frmMantMarca : Form
    {
        AccesoDatosOracle cnx;
        private string usuario;
        public frmMantMarca(AccesoDatosOracle pConexion, string pUsuario)
        {
            InitializeComponent();
            this.cnx = pConexion;
            this.usuario = pUsuario;
            cargarGrid();
            cargarCombos();
        }

        public void cargarGrid()
        {
            try
            {
                MarcaD oMarcaD = new MarcaD(this.cnx);
                this.dataGridView1.DataSource = oMarcaD.obtenerMarcas();
                if (oMarcaD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oMarcaD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }

        public void cargarCombos()
        {
            #region por Empleado
            EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
            DataSet dsetEmpleados = oEmpleadoD.obtenerEmpleados(true).Copy();
            if (oEmpleadoD.ErrorDescription != "")
            {
                MessageBox.Show("Empleado: "+oEmpleadoD.ErrorDescription);
                return;
            }
            this.cmbEmpleados.DataSource = dsetEmpleados.Tables[0];
            this.cmbEmpleados.ValueMember = "id_empleado";
            this.cmbEmpleados.DisplayMember = "id_empleado";
            this.cmbEmpleados.Text = "";
            #endregion

            #region por Departamento
            DepartamentoD oDepartamentoD = new DepartamentoD(this.cnx);
            DataSet dsetDepartamentos = oDepartamentoD.obtenerDepartamentos(true).Copy();
            if (oDepartamentoD.ErrorDescription != "")
            {
                MessageBox.Show("Departamento: "+oDepartamentoD.ErrorDescription);
                return;
            }
            this.cmbDepartamentos.DataSource = dsetDepartamentos.Tables[0];
            this.cmbDepartamentos.ValueMember = "id_departamento";
            this.cmbDepartamentos.DisplayMember = "nombre_departamento";
            this.cmbDepartamentos.Text = "";
            #endregion

            #region por Código
            MarcaD oMarcaD = new MarcaD(this.cnx);
            DataSet dseMarca = oMarcaD.obtenerMarcas(true).Copy();
            if (oDepartamentoD.ErrorDescription != "")
            {
                MessageBox.Show("Marcas: " + oDepartamentoD.ErrorDescription);
                return;
            }
            this.cmbCodigo.DataSource = dsetDepartamentos.Tables[0];
            this.cmbCodigo.ValueMember = "id_marca";
            this.cmbCodigo.DisplayMember = "id_marca";
            this.cmbCodigo.Text = "";
#endregion
        }

        private void filtrar()
        {
            DateTime? fechaIni = null;
            DateTime? fechaFin = null;
            string departamento = null;
            string estado = null;
            string codigo = null;
            string empleado = null;


            if (this.dateInicio.Checked)
            {
                fechaIni = new DateTime(this.dateInicio.Value.Year,
                                        this.dateInicio.Value.Month,
                                        this.dateInicio.Value.Day, 0, 0, 0);
            }

            if (this.dateFin.Checked)
            {
                fechaFin = new DateTime(this.dateFin.Value.Year,
                                        this.dateFin.Value.Month,
                                        this.dateFin.Value.Day, 23, 59, 59);
            }

            if (!this.cmbDepartamentos.Text.Equals(""))
            {
                try
                {
                    departamento = cmbDepartamentos.SelectedValue.ToString();
                }
                catch (Exception e)
                {
                }
            }

            if (!this.cmbEstado.Text.Equals(""))
            {
                try
                {
                    estado = cmbEstado.SelectedValue.ToString();
                }
                catch (Exception e)
                {
                }
            }
            if (!this.cmbCodigo .Text.Equals(""))
            {
                try
                {
                    estado = cmbEstado.SelectedValue.ToString();
                }
                catch (Exception e)
                {
                }
            }

            if (!this.cmbEmpleados.Text.Equals(""))
            {
                try
                {
                    empleado = cmbEmpleados.SelectedValue.ToString();
                }
                catch (Exception e)
                {
                }
            } 
            MarcaD oMarcaD = new MarcaD(this.cnx);
            DataSet datos = oMarcaD.consultarMarcas(fechaIni, fechaFin, departamento, estado, empleado);

            if (oMarcaD.ErrorDescription != "")
            {
                MessageBox.Show("Ha ocurrido un error:" + oMarcaD.ErrorDescription);
            }
            else
            {
                this.dataGridView1.DataSource = datos.Tables[0];
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevaMarca ofrmEdicion = new frmNuevaMarca(this.cnx,this.usuario);
            ofrmEdicion.ShowDialog();
            if (ofrmEdicion.Aceptar)
            {
                MarcaD oMarcaD = new MarcaD(this.cnx);
                oMarcaD.agregarMarca(ofrmEdicion.OMarcaL);
                if (oMarcaD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oMarcaD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Marca agregada.");
                    this.cargarGrid();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount > 0)
            {
                MarcaL oMarcaOriginal = (MarcaL)this.dataGridView1.CurrentRow.DataBoundItem;

                frmNuevaMarca ofrmEdicion = new frmNuevaMarca(oMarcaOriginal, this.cnx, usuario);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    MarcaD oMarcaD = new MarcaD(this.cnx);
                    oMarcaD.editarMarca(ofrmEdicion.OMarcaL, oMarcaOriginal);
                    if (oMarcaD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oMarcaD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Departamento actualizado.");
                        this.cargarGrid();
                    }
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar esta marca?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;
                DepartamentoL oDepartamentoL = (DepartamentoL)this.dataGridView1.CurrentRow.DataBoundItem;

                DepartamentoD oDepartamentoD = new DepartamentoD(this.cnx);
                oDepartamentoD.borrarDepartamento(oDepartamentoL);

                if (oDepartamentoD.Error)
                {
                    MessageBox.Show("Error borrando la marca:" + oDepartamentoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Marca borrado");
                    this.cargarGrid();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cmbEstado.Text = "";
            this.cmbDepartamentos.Text = "";
            this.cmbEmpleados.Text = "";
            this.cmbCodigo.Text = "";
            this.dateInicio.Checked = false;
            this.dateFin.Checked = false;
            filtrar();
        }


        private void dateInicio_ValueChanged(object sender, EventArgs e)
        {
            filtrar();
        }
        private void dateFin_ValueChanged(object sender, EventArgs e)
        {
            filtrar();
        }
        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }
        private void cmbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }
        private void Movimientos_Activated(object sender, EventArgs e)
        {
            filtrar();
        }
        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }



        

        

    }
}
