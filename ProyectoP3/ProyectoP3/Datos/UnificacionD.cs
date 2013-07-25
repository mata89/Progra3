using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using Lógica;

namespace Datos
{
    class UnificacionD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public UnificacionD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }

        public bool Error
        {
            get { return error; }
        }
       
        public string ErrorDescription
        {
            get { return errorDescription; }
        }

        public List<UnificacionL> obtenerUnificaciones()
        {
            List<UnificacionL> retorno = new List<UnificacionL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from unificacion");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(new UnificacionL(fila["id_unificacion"].ToString(), fila["id_pago"].ToString(),
                                    fila["id_empleado"].ToString(),  DateTime.Parse(fila["fechaInicio"].ToString()),  DateTime.Parse(fila["fechaFin"].ToString()),
                                    fila["horasExtrasAprobadas"].ToString(), fila["horasExtrasAprobadasPor"].ToString(), fila["notasDeAprobacion"].ToString(), Convert.ToInt32(fila["horasExtras"].ToString()),
                                    Convert.ToInt32(fila["horasDobles"].ToString()), Convert.ToInt32(fila["horasRegulares"].ToString()), Convert.ToInt32(fila["totalHorasRegulares"].ToString()), Convert.ToInt32(fila["totalHorasExtras"].ToString()),
                                    Convert.ToInt32(fila["totalHorasDobles"].ToString()), Convert.ToInt32(fila["totalBruto"].ToString()), Convert.ToInt32(fila["totalDeducciones"].ToString()), Convert.ToInt32(fila["totalNeto"].ToString()),
                                    fila["activo"].ToString(), fila["creado_por"].ToString(), DateTime.Parse(fila["fecha_creacion"].ToString()), fila["modificado_por"].ToString(), DateTime.Parse(fila["fecha_modificacion"].ToString())));
                    }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error obteniendo unificaciones: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo unificaciones: " + e.Message;
            }
            return retorno;
        }

        public void agregarUnificacion(UnificacionL pUnificacionL)
        {
            try
            {
                string sql = "insert into unificacion values(:id_unificacion,:id_pago,:id_empleado,:fechaInicio, :fechaFin, :horasExtrasAprobadas, :horasExtrasAprobadasPor, :notasDeAprobacion,:horasExtras, :horasDobles,:horasRegulares,:totalHorasRegulares,:totalHorasDobles,:totalBruto,:totalHorasExtras,:totalNeto,:totalDeducciones,:activo,:creado_por,:fecha_creacion, :modificado_por,:fecha_modificacion)";
                
                OracleParameter[] parametros = new OracleParameter[22];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_unificacion";
                parametros[0].Value = pUnificacionL.Id_unificacion;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":id_pago";
                parametros[1].Value = pUnificacionL.Id_pago;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":id_empleado";
                parametros[2].Value = pUnificacionL.Id_empleado;
                
                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.DateTime;
                parametros[3].ParameterName = ":fechaInicio";
                parametros[3].Value = DateTime.Now;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.DateTime;
                parametros[4].ParameterName = ":fechaFin";
                parametros[4].Value = DateTime.Now;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":horasExtrasAprobadas";
                parametros[5].Value = pUnificacionL.HorasExtrasAprobadas;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":horasExtrasAprobadasPor";
                parametros[6].Value = pUnificacionL.HorasExtrasAprobadasPor;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":notasDeAprobacion";
                parametros[7].Value = pUnificacionL.NotasDeAprobacion;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.Double;
                parametros[8].ParameterName = ":horasExtras";
                parametros[8].Value = pUnificacionL.HorasExtras;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.Double;
                parametros[9].ParameterName = ":horasDobles";
                parametros[9].Value = pUnificacionL.HorasDobles;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.Double;
                parametros[10].ParameterName = ":horasRegulares";
                parametros[10].Value = pUnificacionL.HorasRegulares;

                parametros[11] = new OracleParameter();
                parametros[11].OracleType = OracleType.Double;
                parametros[11].ParameterName = ":totalHorasRegulares";
                parametros[11].Value = pUnificacionL.TotalHorasRegulares;

                parametros[12] = new OracleParameter();
                parametros[12].OracleType = OracleType.Double;
                parametros[12].ParameterName = ":totalHorasDobles";
                parametros[12].Value = pUnificacionL.TotalHorasDobles;

                parametros[13] = new OracleParameter();
                parametros[13].OracleType = OracleType.Double;
                parametros[13].ParameterName = ":totalBruto";
                parametros[13].Value = pUnificacionL.TotalBruto;

                parametros[14] = new OracleParameter();
                parametros[14].OracleType = OracleType.Double;
                parametros[14].ParameterName = ":totalHorasExtras";
                parametros[14].Value = pUnificacionL.TotalHorasExtras;

                parametros[15] = new OracleParameter();
                parametros[15].OracleType = OracleType.Double;
                parametros[15].ParameterName = ":totalNeto";
                parametros[15].Value = pUnificacionL.TotalNeto;

                parametros[16] = new OracleParameter();
                parametros[16].OracleType = OracleType.Double;
                parametros[16].ParameterName = ":totalDeducciones";
                parametros[16].Value = pUnificacionL.TotalDeducciones;

                parametros[17] = new OracleParameter();
                parametros[17].OracleType = OracleType.VarChar;
                parametros[17].ParameterName = ":activo";
                parametros[17].Value = pUnificacionL.Activo;


                parametros[18] = new OracleParameter();
                parametros[18].OracleType = OracleType.VarChar;
                parametros[18].ParameterName = ":creado_por";
                parametros[18].Value = pUnificacionL.Creado_por;

                parametros[19] = new OracleParameter();
                parametros[19].OracleType = OracleType.DateTime;
                parametros[19].ParameterName = ":fecha_creacion";
                parametros[19].Value = DateTime.Now;

                parametros[20] = new OracleParameter();
                parametros[20].OracleType = OracleType.DateTime;
                parametros[20].ParameterName = ":modificado_por";
                parametros[20].Value = pUnificacionL.Modificado_por;

                parametros[21] = new OracleParameter();
                parametros[21].OracleType = OracleType.DateTime;
                parametros[21].ParameterName = ":fecha_modificacion";
                parametros[21].Value = pUnificacionL.Fecha_modificacion;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch(Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando unificación:" + e.Message;    
            }
        }

        public void borrarUnificacion(UnificacionL pUnificacion)
        {
            try
            {
                string sql = "delete from unificacion where id_unificacion= :id_unificacion";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_unificacion";
                parametros[0].Value = pUnificacion.Id_unificacion;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando unificación: " + e.Message;
            }
        }

        public void editarUnificacion(UnificacionL pUnificacionEditado, UnificacionL pUnificacionOriginal)
        {
            try
            {
                string sql = "update unificacion " +
                             "set id_unificacion=:id_unificacion,id_pago=:id_pago,id_empleado=:id_empleado,fechaInicio= :fechaInicio, fechaFin= :fechaFin, horasExtrasArpobadas=:horasExtrasAprobadas,horasExtrasAprobadaspor= :horasExtrasAprobadasPor, :notasDeAprobacion,horasExtras=:horasExtras, horasDobles=:horasDobles,horasRegulares=:horasRegulares,totalHorasRegulares=:totalHorasRegulares,totalHorasDobles=:totalHorasDobles,totalBruto=:totalBruto,TotalHorasExtras=:totalHorasExtras,totalNeto=:totalNeto,totalDeducciones=:totalDeducciones,:activo,creado_por=:creado_por,fecha_creacion=:fecha_creacion, modificado_por=:modificado_por,fecha_modificacion=:fecha_modificacion" +
                             " where id_unificacion=:id_unificacionOriginal";

                OracleParameter[] parametros = new OracleParameter[23];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_unificacion";
                parametros[0].Value = pUnificacionEditado.Id_unificacion;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":id_pago";
                parametros[1].Value = pUnificacionEditado.Id_pago;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":id_empleado";
                parametros[2].Value = pUnificacionEditado.Id_empleado;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.DateTime;
                parametros[3].ParameterName = ":fechaInicio";
                parametros[3].Value = DateTime.Now;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.DateTime;
                parametros[4].ParameterName = ":fechaFin";
                parametros[4].Value = DateTime.Now;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":horasExtrasAprobadas";
                parametros[5].Value = pUnificacionEditado.HorasExtrasAprobadas;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":horasExtrasAprobadasPor";
                parametros[6].Value = pUnificacionEditado.HorasExtrasAprobadasPor;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":notasDeAprobacion";
                parametros[7].Value = pUnificacionEditado.NotasDeAprobacion;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.Double;
                parametros[8].ParameterName = ":horasExtras";
                parametros[8].Value = pUnificacionEditado.HorasExtras;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.Double;
                parametros[9].ParameterName = ":horasDobles";
                parametros[9].Value = pUnificacionEditado.HorasDobles;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.Double;
                parametros[10].ParameterName = ":horasRegulares";
                parametros[10].Value = pUnificacionEditado.HorasRegulares;

                parametros[11] = new OracleParameter();
                parametros[11].OracleType = OracleType.Double;
                parametros[11].ParameterName = ":totalHorasRegulares";
                parametros[11].Value = pUnificacionEditado.TotalHorasRegulares;

                parametros[12] = new OracleParameter();
                parametros[12].OracleType = OracleType.Double;
                parametros[12].ParameterName = ":totalHorasDobles";
                parametros[12].Value = pUnificacionEditado.TotalHorasDobles;

                parametros[13] = new OracleParameter();
                parametros[13].OracleType = OracleType.Double;
                parametros[13].ParameterName = ":totalBruto";
                parametros[13].Value = pUnificacionEditado.TotalBruto;

                parametros[14] = new OracleParameter();
                parametros[14].OracleType = OracleType.Double;
                parametros[14].ParameterName = ":totalHorasExtras";
                parametros[14].Value = pUnificacionEditado.TotalHorasExtras;

                parametros[15] = new OracleParameter();
                parametros[15].OracleType = OracleType.Double;
                parametros[15].ParameterName = ":totalNeto";
                parametros[15].Value = pUnificacionEditado.TotalNeto;

                parametros[16] = new OracleParameter();
                parametros[16].OracleType = OracleType.Double;
                parametros[16].ParameterName = ":totalDeducciones";
                parametros[16].Value = pUnificacionEditado.TotalDeducciones;

                parametros[17] = new OracleParameter();
                parametros[17].OracleType = OracleType.VarChar;
                parametros[17].ParameterName = ":activo";
                parametros[17].Value = pUnificacionEditado.Activo;


                parametros[18] = new OracleParameter();
                parametros[18].OracleType = OracleType.VarChar;
                parametros[18].ParameterName = ":creado_por";
                parametros[18].Value = pUnificacionEditado.Creado_por;

                parametros[19] = new OracleParameter();
                parametros[19].OracleType = OracleType.DateTime;
                parametros[19].ParameterName = ":fecha_creacion";
                parametros[19].Value = DateTime.Now;

                parametros[20] = new OracleParameter();
                parametros[20].OracleType = OracleType.DateTime;
                parametros[20].ParameterName = ":modificado_por";
                parametros[20].Value = pUnificacionEditado.Modificado_por;

                parametros[21] = new OracleParameter();
                parametros[21].OracleType = OracleType.DateTime;
                parametros[21].ParameterName = ":fecha_modificacion";
                parametros[21].Value = pUnificacionEditado.Fecha_modificacion;

                parametros[22] = new OracleParameter();
                parametros[22].OracleType = OracleType.VarChar;
                parametros[22].ParameterName = ":id_unificacionOriginal";
                parametros[22].Value = pUnificacionOriginal.Id_empleado;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error editando unificación: " + e.Message;
            }
        }

    }
}
