using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    class MarcaL
    {
        #region Atributos
        private string id_marca;
        private string id_empleado;
        private string id_unificacion;
        private string tipo_marca;
        private string fechaHora_marca;
        private string estado_marca;
        private string creado_por;
        private string fecha_creacion;
        private string modificado_por;
        private string fecha_modificacion;
        #endregion

        //Metodo constructor
        public MarcaL(string pId_Marca, string pId_empleado,string pId_Unificacion, string pEstado,  string pFechaHora_marca, 
                      string pActivo, string pCreada_por, string pFecha_creacion, string pModificada_por, string pFecha_modificacion)
        {
            this.id_marca = Id_marca;
            this.id_empleado = pId_empleado;
            this.id_unificacion = pId_Unificacion;
            this.tipo_marca = Tipo_marca;
            this.fechaHora_marca = pFechaHora_marca;
            this.estado_marca = pEstado;
            this.creado_por = pId_empleado;
            this.fecha_creacion = pFecha_creacion;
            this.modificado_por = pModificada_por;
            this.fecha_modificacion = pFecha_modificacion;
        }

        //Properties (gets y sets)
        #region Properties
        public string Id_marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }

        public string Id_empleado
        {
            get { return id_empleado; }
            set { id_empleado = value;}
        }

        public string Id_unificacion
        {
            get { return id_unificacion; }
            set { id_unificacion = value; }
        }

        public string Tipo_marca
        {
            get { return tipo_marca; }
            set { tipo_marca = value; }
        }

        public string FechaHora_marca
        {
            get { return fechaHora_marca; }
            set { fechaHora_marca = value; }
        }
        
        public string Estado_marca
        {
            get { return estado_marca; }
            set { estado_marca = value; }
        }

        public string Creado_por
        {
            get { return creado_por; }
            set { creado_por = value; }
        }

        public string FechaCreacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }

        public string ModificadaPor
        {
            get { return modificado_por; }
            set { modificado_por = value; }
        }

        public string FechaModificacion
        {
            get { return fecha_modificacion; }
            set { fecha_modificacion = value; }
        }
        #endregion
    }
}
