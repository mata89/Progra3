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
    public partial class frmEdicionEmpleado : Form
    {
        private string genero = "";
        private string activo = "";
        private Boolean aceptar;
        private EmpleadoL oEmpleadoL;
        private string usuario;
        AccesoDatosOracle cnx;

        public frmEdicionEmpleado(AccesoDatosOracle pCnx,string pUsuario)
        {
            InitializeComponent();
            this.usuario = pUsuario;
            this.aceptar = false;
            this.cnx = pCnx;
            this.cargarComboDepartamentos();
            this.cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public frmEdicionEmpleado(EmpleadoL pEmpleadoL, AccesoDatosOracle pCnx,string pUsuario)
        {
            this.cnx = pCnx;
            this.usuario = pUsuario;
            InitializeComponent();
            this.aceptar = false;
            cargarComboDepartamentos();
            this.txtCodigoEmpleado.Text = pEmpleadoL.Id_empleado;
            this.txtNombreEmpleado.Text = pEmpleadoL.Nombre_empleado;
            this.txtApellido1Empleado.Text = pEmpleadoL.Apellido_1;
            this.txtApellido2Empleado.Text = pEmpleadoL.Apellido_2;
            this.txtDireccionEmpleado.Text = pEmpleadoL.Direccion;
            this.nudSalario.Text = pEmpleadoL.Salario_por_hora.ToString();
            if (pEmpleadoL.Genero.Equals("F"))
            {
                this.cmbGenero.Text = "Femenino";
            }
            else {
                this.cmbGenero.Text = "Masculino";
            }
            this.cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            if (pEmpleadoL.Activo.Equals("SI"))
            {
                this.CBActivo.Checked = true;
            }
            else { this.CBActivo.Checked = false; }
            this.nudSalario.Value = (decimal)pEmpleadoL.Salario_por_hora;
            this.cargarComboDepartamentos();
            this.cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            this.oEmpleadoL = pEmpleadoL;
        }

        #region Properties
        public Boolean Aceptar
        {
            get { return aceptar; }
        }

        public EmpleadoL OEmpleadoL
        {
            get { return oEmpleadoL; }
        }
        #endregion

        public void cargarComboDepartamentos()
        {
            DepartamentoD oDepartamentoD = new DepartamentoD(this.cnx);
            DataSet dsetDepartamento = oDepartamentoD.obtenerDepartamentos(true).Copy();
            if (oDepartamentoD.Errorsh != "")
            {
                MessageBox.Show(oDepartamentoD.Errorsh);
                return;
            }

            this.cmbDepartamento.DataSource = dsetDepartamento.Tables[0];
            this.cmbDepartamento.ValueMember = "id_departamento";
            this.cmbDepartamento.DisplayMember = "nombre_departamento";
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnCancelarEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarEmpleado_Click(object sender, EventArgs e)
        {
            if ((this.txtCodigoEmpleado.Text == "") ||
                (this.txtNombreEmpleado.Text == "") ||
                (this.txtApellido1Empleado.Text == "") ||
                (this.txtApellido2Empleado.Text == "") ||
                (this.txtDireccionEmpleado.Text == "") ||
                (this.txtSalarioEmpleado.Text == "")||
                (this.nudSalario.Value <= 0))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }
            
            if (cmbGenero.Text.Equals("Femenino")) {
                this.genero = "F";
            }else{
                this.genero="M";
            } 
            if (this.CBActivo.Checked)
            {
                activo = "SI";
            }
            else
            {
                activo = "NO";
            }
            this.oEmpleadoL = new EmpleadoL(this.txtCodigoEmpleado.Text,this.cmbDepartamento.SelectedValue.ToString(),
                this.txtNombreEmpleado.Text,this.txtApellido1Empleado.Text,this.txtApellido2Empleado.Text,this.genero,
                this.txtDireccionEmpleado.Text,Double.Parse(this.nudSalario.Value.ToString()),this.activo,usuario,DateTime.Now,
                usuario,DateTime.Now);
            this.aceptar = true;
            this.Close();
        }
    }
}
