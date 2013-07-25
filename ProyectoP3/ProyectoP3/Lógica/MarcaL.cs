using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class MarcaL
    {
        private string id_marca;
        private string id_empleado;
        private string id_unificacion;
        private string tipoMarca;
        private DateTime fechaHora_marca;
        private string estado;
        private string creado_por;
        private DateTime fecha_creacion;
        private string modificado_por;
        private DateTime fecha_modificacion;

        public MarcaL(string pId_marca, string pId_empleado, string pId_unificacion, string pTipoMarca, DateTime pFechaHora_marca,string pEstado,
                         string pCreado_por, DateTime pFecha_creacion, string pModificado_por, DateTime pFecha_modificacion)
        {
            this.id_marca = pId_marca;
            this.id_empleado = pId_empleado;
            this.id_unificacion = pId_unificacion;
            this.tipoMarca = pTipoMarca;
            this.fechaHora_marca = pFechaHora_marca;
            this.estado = pEstado;
            this.creado_por = pCreado_por;
            this.fecha_creacion = pFecha_creacion;
            this.modificado_por = pModificado_por;
            this.fecha_modificacion = pFecha_modificacion;
        }

        public override string ToString()
        {
            return ("Código de la marca: " + this.id_marca +
                "Código de empleado: " + this.id_empleado +
                "Código de unificacion: " + this.id_unificacion +
                "Tipo de marca: " + this.tipoMarca +
                "Fecha y hora: " + this.fechaHora_marca +
                "Estado: " + this.estado 
                );
        }

        #region Properties
        public string Id_marca
        {
            get { return id_marca; }
        }
        public string Id_empleado
        {
            get { return id_empleado; }
        }
        public string Id_unificacion
        {
            get { return id_unificacion; }
        }
        public string TipoMarca
        {
            get { return tipoMarca; }
        }
        public DateTime FechaHora
        {
            get { return fechaHora_marca; }
        }
        public string Estado
        {
            get { return estado; }
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
