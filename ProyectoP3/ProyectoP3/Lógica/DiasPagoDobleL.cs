using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class DiasPagoDobleL
    {
        private double id_dia;
        private double id_mes;
        private string descripcion_dia;
        private string activo;
        private string creado_por;
        private DateTime fecha_creacion;
        private string modificado_por;
        private DateTime fecha_modificacion;

        public DiasPagoDobleL(double pId_dia, double pId_mes, string pDescripcion,string pActivo,string pCreado_por,DateTime pFecha_creacion,string pModificado_por,DateTime pFecha_modificacion)
        {
            this.id_dia=pId_dia;
            this.id_mes=pId_mes;
            this.descripcion_dia = pDescripcion;
            this.activo = pActivo;
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

        public string Activo
        {
            get { return activo; }
        }
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
        public double Id_dia
        {
            get { return id_dia; }
            set { id_dia = value; }
        }
        public double Id_mes
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
