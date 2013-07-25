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
    class DiasPagoDobleD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public DiasPagoDobleD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }

        #region Properties
        public bool Error
        {
            get { return error; }
        }
       
        public string ErrorDescription
        {
            get { return errorDescription; }
        }
        #endregion

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
                        retorno.Add(new DiasPagoDobleL(Double.Parse(fila["id_dia"].ToString()),Double.Parse (fila["id_mes"].ToString()), fila["descripcion_dia"].ToString(), fila["activo"].ToString(), fila["creado_por"].ToString(), DateTime.Parse(fila["fecha_creacion"].ToString()), fila["modificado_por"].ToString(), DateTime.Parse(fila["fecha_modificacion"].ToString())));
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
                string sql = "insert into diasPagoDoble values(:id_dia,:id_mes,:descripcion,:activo,:creado_por,:fecha_creacion,:modificado_por,:fecha_modificacion)";
                
                OracleParameter[] parametros = new OracleParameter[8];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Int32;
                parametros[0].ParameterName = ":id_dia";
                parametros[0].Value = pDiasPagoDoble.Id_dia;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.Int32;
                parametros[1].ParameterName = ":id_mes";
                parametros[1].Value = pDiasPagoDoble.Id_mes;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":descripcion";
                parametros[2].Value = pDiasPagoDoble.Descripcion_dia;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":activo";
                parametros[3].Value = pDiasPagoDoble.Activo;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":creado_por";
                parametros[4].Value = pDiasPagoDoble.Creado_por;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.DateTime;
                parametros[5].ParameterName = ":fecha_creacion";
                parametros[5].Value = DateTime.Now;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":modificado_por";
                parametros[6].Value = pDiasPagoDoble.Modificado_por;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.DateTime;
                parametros[7].ParameterName = ":fecha_modificacion";
                parametros[7].Value = DateTime.Now;

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
                string sql = "delete from diasPagoDoble where id_dia= :id_dia and id_mes= :id_mes";

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
                string sql = "update diasPagoDoble set id_dia=:id_dia,id_mes=:id_mes, descripcion_dia=:descripcion_dia," +
                             "activo=:activo,modificado_por=:modificado_por,fecha_modificacion=:fecha_modificacion" +
                             " where id_dia=:diaOriginal and id_mes=:mesOriginal";

                OracleParameter[] parametros = new OracleParameter[8];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Int32;
                parametros[0].ParameterName = ":id_dia";
                parametros[0].Value = pDiaEditado.Id_dia;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.Int32;
                parametros[1].ParameterName = ":id_mes";
                parametros[1].Value = pDiaEditado.Id_mes;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":descripcion_dia";
                parametros[2].Value = pDiaEditado.Descripcion_dia;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":activo";
                parametros[3].Value = pDiaEditado.Activo;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":modificado_por";
                parametros[4].Value = pDiaEditado.Modificado_por;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.DateTime;
                parametros[5].ParameterName = ":fecha_modificacion";
                parametros[5].Value = DateTime.Now;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.Int32;
                parametros[6].ParameterName = ":diaOriginal";
                parametros[6].Value = pDiaOriginal.Id_dia;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.Int32;
                parametros[7].ParameterName = ":mesOriginal";
                parametros[7].Value = pDiaOriginal.Id_mes;

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
