﻿using GUI;
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
    class DeduccionesD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public DeduccionesD(AccesoDatosOracle pCnx)
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

        public List<DeduccionesL> obtenerDeducciones()
        {
            List<DeduccionesL> retorno = new List<DeduccionesL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from deduccion");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(new DeduccionesL(fila["id_deduccion"].ToString(), fila["nombre_deduccion"].ToString(),Double.Parse(fila["porcentaje"].ToString()),fila["activo"].ToString(),fila["creado_por"].ToString(), DateTime.Parse(fila["fecha_creacion"].ToString()), fila["modificado_por"].ToString(), DateTime.Parse(fila["fecha_modificacion"].ToString())));
                    }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error obteniendo deducciones: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo deducciones: " + e.Message;
            }
            return retorno;
        }

        public void agregarDeduccion(DeduccionesL pDeducciones)
        {
            try
            {
                string sql = "insert into deduccion values(:id_deduccion,:nombre_deduccion,:porcentaje,:activo,:creado_por,:fecha_creacion,:modificado_por,:fecha_modificacion)";
                
                OracleParameter[] parametros = new OracleParameter[8];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_deduccion";
                parametros[0].Value = pDeducciones.Id_deduccion;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":nombre_deduccion";
                parametros[1].Value = pDeducciones.Nombre_deduccion;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.Double;
                parametros[2].ParameterName = ":porcentaje";
                parametros[2].Value = pDeducciones.Porcentaje;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":creado_por";
                parametros[3].Value = pDeducciones.Creado_por;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.DateTime;
                parametros[4].ParameterName = ":fecha_creacion";
                parametros[4].Value = DateTime.Now;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":modificado_por";
                parametros[5].Value = pDeducciones.Modificado_por;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.DateTime;
                parametros[6].ParameterName = ":fecha_modificacion";
                parametros[6].Value = DateTime.Now;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":activo";
                parametros[7].Value = pDeducciones.Activo;

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

        public void borrarDeduccion(DeduccionesL pDeduccion)
        {
            try
            {
                string sql = "delete from deduccion where id_deduccion=:id_deduccion";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_deduccion";
                parametros[0].Value = pDeduccion.Id_deduccion;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando deducción: " + e.Message;
            }
        }

        public void editarDeduccion(DeduccionesL pDeduccionEditada, DeduccionesL pDeduccionOriginal)
        {
            try
            {
                string sql = "update deduccion set id_deduccion=:id_deduccion,nombre_deduccion=:nombre_deduccion,porcentaje=:porcentaje,activo=:activo,modificado_por=:modificado_por,fecha_modificacion=:fecha_modificacion" +
                             " where id_deduccion=:id_deduccionOriginal";

                OracleParameter[] parametros = new OracleParameter[7];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_deduccion";
                parametros[0].Value = pDeduccionEditada.Id_deduccion;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":nombre_deduccion";
                parametros[1].Value = pDeduccionEditada.Nombre_deduccion;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.Double;
                parametros[2].ParameterName = ":porcentaje";
                parametros[2].Value = pDeduccionEditada.Porcentaje;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":activo";
                parametros[3].Value = pDeduccionEditada.Activo;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":modificado_por";
                parametros[4].Value = pDeduccionEditada.Modificado_por;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.DateTime;
                parametros[5].ParameterName = ":fecha_modificacion";
                parametros[5].Value = DateTime.Now;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":id_deduccionOriginal";
                parametros[6].Value = pDeduccionOriginal.Id_deduccion;

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
