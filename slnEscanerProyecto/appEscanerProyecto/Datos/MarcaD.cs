using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using Logica;

namespace Datos
{
    class MarcaD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";
        private string id_empleado;
        private string nombre;

        public MarcaD(AccesoDatosOracle pCnx, string pId_empleado )
        {
            this.cnx = pCnx;
            this.id_empleado = pId_empleado;
            this.nombre = "";
        }

        public bool Error
        {
            get { return error; }
        }
       
        public string ErrorDescription
        {
            get { return errorDescription; }
        }

        public int ulitmoIdMarca()
        { 
            return 0;
        }
        
        public bool puedeMarcar()
        {
            int indice = 0;
            bool encontrado = false;
            List<EmpleadoL> Lista = obtenerEmpleados();
            while ((encontrado = false) || (indice < Lista.Count))
            {
                if (Lista[indice].Id_empleado == this.id_empleado)
                {
                    this.nombre = Lista[indice].Nombre_empleado;
                    encontrado = true;
                    return encontrado;
                }
                else
                {
                    indice++;
                }
            }
            return encontrado;
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
                        retorno.Add(
                                    new EmpleadoL(fila["id_empleado"].ToString(),
                                               fila["id_departamento"].ToString(),
                                               fila["nombre"].ToString(),
                                               fila["apellido_1"].ToString(),
                                               fila["apellido_2"].ToString(),
                                               fila["genero"].ToString(),
                                               fila["direccion"].ToString(),
                                               fila["salario_por_hora"].ToString(),
                                               fila["activo"].ToString(),
                                               fila["creado_por"].ToString(),
                                               fila["fecha_creacion"].ToString(),
                                               fila["modificado_por"].ToString(),
                                               fila["fecha_modificacion"].ToString()));
                    }
                }
                else
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo los empleados:" +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo los empleados:" + e.Message;
            }
            return retorno;
        }

        public List<MarcaL> obtenerMarcas()
        {
            List<MarcaL> retorno = new List<MarcaL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from marcas where cedula =" + this.id_empleado + " " + "order by consecutivo desc");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new MarcaL(fila["id_marca"].ToString(),
                                               fila["id_empleado"].ToString(),
                                               fila["id_unificacion"].ToString(),
                                               fila["tipo_marca"].ToString(),
                                               fila["fechaHora_marca"].ToString(),
                                               fila["estado"].ToString(),
                                               fila["creado_por"].ToString(),
                                               fila["fecha_creacion"].ToString(),
                                               fila["modificado_por"].ToString(),
                                               fila["fecha_modificacion"].ToString()));
                    }
                }
                else
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo marcas:" +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo marcas:" + e.Message;
            }
            return retorno;
        }

        public string Marcar()
        {
            string mensaje = "Marca registrada";
            List<MarcaL> oListaM = this.obtenerMarcas();
            if (puedeMarcar() == true)
            {
                string TipoMarca = "";
                oListaM[0].Id_unificacion= null;

                if (oListaM.Count == 0)
                {
                    TipoMarca = "Entrada";
                }

                if (oListaM[0].Tipo_marca == "Entrada")
                {
                    TipoMarca = "Salida";
                }

                if (oListaM[0].Tipo_marca == "Salida")
                {
                    TipoMarca = "Entrada";
                }

                try
                {
                    string sql = "insert into Marca_tiempo(id_marca, id_empleado, id_unificacion, tipo_marca, fechaHora_marca, estado, creado_por, fecha_creacion, modificado_por, fecha_modificacion) " +
                                 "values(:id_marca, :id_empleado, :id_unificacion, :tipo_marca, :fecha_marca, :estado, :creado_por, :fecha_creacion, :modicado_por, :fecha_modificacion) ";
                    
                    OracleParameter[] parametros = new OracleParameter[10];

                    parametros[0] = new OracleParameter();
                    parametros[0].OracleType = OracleType.VarChar;
                    parametros[0].ParameterName = ":id_marca";
                    parametros[0].Value = oListaM[0].Id_marca;

                    parametros[1] = new OracleParameter();
                    parametros[1].OracleType = OracleType.VarChar;
                    parametros[1].ParameterName = ":id_empleado";
                    parametros[1].Value = TipoMarca;

                    parametros[2] = new OracleParameter();
                    parametros[2].OracleType = OracleType.VarChar;
                    parametros[2].ParameterName = ":id_unificacion";
                    parametros[2].Value = "G";

                    parametros[3] = new OracleParameter();
                    parametros[3].OracleType = OracleType.VarChar;
                    parametros[3].ParameterName = ":tipo_marca";
                    parametros[3].Value = "S";

                    parametros[4] = new OracleParameter();
                    parametros[4].OracleType = OracleType.DateTime;
                    parametros[4].ParameterName = ":fecha_marca";
                    parametros[4].Value = DateTime.Now;

                    parametros[5] = new OracleParameter();
                    parametros[5].OracleType = OracleType.VarChar;
                    parametros[5].ParameterName = ":estado";
                    parametros[5].Value = null;

                    parametros[6] = new OracleParameter();
                    parametros[6].OracleType = OracleType.VarChar;
                    parametros[6].ParameterName = ":creado_por";
                    parametros[6].Value = this.nombre;

                    parametros[7] = new OracleParameter();
                    parametros[7].OracleType = OracleType.DateTime;
                    parametros[7].ParameterName = ":fecha_creacion";
                    parametros[7].Value = DateTime.Now;

                    parametros[8] = new OracleParameter();
                    parametros[8].OracleType = OracleType.VarChar;
                    parametros[8].ParameterName = ":modificado_por";
                    parametros[8].Value = this.nombre;

                    parametros[9] = new OracleParameter();
                    parametros[9].OracleType = OracleType.DateTime;
                    parametros[9].ParameterName = ":fecha_modificacion";
                    parametros[9].Value = DateTime.Now;



                    this.cnx.ejecutarSQL(sql, parametros);

                    this.error = this.cnx.IsError;
                    this.errorDescription = this.cnx.ErrorDescripcion;

                }
                catch (Exception e)
                {
                    this.error = true;
                    this.errorDescription = "Error agregando marca:" + e.Message;
                }


            }
            else
            {
                mensaje = "empleado inexistente";
            }
            return mensaje;
        }


    }
}
