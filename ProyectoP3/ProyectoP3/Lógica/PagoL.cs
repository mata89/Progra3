using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class PagoL
    {
        private string id_pago;
        private DateTime fechaCorte;
        private string descripcion;
        private double totalPagoNeto;
        private string anulado;
        private string creado_por;
        private DateTime fecha_creacion;
        private string modificado_por;
        private DateTime fecha_modificacion;

        public PagoL(string pId_pago, DateTime pFecha_corte, string pDescripcion, double pTotalPagar,string pAnulado,string pCreado_por, DateTime pFecha_creacion, string pModificado_por, DateTime pFecha_modificacion)
        {
            this.id_pago = pId_pago;
            this.fechaCorte = pFecha_corte;
            this.descripcion = pDescripcion;
            this.totalPagoNeto = pTotalPagar;
            this.anulado = pAnulado;
            this.creado_por = pCreado_por;
            this.fecha_creacion = pFecha_creacion;
            this.modificado_por=pModificado_por;
            this.fecha_modificacion=pFecha_modificacion;
        }
        
        public string toString() { 
            return("Código de pago: "+this.id_pago+
                   "Descripción: "+this.descripcion+
                   "Fecha de corte: "+this.fechaCorte+
                   "Total a pagar: "+this.totalPagoNeto);
        }

        # region Properties


        public string Anulado
        {
            get { return anulado; }
        }
        public double TotalPagoNeto
        {
            get { return totalPagoNeto; }
            set { totalPagoNeto = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime FechaCorte
        {
            get { return fechaCorte; }
            set { fechaCorte = value; }
        }

        public string Id_pago
        {
            get { return id_pago; }
            set { id_pago = value; }
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
