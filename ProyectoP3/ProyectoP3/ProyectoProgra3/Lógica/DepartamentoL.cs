using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
   public class DepartamentoL
    {
        string id_departamento;
        string nombre_departamento;
        string activo;
        string creado_por;
        string fecha_creacion;
        string modificado_por;
        string fecha_modificacion;

        public DepartamentoL(string pId_departamento, string pNombre_departamento,string pActivo, string pCreado_por, string pFecha_creacion, string pModificado_por, string pFecha_modificacion)
        {
            this.id_departamento = pId_departamento;
            this.nombre_departamento=pNombre_departamento;
            this.activo = pActivo;
            this.creado_por = pCreado_por;
            this.fecha_creacion = pFecha_creacion;
            this.modificado_por = pModificado_por;
            this.fecha_modificacion = pFecha_modificacion;
        }

        public string toString() { 
            return ("Código de departamento: "+this.id_departamento+
                " Nombre de departamento: "+this.nombre_departamento
                );
        }

        #region Properties
            public string Nombre_departamento
            {
                get { return nombre_departamento; }
                set { nombre_departamento = value; }
            }
            public string Id_departamento
            {
                get { return id_departamento; }
                set { id_departamento = value; }
            }
            public string Creado_por
            {
                get { return creado_por; }
                set { creado_por = value; }
            }
            public string Fecha_creacion
            {
                get { return fecha_creacion; }
                set { fecha_creacion = value; }
            }

            public string Modificado_por
            {
                get { return modificado_por; }
                set { modificado_por = value; }
            }

            public string Fecha_modificacion
            {
                get { return fecha_modificacion; }
                set { fecha_modificacion = value; }
            }
            public string Activo
            {
                get { return activo; }
                set { activo = value; }
            }
    #endregion
    }
}
