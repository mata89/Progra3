using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class HorarioL
    {
        private string id_horario;
        private string domingo;
        private string lunes;
        private string martes;
        private string miercoles;
        private string jueves;
        private string viernes;
        private string sabado;
        private DateTime horaEntrada;
        private DateTime horaSalida;
        private string activo;
        private string creado_por;
        private DateTime fecha_creacion;
        private string modificado_por;
        private DateTime fecha_modificacion;

        public HorarioL(string pId_horario, string pDomingo, string pLunes, string pMartes, string pMiercoles, string pJueves, string pViernes,
                         string pSabado, DateTime pHoraEntrada, DateTime pHoraSalida, string pActivo,
                         string pCreado_por, DateTime pFecha_creacion, string pModificado_por, DateTime pFecha_modificacion)
        {
            this.id_horario = pId_horario;
            this.domingo = pDomingo;
            this.lunes = pLunes;
            this.martes = pMartes;
            this.miercoles = pMiercoles;
            this.jueves = pJueves;
            this.viernes = pViernes;
            this.sabado = pSabado;
            this.horaEntrada = pHoraEntrada;
            this.horaSalida = pHoraSalida;
            this.activo = pActivo;
            this.creado_por = pCreado_por;
            this.fecha_creacion = pFecha_creacion;
            this.modificado_por = pModificado_por;
            this.fecha_modificacion = pFecha_modificacion;
        }

        public override string ToString()
        {
            return ("Código de horario: " + this.id_horario +  
                "Domingo: " + this.domingo +
                "Lunes: " + this.lunes +
                "Martes: " + this.martes +
                "Miércoles: " + this.miercoles +
                "Jueves: " + this.jueves +
                "Viernes: " + this.viernes +
                "Sábado: " + this.sabado +
                "Hora entrada: " + this.horaEntrada +
                "Hora salida: " + this.horaSalida +
                "Estado: " + this.activo 
                );
        }

        #region Properties
        public string Id_horario
        {
            get { return id_horario; }
            set { id_horario = value; }
        }
        public string Domingo
        {
            get { return domingo; }
            set { domingo = value; }
        }
        public string Lunes
        {
            get { return lunes; }
            set { lunes = value; }
        }
        public string Martes
        {
            get { return martes; }
            set { martes = value; }
        }
        public string Miercoles
        {
            get { return miercoles; }
            set { miercoles = value; }
        }
        public string Jueves
        {
            get { return jueves; }
            set { jueves = value; }
        }
        public string Viernes
        {
            get { return viernes; }
            set { viernes = value; }
        }
        public string Sabado
        {
            get { return sabado; }
            set { sabado = value; }
        }
        public DateTime HoraEntrada
        {
            get { return horaEntrada; }
            set { horaEntrada = value; }
        }
        public DateTime HoraSalida
        {
            get { return horaSalida; }
            set { horaSalida = value; }
        }
        public string Estado
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
