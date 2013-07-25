using Datos;
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
    class DiasPagoDobleD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public DiasPagoDobleD(AccesoDatosOracle pCnx)
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

        public List<DiasPagoDobleL> obtenerDiasPagoDoble()
        {
            List<DiasPagoDobleL> retorno = new List<DiasPagoDobleL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from diasPagoDoble");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(new DiasPagoDobleL(fila["id_dia"].ToString(), fila["id_mes"].ToString(), fila["descripcion"].ToString(), fila["creado_por"].ToString(),DateTime.Parse( fila["fecha_creacion"].ToString()), fila["modificado_por"].ToString(),DateTime.Parse(fila["fecha_modificacion"].ToString())));
                    }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error obteniendo dias de pago doble: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo dias de pago doble: " + e.Message;
            }
            return retorno;
        }

        public void agregarDiasPagoDoble(DiasPagoDobleL pDiasPagoDoble)
        {
            try
            {
                string sql = "insert into diasPagoDoble(id_dia,id_mes,descripcion,creado_por,fecha_creacion,modificado_por,fecha_modificacion) " +
                             "values(:id_dia,:id_mes,:descripcion,:creado_por,:fecha_creacion,:modificado_por,:fecha_modificacion)";
                
                OracleParameter[] parametros = new OracleParameter[7];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_dia";
                parametros[0].Value = pDiasPagoDoble.Id_dia;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":id_mes";
                parametros[1].Value = pDiasPagoDoble.Id_mes;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":descripcion";
                parametros[2].Value = pDiasPagoDoble.Descripcion_dia;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":creado_por";
                parametros[3].Value = pDiasPagoDoble.Creado_por;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.Timestamp;
                parametros[4].ParameterName = ":fecha_creacion";
                parametros[4].Value = pDiasPagoDoble.Fecha_creacion;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":modificado_por";
                parametros[5].Value = pDiasPagoDoble.Modificado_por;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.Timestamp;
                parametros[6].ParameterName = ":fecha_modificacion";
                parametros[6].Value = pDiasPagoDoble.Fecha_modificacion;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch(Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando dia de pago doble:" + e.Message;    
            }
        }

        public void borrarDiasPagoDoble(DiasPagoDobleL pDiasPagoDoble)
        {
            try
            {
                string sql = "delete from diasPagoDoble where dia= :id_dia and mes= :id_mes";

                OracleParameter[] parametros = new OracleParameter[2];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Int32;
                parametros[0].ParameterName = ":id_dia";
                parametros[0].Value = pDiasPagoDoble.Id_dia;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.Int32;
                parametros[1].ParameterName = ":id_mes";
                parametros[1].Value = pDiasPagoDoble.Id_mes;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando dia de pago doble: " + e.Message;
            }
        }

        public void editarDiasPagoDoble(DiasPagoDobleL pDiaEditado, DiasPagoDobleL pDiaOriginal)
        {
            try
            {
                string sql = "update diasPagoDoble " +
                             "set id_dia=:diaEditado,id_mes=:mesEditado, descripcion = :descripcionEditada " +
                             ",modificado_por=:modificado_por,fecha_modificacion=:fecha_modificacion " +
                             "where id_dia = :diaOriginal and id_mes=:mesOriginal";

                OracleParameter[] parametros = new OracleParameter[7];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":diaEditado";
                parametros[0].Value = pDiaEditado.Id_dia;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":mesEditado";
                parametros[1].Value = pDiaEditado.Id_mes;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":descripcionEditada";
                parametros[2].Value = pDiaEditado.Descripcion_dia;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":modificado_por";
                parametros[3].Value = pDiaEditado.Modificado_por;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.Timestamp;
                parametros[4].ParameterName = ":fecha_modificacion";
                parametros[4].Value = pDiaEditado.Fecha_modificacion;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":diaOriginal";
                parametros[5].Value = pDiaOriginal.Id_dia;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":mesOriginal";
                parametros[6].Value = pDiaOriginal.Id_mes;


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
