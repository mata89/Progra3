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
    class EmpleadoD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public EmpleadoD(AccesoDatosOracle pCnx)
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

        public List<EmpleadoL> obtenerEmpleados()
        {
            List<EmpleadoL> retorno = new List<EmpleadoL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from empleado");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(new EmpleadoL(fila["id_empleado"].ToString(), fila["id_departamento"].ToString(),
                                    fila["nombre_empleado"].ToString(), fila["apellido_1"].ToString(), fila["apellido_2"].ToString(),
                                    fila["genero"].ToString(), fila["direccion"].ToString(), Double.Parse(fila["salario_por_hora"].ToString()), fila["activo"].ToString(),
                                    fila["creado_por"].ToString(), DateTime.Parse(fila["fecha_creacion"].ToString()), 
                                    fila["modificado_por"].ToString(), DateTime.Parse(fila["fecha_modificacion"].ToString())));
                    }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error obteniendo empleados: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo empleados: " + e.Message;
            }
            return retorno;
        }

        public DataSet obtenerEmpleados(Boolean combo)
        {
            this.errorDescription = "";
            string sql = "select * from empleado where activo = 'SI'";
            DataSet retorno = this.cnx.ejecutarConsultaSQL(sql);
            if (this.cnx.IsError)
            {
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            return retorno;
        }

        public void agregarEmpleado(EmpleadoL pEmpleado)
        {
            try
            {
                string sql = "insert into empleado values(:id_empleado,:id_departamento,:nombre,:apellido1,:apellido2,:genero,:direccion,:salarioPorHora,:activo,:creado_por,:fecha_creacion,:modificado_por,:fecha_modificacion)";
                
                OracleParameter[] parametros = new OracleParameter[13];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_empleado";
                parametros[0].Value = pEmpleado.Id_empleado;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":id_departamento";
                parametros[1].Value = pEmpleado.Id_departamento;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":nombre";
                parametros[2].Value = pEmpleado.Nombre_empleado;
                
                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":apellido1";
                parametros[3].Value = pEmpleado.Apellido_1;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":apellido2";
                parametros[4].Value = pEmpleado.Apellido_2;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":genero";
                parametros[5].Value = pEmpleado.Genero;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":direccion";
                parametros[6].Value = pEmpleado.Direccion;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.Double;
                parametros[7].ParameterName = ":salarioPorHora";
                parametros[7].Value = pEmpleado.Salario_por_hora;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.VarChar;
                parametros[8].ParameterName = ":activo";
                parametros[8].Value = pEmpleado.Activo;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.VarChar;
                parametros[9].ParameterName = ":creado_por";
                parametros[9].Value = pEmpleado.Creado_por;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.DateTime;
                parametros[10].ParameterName = ":fecha_creacion";
                parametros[10].Value = DateTime.Now;

                parametros[11] = new OracleParameter();
                parametros[11].OracleType = OracleType.VarChar;
                parametros[11].ParameterName = ":modificado_por";
                parametros[11].Value = pEmpleado.Modificado_por;

                parametros[12] = new OracleParameter();
                parametros[12].OracleType = OracleType.DateTime;
                parametros[12].ParameterName = ":fecha_modificacion";
                parametros[12].Value = DateTime.Now;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch(Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando empleado:" + e.Message;    
            }
        }

        public void borrarEmpleado(EmpleadoL pEmpleado)
        {
            try
            {
                string sql = "delete from empleado where id_empleado= :id_empleado";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_empleado";
                parametros[0].Value = pEmpleado.Id_empleado;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando empleado: " + e.Message;
            }
        }

        public void editarEmpleado(EmpleadoL pEmpleadoEditado, EmpleadoL pEmpleadoOriginal)
        {
            try
            {
                string sql = "update empleado " +
                             "set id_empleado=:id_empleado,id_departamento=:id_departamento,nombre=:nombre,apellido1=:apellido1,apellido2=:apellido2,genero=:genero,direccion=:direccion,salarioPorHora=:salarioPorHora,activo=:activo,modificado_por=:modificado_por,fecha_modificacion=:fecha_modificacion" +
                             " where id_empleado=:id_empleadoOriginal";

                OracleParameter[] parametros = new OracleParameter[12];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_empleado";
                parametros[0].Value = pEmpleadoEditado.Id_empleado;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":id_departamento";
                parametros[1].Value = pEmpleadoEditado.Id_departamento;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":nombre";
                parametros[2].Value = pEmpleadoEditado.Nombre_empleado;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":apellido1";
                parametros[3].Value = pEmpleadoEditado.Apellido_1;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":apellido2";
                parametros[4].Value = pEmpleadoEditado.Apellido_2;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":genero";
                parametros[5].Value = pEmpleadoEditado.Genero;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":direccion";
                parametros[6].Value = pEmpleadoEditado.Direccion;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.Double;
                parametros[7].ParameterName = ":salarioPorHora";
                parametros[7].Value = pEmpleadoEditado.Salario_por_hora;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.VarChar;
                parametros[8].ParameterName = ":activo";
                parametros[8].Value = pEmpleadoEditado.Activo;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.VarChar;
                parametros[9].ParameterName = ":modificado_por";
                parametros[9].Value = pEmpleadoEditado.Modificado_por;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.DateTime;
                parametros[10].ParameterName = ":fecha_modificacion";
                parametros[10].Value = DateTime.Now;

                parametros[11] = new OracleParameter();
                parametros[11].OracleType = OracleType.VarChar;
                parametros[11].ParameterName = ":id_empleadoOriginal";
                parametros[11].Value = pEmpleadoOriginal.Id_empleado;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error editando empleado: " + e.Message;
            }
        }

    }
}
