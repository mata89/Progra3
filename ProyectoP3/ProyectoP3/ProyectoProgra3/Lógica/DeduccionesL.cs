using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    class DeduccionesL
    {
        string id_deduccion;
        string nombre_deduccion;
        double porcentaje;
        string creado_por;
        DateTime fecha_creacion;
        string modificado_por;
        DateTime fecha_modificacion;

        public DeduccionesL(string pId_deduccion,string pNombre_deduccion,double pPorcentaje,string pCreado_por,DateTime pFecha_creacion,string pModificado_por,DateTime pFecha_modificacion) 
        {
            this.id_deduccion = pId_deduccion;
            this.nombre_deduccion = pNombre_deduccion;
            this.porcentaje = pPorcentaje;
            this.creado_por = pCreado_por;
            this.fecha_creacion = pFecha_creacion;
            this.modificado_por = pModificado_por;
            this.fecha_modificacion = pFecha_modificacion;
        }
       
        public string toString() { 
            return("Código de la deducción: "+this.id_deduccion+
            "Nombre de la deducción:"+this.nombre_deduccion+
            "Porcentaje de la decucción:"+this.porcentaje);
        }

        #region Properties
        public string Id_deduccion
        {
            get { return id_deduccion; }
            set { id_deduccion = value; }
        }

        public string Nombre_deduccion
        {
            get { return nombre_deduccion; }
            set { nombre_deduccion = value; }
        }

        public double Porcentaje
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        }
        public string Creado_por
        {
            get { return creado_por; }
            set { creado_por = value; }
        }
        public DateTime Fecha_creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
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
