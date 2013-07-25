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
    public class MarcaD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public string ErrorDescription
        {
            get { return errorDescription; }
            set { errorDescription = value; }
        }

        public MarcaD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }

        public bool Error
        {
            get { return error; }
        }

        public List<MarcaL> obtenerMarcas()
        {
            List<MarcaL> retorno = new List<MarcaL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from marca_tiempo");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {

                        retorno.Add(new MarcaL(fila["id_marca"].ToString(), fila["id_	"].ToString(), fila["id_unificacionmarca"].ToString(), 
                                    fila["tipo_marca"].ToString(), DateTime.Parse(fila["fechaHora_marca"].ToString()), fila["estado"].ToString(),
                                    fila["creado_por"].ToString(), DateTime.Parse(fila["fecha_creacion"].ToString()), 
                                    fila["modificado_por"].ToString(), DateTime.Parse(fila["fecha_modificacion"].ToString())));
                    }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error obteniendo marcas: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo marcas: " + e.Message;
            }
            return retorno;
        }

        public DataSet obtenerMarcas(Boolean combo)
        {
            this.errorDescription = "";
            string sql = "select * from marca_tiempo";
            DataSet retorno = this.cnx.ejecutarConsultaSQL(sql);
            if (this.cnx.IsError)
            {
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            return retorno;
        }

        //public List<MarcaL> obtenerMarcas(string pNumero, DateTime pFecha1, DateTime pFecha2, string pCliente, string pAnulada)
        //{
        //    List<MarcaL> retorno = new List<MarcaL>();
        //    try
        //    {
        //        string sql = "select * from factura where anulada = :anulada and fecha >= :fecha1 and fecha <= :fecha2";
        //        int indices = 3;

        //        if (pNumero != "")
        //        {
        //            sql += " and numero = :numero";
        //            indices++;
        //        }

        //        if (pCliente != "")
        //        {
        //            sql += " and cliente like :cliente";
        //            indices++;
        //        }

        //        OracleParameter[] parametros = new OracleParameter[indices];

        //        parametros[0] = new OracleParameter();
        //        parametros[0].OracleType = OracleType.VarChar;
        //        parametros[0].ParameterName = ":anulada";
        //        parametros[0].Value = pAnulada;

        //        parametros[1] = new OracleParameter();
        //        parametros[1].OracleType = OracleType.DateTime;
        //        parametros[1].ParameterName = ":fecha1";
        //        parametros[1].Value = pFecha1;

        //        parametros[2] = new OracleParameter();
        //        parametros[2].OracleType = OracleType.DateTime;
        //        parametros[2].ParameterName = ":fecha2";
        //        parametros[2].Value = pFecha2;

        //        indices = 3;
        //        if (pNumero != "")
        //        {
        //            parametros[indices] = new OracleParameter();
        //            parametros[indices].OracleType = OracleType.Number;
        //            parametros[indices].ParameterName = ":numero";
        //            parametros[indices].Value = Int32.Parse(pNumero);
        //            indices++;
        //        }

        //        if (pCliente != "")
        //        {
        //            parametros[indices] = new OracleParameter();
        //            parametros[indices].OracleType = OracleType.VarChar;
        //            parametros[indices].ParameterName = ":cliente";
        //            parametros[indices].Value = '%' + pCliente + '%';
        //        }

        //        DataSet datos = this.cnx.ejecutarConsultaSQL(sql, "factura", parametros);
        //        if (this.cnx.IsError == false)
        //        {
        //            FacturaDetalleD oDetalleD = new FacturaDetalleD(this.cnx);
        //            foreach (DataRow fila in datos.Tables[0].Rows)
        //            {
        //                List<DetalleFacturaL> datosDetalle = oDetalleD.obtenerDetalle(Int32.Parse(fila["numero"].ToString()));
        //                if (oDetalleD.Error == false)
        //                {
        //                    FacturaL ofacturaL = new FacturaL(Int32.Parse(fila["numero"].ToString()),
        //                                             DateTime.Parse(fila["fecha"].ToString()),
        //                                             fila["cliente"].ToString(),
        //                                             fila["anulada"].ToString());
        //                    if (datosDetalle.Count > 0)
        //                    {
        //                        for (int i = 0; i < datosDetalle.Count; i++)
        //                        {
        //                            ofacturaL.agregarLinea(datosDetalle[i].Repuesto, datosDetalle[i].Cantidad);
        //                        }
        //                    }
        //                    retorno.Add(ofacturaL);
        //                }
        //                else
        //                {
        //                    this.error = true;
        //                    this.errorDescription = "Error obteniendo detalle de facturas:" +
        //                                            oDetalleD.ErrorDescription;
        //                    return retorno;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            this.error = true;
        //            this.errorDescription = "Error obteniendo facturas:" +
        //                                    this.cnx.ErrorDescripcion;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        this.error = true;
        //        this.errorDescription = "Error obteniendo facturas:" + e.Message;
        //    }
        //    return retorno;
        //}
        
        public void agregarMarca(MarcaL pMarca)
        {
            try
            {
                string sql = "insert into marca_tiempo values(:id_marca,:id_empleado,:id_unificacion,:tipo_marca,:fechaHora_marca,:activo,:creado_por,:fecha_creacion,:modificado_por,:fecha_modificacion)";
                
                OracleParameter[] parametros = new OracleParameter[6];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_marca";
                parametros[0].Value = pMarca.Id_marca;
                
                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":id_empleado";
                parametros[1].Value = pMarca.Id_empleado;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":id_unificacion";
                parametros[2].Value = pMarca.Id_unificacion;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":tipo_marca";
                parametros[3].Value = pMarca.TipoMarca;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.DateTime;
                parametros[4].ParameterName = ":fechaHora_marca";
                parametros[4].Value = pMarca.FechaHora;
                
                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":activo";
                parametros[5].Value = pMarca.Estado;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":creado_por";
                parametros[6].Value = pMarca.Creado_por;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.DateTime;
                parametros[7].ParameterName = ":fecha_creacion";
                parametros[7].Value = pMarca.Fecha_creacion;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.VarChar;
                parametros[8].ParameterName = ":modificado_por";
                parametros[8].Value = pMarca.Modificado_por;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.DateTime;
                parametros[9].ParameterName = ":fecha_modificacion";
                parametros[9].Value = pMarca.Fecha_modificacion;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch(Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando Marca:" + e.Message;    
            }
        }

        public void borrarMarca(MarcaL pMarca)
        {
            try
            {
                string sql = "delete from marca_tiempo where id_marca= :id_marca";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_marca";
                parametros[0].Value = pMarca.Id_marca;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando marca: " + e.Message;
            }
        }

        public void editarMarca(MarcaL pMarcaEditada, MarcaL pMarcaOriginal)
        {
            try
            {
                string sql = "update marca_tiempo " +
                             "set (id_marca=:id_marca,id_empleado=:id_empleado,id_unificacion=:id_unificacion,tipo_marca=:tipo_marca,fechaHora_marca=:fechaHora_marca,activo=:activo,modificado_por=:modificado_por,fecha_modificacion=:fecha_modificacion)" +
                             " where id_marca = :id_marcaOriginal";

                OracleParameter[] parametros = new OracleParameter[5];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":id_marca";
                parametros[0].Value = pMarcaEditada.Id_marca;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":id_empleado";
                parametros[1].Value = pMarcaEditada.Id_empleado;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":id_unificacion";
                parametros[2].Value = pMarcaEditada.Id_unificacion;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":tipo_marca";
                parametros[3].Value = pMarcaEditada.TipoMarca;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.DateTime;
                parametros[4].ParameterName = ":fechaHora_marca";
                parametros[4].Value = pMarcaEditada.FechaHora;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":activo";
                parametros[5].Value = pMarcaEditada.Estado;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":creado_por";
                parametros[6].Value = pMarcaEditada.Creado_por;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.DateTime;
                parametros[7].ParameterName = ":fecha_creacion";
                parametros[7].Value = pMarcaEditada.Fecha_creacion;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.VarChar;
                parametros[8].ParameterName = ":modificado_por";
                parametros[8].Value = pMarcaEditada.Modificado_por;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.DateTime;
                parametros[9].ParameterName = ":fecha_modificacion";
                parametros[9].Value = pMarcaEditada.Fecha_modificacion;

                parametros[11] = new OracleParameter();
                parametros[11].OracleType = OracleType.VarChar;
                parametros[11].ParameterName = ":id_marcaOriginal";
                parametros[11].Value = pMarcaOriginal.Id_empleado;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error editando marca: " + e.Message;
            }
        }

        public DataSet consultarMarcas(DateTime? pFechaIni,DateTime? pFechaFin,string pDepartamento,string pEstado,string pEmpleado)
        {
            string sql = "select * from marca_tiempo";
            string filtro = "";
            int cantidadParametros = 0;
            #region fecha inicial
            if (pFechaIni != null)
            {
                if (filtro == "")
                {
                    filtro += " where fechahora_marca >= :fecha_inicio";
                }
                cantidadParametros++;
            }
            #endregion
            #region fecha final
            if (pFechaFin != null)
            {
                if (filtro == "")
                {
                    filtro = " where fechahora_marca <= :fecha_final"; 
                }
                else
                { 
                    filtro += " and "; 
                }
                filtro += "fechahora_marca <= :fecha_final";
                cantidadParametros++;
            }
            #endregion
            #region departamento
            if (pDepartamento != null)
            {
                if (filtro == "") 
                { 
                    filtro = " where "; 
                }
                else 
                {
                    filtro += " and "; 
                }
                filtro += "id_departamento = :id_departamento";
                cantidadParametros++;
            }
            #endregion
            #region estado
            if (pEstado != null)
            {
                if (filtro == "")
                { 
                    filtro = " where estado= :estado"; 
                }
                else 
                { 
                    filtro += " and "; 
                }
                filtro += "where estado= :estado";
                cantidadParametros++;
            }
            #endregion
            #region empleado
            if (pEmpleado != null)
            {
                if (filtro == "") 
                { 
                    filtro = " where ";
                }
                else 
                {
                    filtro += " and "; 
                }
                filtro += "id_empleadomarca = :id_empleado";
                cantidadParametros++;
            }
            #endregion
            if (filtro != "")
            {
                sql += filtro;
            }

            OracleParameter[] Parametros = new OracleParameter[cantidadParametros];
            int index = 0;

            if (pFechaIni != null)
            {
                Parametros[index] = new OracleParameter();
                Parametros[index].OracleType = OracleType.DateTime;
                Parametros[index].ParameterName = ":fecha_inicio";
                Parametros[index].Value = pFechaIni;
                index++;
            }

            if (pFechaFin != null)
            {
                Parametros[index] = new OracleParameter();
                Parametros[index].OracleType = OracleType.DateTime;
                Parametros[index].ParameterName = ":fecha_final";
                Parametros[index].Value = pFechaFin;
                index++;
            }

            if (pDepartamento != null)
            {
                Parametros[index] = new OracleParameter();
                Parametros[index].OracleType = OracleType.VarChar;
                Parametros[index].ParameterName = ":id_departamento";
                Parametros[index].Value = pDepartamento;
                index++;
            }

            if (pEstado != null)
            {
                Parametros[index] = new OracleParameter();
                Parametros[index].OracleType = OracleType.VarChar;
                Parametros[index].ParameterName = ":estado";
                Parametros[index].Value = pEstado;
                index++;
            }

            if (pEmpleado != null)
            {
                Parametros[index] = new OracleParameter();
                Parametros[index].OracleType = OracleType.VarChar;
                Parametros[index].ParameterName = ":id_empleado";
                Parametros[index].Value = pEmpleado;
                index++;
            }

            DataSet retorno = this.cnx.ejecutarConsultaSQL(sql, "marca_tiempo", Parametros);
            if (this.cnx.IsError)
            {
                this.ErrorDescription = this.cnx.ErrorDescripcion;
            }

            return retorno;
        }
    }
}
