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
    class UsuarioD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public UsuarioD(AccesoDatosOracle pCnx)
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

        public List<UsuarioL> obtenerUsuarios()
        {
            List<UsuarioL> retorno = new List<UsuarioL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from diasPagoDoble");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(new UsuarioL(fila["id_usuario"].ToString(), fila["tipo_usuario"].ToString(), fila["nombre_usuario"].ToString(), fila["apellido1_usuario"].ToString(), fila["apellido2_usuario"].ToString(), fila["contrasenia"].ToString(), fila["activo"].ToString(), fila["creado_por"].ToString(), fila["fecha_creacion"].ToString(), fila["modificado_por"].ToString(), fila["fecha_modificacion"].ToString()));
                    }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error obteniendo usuarios: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo usuarios: " + e.Message;
            }
            return retorno;
        }

        public void agregarUsuario(UsuarioL pUsuario)
        {
            try
            {
                string sql = "insert into usuario(id_usuario,tipo_usuario,nombre_usuario,apellido1,apellido2,contrasenia,activo,creado_por,fecha_creacion,modificado_por,fecha_modificacion) " +
                             "values(:id_usuario,:tipo_usuario,:nombre_usuario,:apellido1,:apellido2,:contrasenia,:activo,:creado_por,:fecha_creacion,:modificado_por,:fecha_modificacion)";
                
                OracleParameter[] parametros = new OracleParameter[11];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_usuario";
                parametros[0].Value = pUsuario.Id_usuario;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":tipo_usuario";
                parametros[1].Value = pUsuario.Tipo_usuario;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":nombre_usuario";
                parametros[2].Value = pUsuario.Nombre_usuario;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":apellido1";
                parametros[3].Value = pUsuario.Apellido1_usuario;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.Timestamp;
                parametros[4].ParameterName = ":apellido2";
                parametros[4].Value = pUsuario.Apellido2_usuario;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":contrasenia";
                parametros[5].Value = pUsuario.Contrasenia;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.Timestamp;
                parametros[6].ParameterName = ":activo";
                parametros[6].Value = pUsuario.Activo;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":creado_por";
                parametros[7].Value = pUsuario.Creado_por;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.Timestamp;
                parametros[8].ParameterName = ":fecha_creacion";
                parametros[8].Value = pUsuario.Fecha_creacion;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.VarChar;
                parametros[9].ParameterName = ":modificado_por";
                parametros[9].Value = pUsuario.Modificado_por;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.Timestamp;
                parametros[10].ParameterName = ":fecha_modificacion";
                parametros[10].Value = pUsuario.Fecha_modificacion;

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

        public void borrarUsuario(UsuarioL pUsuario)
        {
            try
            {
                string sql = "delete from Usuario where id_usuario= :id_usuario";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Int32;
                parametros[0].ParameterName = ":id_usuario";
                parametros[0].Value = pUsuario.Id_usuario;

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

        public void editarUsuario(UsuarioL pUsuarioEditado, UsuarioL pUsuarioOriginal)
        {
            try
            {
                string sql = "update usuario " +
                             "set id_usuario = :id_usuario,tipo_usuario=:tipo_usuario, nombre_usuario = :nombre_usuario " +
                             ",apellido1=:apellido1,apellido2=:apellido2,activo=:activo,modificado_por=:modificado_por,fecha_modificacion=:fecha_modificacion" +
                             "where id_usuario = :id_usuarioOriginal";

                OracleParameter[] parametros = new OracleParameter[10];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_usuario";
                parametros[0].Value = pUsuarioEditado.Id_usuario;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":tipo_usuario";
                parametros[1].Value = pUsuarioEditado.Tipo_usuario;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":nombre_usuario";
                parametros[2].Value = pUsuarioEditado.Nombre_usuario;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":apellido1";
                parametros[3].Value = pUsuarioEditado.Apellido1_usuario;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":apellido2";
                parametros[4].Value = pUsuarioEditado.Apellido2_usuario;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":contrasenia";
                parametros[5].Value = pUsuarioEditado.Contrasenia;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":activo";
                parametros[6].Value = pUsuarioEditado.Activo;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":modificado_por";
                parametros[7].Value = pUsuarioEditado.Modificado_por;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.Timestamp;
                parametros[8].ParameterName = ":fecha_modificacion";
                parametros[8].Value = pUsuarioEditado.Fecha_modificacion;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.VarChar;
                parametros[9].ParameterName = ":id_usuarioOriginal";
                parametros[9].Value = pUsuarioOriginal.Id_usuario;

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
