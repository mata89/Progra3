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
    class HorarioD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public HorarioD(AccesoDatosOracle pCnx)
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

        public List<HorarioL> obtenerHorarios()
        {
            List<HorarioL> retorno = new List<HorarioL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from horario_empresa");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(new HorarioL(fila["id_horario"].ToString(), fila["domingo"].ToString(), fila["lunes"].ToString(),
                                    fila["martes"].ToString(), fila["miercoles"].ToString(), fila["jueves"].ToString(),
                                    fila["viernes"].ToString(), fila["sabado"].ToString(), DateTime.Parse(fila["horaentrada"].ToString()), DateTime.Parse(fila["horasalida"].ToString()), fila["activo"].ToString(),
                                    fila["creado_por"].ToString(), DateTime.Parse(fila["fecha_creacion"].ToString()), 
                                    fila["modificado_por"].ToString(), DateTime.Parse(fila["fecha_modificacion"].ToString())));
                    }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error obteniendo el horario: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo el horario: " + e.Message;
            }
            return retorno;
        }

        public void agregarHorario(HorarioL pHorario)
        {
            try
            {
                string sql = "insert into horario_empresa values(:id_horario,:domingo,:lunes,:martes,:miercoles,:jueves,:viernes,:sabado,:hora_entrada,:hora_salida,:activo,:creado_por,:fecha_creacion,:modificado_por,:fecha_modificacion)";
                
                OracleParameter[] parametros = new OracleParameter[15];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_horario";
                parametros[0].Value = pHorario.Id_horario;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":domingo";
                parametros[1].Value = pHorario.Domingo;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":lunes";
                parametros[2].Value = pHorario.Lunes;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":martes";
                parametros[3].Value = pHorario.Martes;
                
                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":miercoles";
                parametros[4].Value = pHorario.Miercoles;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":jueves";
                parametros[5].Value = pHorario.Jueves;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":viernes";
                parametros[6].Value = pHorario.Viernes;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":sabado";
                parametros[7].Value = pHorario.Sabado;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.DateTime;
                parametros[8].ParameterName = ":hora_entrada";
                parametros[8].Value = pHorario.HoraEntrada;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.DateTime;
                parametros[9].ParameterName = ":hora_salida";
                parametros[9].Value = pHorario.HoraSalida;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.VarChar;
                parametros[10].ParameterName = ":activo";
                parametros[10].Value = pHorario.Estado;

                parametros[11] = new OracleParameter();
                parametros[11].OracleType = OracleType.VarChar;
                parametros[11].ParameterName = ":creado_por";
                parametros[11].Value = pHorario.Creado_por;

                parametros[12] = new OracleParameter();
                parametros[12].OracleType = OracleType.DateTime;
                parametros[12].ParameterName = ":fecha_creacion";
                parametros[12].Value =DateTime.Now;

                parametros[13] = new OracleParameter();
                parametros[13].OracleType = OracleType.VarChar;
                parametros[13].ParameterName = ":modificado_por";
                parametros[13].Value = pHorario.Modificado_por;

                parametros[14] = new OracleParameter();
                parametros[14].OracleType = OracleType.DateTime;
                parametros[14].ParameterName = ":fecha_modificacion";
                parametros[14].Value = DateTime.Now;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch(Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando horario:" + e.Message;    
            }
        }

        public void borrarHorario(HorarioL pHorario)
        {
            try
            {
                string sql = "delete from empleado where id_horario= :id_horario";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_horario";
                parametros[0].Value = pHorario.Id_horario;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando horario: " + e.Message;
            }
        }

        public void editarHorario(HorarioL pHorarioEditado, HorarioL pHorarioOriginal)
        {
            try
            {
                string sql = "update horario_empresa " +
                             "set id_horario=:id_horario,domingo=:domingo,lunes=:lunes,martes=:martes,miercoles=:miercoles,jueves=:jueves,viernes=:viernes,sabado=:sabado,horaentrada=:hora_entrada,horasalida=:hora_salida,activo=:activo,modificado_por=:modificado_por,fecha_modificacion=:fecha_modificacion" +
                             " where id_horario=:id_horarioOriginal";

                OracleParameter[] parametros = new OracleParameter[14];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_horario";
                parametros[0].Value = pHorarioEditado.Id_horario;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":domingo";
                parametros[1].Value = pHorarioEditado.Domingo;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":lunes";
                parametros[2].Value = pHorarioEditado.Lunes;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":martes";
                parametros[3].Value = pHorarioEditado.Martes;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":miercoles";
                parametros[4].Value = pHorarioEditado.Miercoles;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":jueves";
                parametros[5].Value = pHorarioEditado.Jueves;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":viernes";
                parametros[6].Value = pHorarioEditado.Viernes;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":sabado";
                parametros[7].Value = pHorarioEditado.Sabado;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.DateTime;
                parametros[8].ParameterName = ":hora_entrada";
                parametros[8].Value = pHorarioEditado.HoraEntrada;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.DateTime;
                parametros[9].ParameterName = ":hora_salida";
                parametros[9].Value = pHorarioEditado.HoraSalida;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.VarChar;
                parametros[10].ParameterName = ":activo";
                parametros[10].Value = pHorarioEditado.Estado;

                parametros[11] = new OracleParameter();
                parametros[11].OracleType = OracleType.VarChar;
                parametros[11].ParameterName = ":modificado_por";
                parametros[11].Value = pHorarioEditado.Modificado_por;

                parametros[12] = new OracleParameter();
                parametros[12].OracleType = OracleType.DateTime;
                parametros[12].ParameterName = ":fecha_modificacion";
                parametros[12].Value = DateTime.Now;

                parametros[13] = new OracleParameter();
                parametros[13].OracleType = OracleType.VarChar;
                parametros[13].ParameterName = ":id_horarioOriginal";
                parametros[13].Value = pHorarioOriginal.Id_horario;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error editando horario: " + e.Message;
            }
        }

    }
}
