using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class EmpleadoL
    {
        #region Atributos
        private string id_empleado;
        private string id_departamento;
        private string nombre_empleado;
        private string apellido_1;
        private string apellido_2;
        private string genero;
        private string direccion;
        private string salario_por_hora;
        private string activo;
        private string creado_por;
        private string fecha_creacion;
        private string modificado_por;
        private string fecha_modificacion;
        #endregion

        //Metodo Constructor
        public EmpleadoL(string pId_empleado, string pId_departamento, string pNombre_empleado, string pApellido_1, string pApellido_2, 
                         string pGenero, string pDireccion, string pSalario, string pActivo,
                         string pCreado_por, string pFecha_creacion, string pModificado_por, string pFecha_modificacion)
        {
            this.id_empleado = pId_empleado;
            this.id_departamento = pId_departamento;
            this.nombre_empleado = pNombre_empleado;
            this.apellido_1 = pApellido_1;
            this.apellido_2 = pApellido_2;
            this.genero = pGenero;
            this.direccion = pDireccion;
            this.salario_por_hora = pSalario;
            this.activo = pActivo;
            this.creado_por = pCreado_por;
            this.fecha_creacion = pFecha_creacion;
            this.modificado_por = pModificado_por;
            this.fecha_modificacion = pFecha_modificacion;
        }

        #region Properties
        public string Id_empleado
        {
            get { return id_empleado; }
            set { id_empleado = value; }
        }
        public string Id_departamento
        {
            get { return id_departamento; }
            set { id_departamento = value; }
        }
        public string Nombre_empleado
        {
            get { return nombre_empleado; }
            set { nombre_empleado = value; }
        }
        public string Apellido_1
        {
            get { return apellido_1; }
            set { apellido_1 = value; }
        }
        public string Apellido_2
        {
            get { return apellido_2; }
            set { apellido_2 = value; }
        }
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Salario_por_hora
        {
            get { return salario_por_hora; }
        }
        public string Activo
        {
            get { return activo; }
        }
        public string Creado_por
        {
            get { return creado_por; }
            set { creado_por = value; }
        }
        public string Fecha_creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }
        public string Modificado_por
        {
            get { return modificado_por; }
            set { modificado_por = value; }
        }
        public string Fecha_modificacion
        {
            get { return fecha_modificacion; }
            set { fecha_modificacion = value; }
        }
        #endregion
    }
}
