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

        public MarcaD(AccesoDatosOracle pCnx)
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

        public int ulitmoIdMarca()
        { 
            return 0;
        }

        public string agregarMarca(MarcaL pMarca)
        {
            string retorno = "";
            try
            {
                string sql = "insert into Marca_tiempo(id_marca, id_empleado, id_unificacion, tipo_marca, fechaHora_marca, estado) " +
                             "values(:id_marca, :id_empleado, :id_unificacion, :tipo_marca, :fecha_marca, :estado) ";

                OracleParameter[] parametros = new OracleParameter[7];      

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.DateTime;
                parametros[0].ParameterName = ":id_marca";
                parametros[0].Value = pMarca.Id_marca;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":id_empleado";
                parametros[1].Value = pMarca.Id_empleado;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.Float;
                parametros[2].ParameterName = ":id_unificacion";
                parametros[2].Value = pMarca.Id_unificacion;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.Float;
                parametros[3].ParameterName = ":tipo_marca";
                parametros[3].Value = pMarca.Tipo;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.DateTime;
                parametros[4].ParameterName = ":fecha_marca";
                parametros[4].Value = pMarca.FechaCreacion;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":estado";
                parametros[5].Value = pMarca.Estado;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.Number;
                parametros[6].ParameterName = ":numFactura";
                parametros[6].Direction = ParameterDirection.Output;

                retorno = this.cnx.ejecutarSQLReturning(sql, parametros, ":numFactura");
            
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;

            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando factura:" + e.Message;
            }
            return retorno;
        }

    }
}
