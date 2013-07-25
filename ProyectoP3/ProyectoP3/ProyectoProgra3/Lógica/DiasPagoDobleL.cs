using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    class DiasPagoDobleL
    {
        private string id_dia;
        private string id_mes;
        private string descripcion_dia;
        private string creado_por;
        private DateTime fecha_creacion;
        private string modificado_por;
        private DateTime fecha_modificacion;

        public DiasPagoDobleL(string pId_dia, string pId_mes, string pDescripcion,string pCreado_por,DateTime pFecha_creacion,string pModificado_por,DateTime pFecha_modificacion)
        {
            this.id_dia=pId_dia;
            this.id_mes=pId_mes;
            this.descripcion_dia = pDescripcion;
            this.creado_por = pCreado_por;
            this.fecha_creacion = pFecha_creacion;
            this.modificado_por = pModificado_por;
            this.fecha_modificacion = pFecha_modificacion;
        }

        public override string ToString()
        {
            return "Dia: " + this.id_dia+
                   " Mes: " + this.id_mes+ 
                   " Descripción: " + this.descripcion_dia;
        }

        #region Properties
        public DateTime Fecha_creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        } 
        public string Creado_por
        {
            get { return creado_por; }
            set { creado_por = value; }
        }
        public string Id_dia
        {
            get { return id_dia; }
            set { id_dia = value; }
        }
        public string Id_mes
        {
            get { return id_mes; }
            set { id_mes = value; }
        }
        public string Descripcion_dia
        {
            get { return descripcion_dia; }
            set { descripcion_dia = value; }
        }
        public string Modificado_por
        {
            get { return modificado_por; }
            set { modificado_por = value; }
        }
        public DateTime Fecha_modificacion
        {
            get { return fecha_modificacion; }
            set { fecha_modificacion = value; }
        }
        #endregion
    }
}
