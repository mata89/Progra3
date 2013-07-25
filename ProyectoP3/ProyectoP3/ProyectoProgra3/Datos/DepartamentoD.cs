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
    class DepartamentoD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";
        private string errorsh = "";

        public string Errorsh
        {
            get { return errorsh; }
            set { errorsh = value; }
        }

        public DepartamentoD(AccesoDatosOracle pCnx)
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

        public List<DepartamentoL> obtenerDepartamentos()
        {
            List<DepartamentoL> retorno = new List<DepartamentoL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from departamento");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(new DepartamentoL(fila["id_departamento"].ToString(), fila["nombre_departamento"].ToString(), fila["activo"].ToString(), fila["creado_por"].ToString(), fila["fecha_creacion"].ToString(), fila["modificado_por"].ToString(), fila["fecha_modificacion"].ToString()));
                    }
                }
                else
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo departamentos: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo departamentos: " + e.Message;
            }
            return retorno;
        }
        
        public void agregarDepartamento(DepartamentoL pDepartamento)
        {
            try
            {
                string sql = "insert into departamento values(:id_departamento,:nombre_departamento,:activo,:creado_por,:fecha_creacion,:modificado_por,:fecha_modificacion)";
                
                OracleParameter[] parametros = new OracleParameter[7];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_departamento";
                parametros[0].Value = pDepartamento.Id_departamento;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":nombre_departamento";
                parametros[1].Value = pDepartamento.Nombre_departamento;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":activo";
                parametros[2].Value = pDepartamento.Activo;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":creado_por";
                parametros[3].Value = pDepartamento.Creado_por;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":fecha_creacion";
                parametros[4].Value = DateTime.Now.ToString();

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":modificado_por";
                parametros[5].Value = pDepartamento.Modificado_por;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":fecha_modificacion";
                parametros[6].Value = DateTime.Now.ToString();

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch(Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando departamento:" + e.Message;    
            }
        }

        public void borrarDepartamento(DepartamentoL pDepartamento)
        {
            try
            {
                string sql = "delete from departamento where id_departamento= :id_departamento";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_departamento";
                parametros[0].Value = pDepartamento.Id_departamento;

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

        public void editarDepartamento(DepartamentoL pDepartamentoEditado, DepartamentoL pDepartamentoOriginal)
        {
            try
            {
                string sql = "update departamento " +
                             "set id_departamento=:id_departamento,nombre_departamento=:nombre_departamento,activo=:activo,modificado_por=:modificado_por,fecha_modificacion=:fecha_modificacion" +
                             " where id_departamento = :id_departamentoOriginal";

                OracleParameter[] parametros = new OracleParameter[6];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_departamento";
                parametros[0].Value = pDepartamentoEditado.Id_departamento;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":nombre_departamento";
                parametros[1].Value = pDepartamentoEditado.Nombre_departamento;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":modificado_por";
                parametros[2].Value = pDepartamentoEditado.Modificado_por;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":fecha_modificacion";
                parametros[3].Value = DateTime.Now.ToString();

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":id_departamentoOriginal";
                parametros[4].Value = pDepartamentoOriginal.Id_departamento;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":activo";
                parametros[5].Value = pDepartamentoEditado.Activo;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error editando departamento: " + e.Message;
            }
        }
    }
}
