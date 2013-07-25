using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class UsuarioL
    {
        private string id_usuario;
        private string tipo_usuario;
        private string nombre_usuario;
        private string apellido1_usuario;
        private string apellido2_usuario;
        private string contrasenia;
        private string activo;
        private string creado_por;
        private DateTime fecha_creacion;
        private string modificado_por;
        private DateTime fecha_modificacion;
       
        public UsuarioL(string pId_usuario,string pTipo_usuario,string pNombre_usuario,string pApellido1_usuario,string pApellido2_usuario,string pContrasenia,string pActivo,string pCreado_por,DateTime pFecha_creacion,string pModificado_por,DateTime pFecha_modificacion) {
            this.id_usuario = pId_usuario;
            this.tipo_usuario = pTipo_usuario;
            this.nombre_usuario = pNombre_usuario;
            this.apellido1_usuario = pApellido1_usuario;
            this.apellido2_usuario = pApellido2_usuario;
            this.contrasenia = pContrasenia;
            this.activo = pActivo;
            this.creado_por = pCreado_por;
            this.fecha_creacion = pFecha_creacion;
            this.modificado_por = pModificado_por;
            this.fecha_modificacion = pFecha_modificacion;
        }
        public UsuarioL(string pLogin, string pDescripcion, string pClave)
        {
            this.id_usuario = pLogin;
            this.nombre_usuario = pDescripcion;
            this.contrasenia = pClave;
        }

        public string toString() { 
            return("Nombre del Usuario: "+this.nombre_usuario+" "+this.apellido1_usuario+" "+this.apellido2_usuario+
                "Tipo de Usuario: "+this.tipo_usuario+
                "Identificación del Usuario:"+this.id_usuario);
        }

        #region Properties
        public string Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        
        public string Tipo_usuario
        {
            get { return tipo_usuario; }
            set { tipo_usuario = value; }
        }

        public string Nombre_usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }

        public string Apellido1_usuario
        {
            get { return apellido1_usuario; }
            set { apellido1_usuario = value; }
        }
        
        public string Apellido2_usuario
        {
            get { return apellido2_usuario; }
            set { apellido2_usuario = value; }
        }

        public string Contrasenia
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }
        
        public string Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        
        public string Creado_por
        {
            get { return creado_por; }
            set { creado_por = value; }
        }
        
        public DateTime Fecha_creacion
        {
            get { return fecha_creacion; }
        }
        
        public string Modificado_por
        {
            get { return modificado_por; }
            set { modificado_por = value; }
        }
        
        public DateTime Fecha_modificacion
        {
            get { return fecha_modificacion; }
        }
#endregion

    }
}
