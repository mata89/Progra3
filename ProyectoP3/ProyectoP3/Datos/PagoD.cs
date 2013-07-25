using GUI;
using Lógica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class PagoD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public PagoD(AccesoDatosOracle pCnx)
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

        public List<PagoL> obtenerPagos()
        {
            List<PagoL> retorno = new List<PagoL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from pago");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(new PagoL(fila["id_pago"].ToString(),DateTime.Parse(fila["fechacorte"].ToString()),fila["descripcion"].ToString(),double.Parse(fila["totalPagoNeto"].ToString()),fila["anulado"].ToString(),fila["creado_por"].ToString(),DateTime.Parse(fila["fecha_creacion"].ToString()), fila["modificado_por"].ToString(), DateTime.Parse(fila["fecha_modificacion"].ToString())));
                    }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error obteniendo pagos: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo pagos: " + e.Message;
            }
            return retorno;
        }

        public void agregarPago(PagoL pPago)
        {
            try
            {
                string sql = "insert into pago values(:id_pago,:fechaCorte,:descripcion,:totalPagoNeto,:anulado,:creado_por,:fecha_creacion,:modificado_por,:fecha_modificacion)";
                
                OracleParameter[] parametros = new OracleParameter[9];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_pago";
                parametros[0].Value = pPago.Id_pago;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.Timestamp;
                parametros[1].ParameterName = ":fechaCorte";
                parametros[1].Value = pPago.FechaCorte;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":descripcion";
                parametros[2].Value = pPago.Descripcion;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.Double;
                parametros[3].ParameterName = ":totalPagoNeto";
                parametros[3].Value = pPago.TotalPagoNeto;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":anulado";
                parametros[4].Value = pPago.Anulado;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":creado_por";
                parametros[5].Value = pPago.Creado_por;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.DateTime;
                parametros[6].ParameterName = ":fecha_creacion";
                parametros[6].Value = DateTime.Now;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":modificado_por";
                parametros[7].Value = pPago.Modificado_por;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.DateTime;
                parametros[8].ParameterName = ":fecha_modificacion";
                parametros[8].Value = DateTime.Now;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch(Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando pago:" + e.Message;    
            }
        }

        public void borrarPago(PagoL pPago)
        {
            try
            {
                string sql = "delete from pago where id_pago= :id_pago";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Int32;
                parametros[0].ParameterName = ":id_pago";
                parametros[0].Value = pPago.Id_pago;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando pago: " + e.Message;
            }
        }

        public void editarPago(PagoL pPagoEditado, PagoL pPagoOriginal)
        {
            try
            {
                string sql = "update pago " +
                             "set (id_pago=:id_pago,fechaCorte=:fechaCorte,descripcion=:descripcion,totalPagoNeto=:,anulado=:anulado,totalPagoNeto,modificado_por=:modificado_por,fecha_modificacion=:fecha_modificacion" +
                             " where id_pago = :id_pagoOriginal";

                OracleParameter[] parametros = new OracleParameter[7];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_pago";
                parametros[0].Value = pPagoEditado.Id_pago;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.DateTime;
                parametros[1].ParameterName = ":fechaCorte";
                parametros[1].Value = pPagoEditado.FechaCorte;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":descripcion";
                parametros[2].Value = pPagoEditado.Descripcion;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.Double;
                parametros[3].ParameterName = ":totalPagoNeto";
                parametros[3].Value = pPagoEditado.TotalPagoNeto;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":anulado";
                parametros[4].Value = pPagoEditado.Anulado;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":modificado_por";
                parametros[5].Value = pPagoEditado.Modificado_por;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.Timestamp;
                parametros[6].ParameterName = ":fecha_modificacion";
                parametros[6].Value = pPagoEditado.Fecha_modificacion;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":id_pagoOriginal";
                parametros[7].Value = pPagoOriginal.Id_pago;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error editando dia de pago doble: " + e.Message;
            }
        }
    }
}
