using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class UnificacionL
    {

        private string id_unificacion;
        private string id_pago;
        private string id_empleado;
        private DateTime fechaInicio;
        private DateTime fechaFin;


        private string horasExtrasAprobadas;
        private string horasExtrasAprobadasPor;
        private string notasDeAprobacion;
        private double horasExtras;
        private double horasDobles;
        private double horasRegulares;

        private double totalHorasRegulares;
        private double totalHorasExtras;
        private double totalHorasDobles;
        private double totalBruto;
        private double totalDeducciones;
        private double totalNeto;


        private string activo;
        private string creado_por;
        private DateTime fecha_creacion;
        private string modificado_por;
        private DateTime fecha_modificacion;

        #region Properties
        public string Id_unificacion
        {
            get { return id_unificacion; }
            set { id_unificacion = value; }
        }
     

        public string Id_pago
        {
            get { return id_pago; }
            set { id_pago = value; }
        }

        public string Id_empleado
        {
            get { return id_empleado; }
            set { id_empleado = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public string HorasExtrasAprobadas
        {
            get { return horasExtrasAprobadas; }
        }
      
        public string HorasExtrasAprobadasPor
        {
            get { return horasExtrasAprobadasPor; }
        }

        public string NotasDeAprobacion
        {
            get { return notasDeAprobacion; }
        }
       
        public double HorasExtras
        {
            get { return horasExtras; }
        }

        public double HorasDobles
        {
            get { return horasDobles; }
        }
   
        public double HorasRegulares
        {
            get { return horasRegulares; }
        }

        public double TotalHorasRegulares
        {
            get { return totalHorasRegulares; }
        }
       
        public double TotalHorasExtras
        {
            get { return totalHorasExtras; }
        }
      
        public double TotalHorasDobles
        {
            get { return totalHorasDobles; }
        }
 
        public double TotalBruto
        {
            get { return totalBruto; }
        }
      
        public double TotalDeducciones
        {
            get { return totalDeducciones; }
        }
       
        public double TotalNeto
        {
            get { return totalNeto; }
        }

        public string Activo
        {
            get { return activo; }
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
        // constructor

        public UnificacionL(string pId_unificacion, string pId_pago, string pId_empleado, DateTime pFechaInicio, DateTime pFechaFin, string pHorasExtrasAprobadas, string pHorasExtrasAprobadasPor, string pNotasDeAprobacion, double pHorasExtras, double pHorasDobles, double pHorasRegulares, double pTotalHorasRegulares,double pTotalHorasDobles,double pTotalBruto,double pTotalHorasExtras,double pTotalNeto,double pTotalDeducciones, string pActivo, string pCreado_por, DateTime pFecha_creacion, string pModificado_por, DateTime pFecha_modificacion)
        {
            this.id_unificacion = pId_unificacion;
            this.id_pago = pId_pago;
            this.id_empleado= pId_empleado;
            this.fechaInicio = pFechaInicio;
            this.fechaFin = pFechaFin;
            this.horasExtrasAprobadas = pHorasExtrasAprobadas;
            this.horasExtrasAprobadasPor = pHorasExtrasAprobadasPor;
            this.notasDeAprobacion = pNotasDeAprobacion;
            this.horasExtras= pHorasExtras;
            this.horasRegulares= pHorasRegulares;
            this.horasDobles = pHorasDobles;
            this.totalBruto = pTotalBruto;
            this.totalNeto = pTotalNeto;
            this.totalDeducciones = pTotalDeducciones;
            this.activo = pActivo;
            this.creado_por = pCreado_por;
            this.fecha_creacion = pFecha_creacion;
            this.modificado_por = pModificado_por;
            this.fecha_modificacion = pFecha_modificacion;
        }

        // toString
        public string toString() {
            return (
                "Id_Unificación:"+ this.id_unificacion + "\n"+
                "Id_pago:"+ this.id_pago + "\n"+
                "Id_Empleado"+ this.id_empleado + "\n"+
                "Fecha_Inicio"+this.fechaInicio + "\n"+
                "Fecha_Fin:"+this.fechaFin+ "\n"+
                "HorasExtrasAprobadas:"+ this.horasExtrasAprobadas + "\n"+
                "HorasExtrasAprobadasPor:" + this.horasExtrasAprobadasPor+ "\n"+
                "Notas de aprobación:" +this.notasDeAprobacion+ "\n" +
                "Horas_Extras:"+this.horasExtras+ "\n" +
                "Horas_Dobles:"+this.horasDobles+"\n"+
                "Horas_Regulares:"+this.horasRegulares+"\n"+
                "Total_Bruto:"+this.totalBruto+"\n"+
                "Total_Neto:"+this.totalNeto+"\n"+
                "Total_Deducciones:"+this.totalDeducciones+"\n"+
                "Activo:" + "Creado_por:" +this.creado_por+ "\n" +
                "Fecha_creación:" +this.fecha_creacion+ "\n" +
                "Modificado_por:" +this.modificado_por+ "\n" +
                "Fecha_Modificación:"+this.fecha_modificacion+"\n");
        }


    }
}
