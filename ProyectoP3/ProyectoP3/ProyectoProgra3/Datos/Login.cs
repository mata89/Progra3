using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlTypes;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Datos
{
    class Login
    {
        AccesoDatosSQL cnx;
        string error;

        public Login(AccesoDatosSQL pCNX)
        {
            this.cnx = pCNX;
            this.error = "";

        }
        public bool buscarUsuario(string pUser, string pPass)
        {
            bool retuo = false;
            this.error = "";
            string SQL = "SELECT LoginU, Clave " + "FROM Usuarios " + "WHERE LoginU = '" + pUser + "'" + "AND Clave = '" + pPass + "'";
            DataSet retorno = this.cnx.ejecutarConsultaSQLp(SQL,"Usuarios");
            try
            {
                DataRow DR = retorno.Tables["Usuarios"].Rows[0];


                if ((pUser == DR["LoginU"].ToString()) && (pPass == DR["Clave"].ToString()))
                {
                    retuo = true;
                }

            }
            catch (Exception e)
            {
                retuo = false;
                
            }
            
            
            
            if (this.cnx.IsError)
            {
                this.error = this.cnx.ErrorDescripcion;
                retuo = false;
            }
            return retuo;
        }
    }
}
