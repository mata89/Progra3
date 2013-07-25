using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
  public  class DeduccionesL
    {
        private string id_deduccion;
        private string nombre_deduccion;
        private double porcentaje;
        private string activo;
        private string creado_por;
        private DateTime fecha_creacion;
        private string modificado_por;
        private DateTime fecha_modificacion;

        public DeduccionesL(string pId_deduccion,string pNombre_deduccion,double pPorcentaje,string pActivo,string pCreado_por,DateTime pFecha_creacion,string pModificado_por,DateTime pFecha_modificacion) 
        {
            this.id_deduccion = pId_deduccion;
            this.nombre_deduccion = pNombre_deduccion;
            this.porcentaje = pPorcentaje;
            this.activo = pActivo;
            this.creado_por = pCreado_por;
            this.fecha_creacion = pFecha_creacion;
            this.modificado_por = pModificado_por;
            this.fecha_modificacion = pFecha_modificacion;
        }
       
        public string toString() { 
            return("Código de la deducción: "+this.id_deduccion+
            "Nombre de la deducción:"+this.nombre_deduccion+
            "Porcentaje de la deducción:"+this.porcentaje);
        }

        #region Properties


        public string Activo
        {
            get { return activo; }
        }
        public string Id_deduccion
        {
            get { return id_deduccion; }
        }

        public string Nombre_deduccion
        {
            get { return nombre_deduccion; }
        }

        public double Porcentaje
        {
            get { return porcentaje; }
        }
        public string Creado_por
        {
            get { return creado_por; }
        }
        public DateTime Fecha_creacion
        {
            get { return fecha_creacion; }
        }

        public string Modificado_por
        {
            get { return modificado_por; }
        }

        public DateTime Fecha_modificacion
        {
            get { return fecha_modificacion; }
        }
        #endregion
    }
}
