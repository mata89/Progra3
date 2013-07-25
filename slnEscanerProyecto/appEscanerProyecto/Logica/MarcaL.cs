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
        private string id_marca;
        private string id_empleado;
        private string id_unificacion;
        private string tipo;
        private DateTime fechaHora_marca;
        private string estado;
        private DateTime fecha_creacion;
        private string creada_por;
        private MarcaD marcaD;

        public MarcaL(string pId_empleado,DateTime pFechaHora_actual )
        {
            this.id_marca = Id_marca;
            this.id_empleado = pId_empleado;
            this.id_unificacion = "";
            this.tipo = Tipo;
            this.fechaHora_marca = pFechaHora_actual;
            this.estado = "Generada";
            this.fecha_creacion = pFechaHora_actual;
            this.creada_por = pId_empleado;
        }

        


        //Properties (gets y sets)
        #region properties
        public string Id_marca
        {
            get { return id_marca; }
            set { id_marca = value; }
        }

        public string Id_empleado
        {
            get { return id_empleado; }
            set { id_empleado = (marcaD.ulitmoIdMarca() + 1) + "";}
        }

        public string Id_unificacion
        {
            get { return id_unificacion; }
            set { id_unificacion = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public DateTime FechaHora_marca
        {
            get { return fechaHora_marca; }
            set { fechaHora_marca = value; }
        }

        public string CreadaPor
        {
            get { return creada_por; }
            set { creada_por = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }
        #endregion
    }
}
