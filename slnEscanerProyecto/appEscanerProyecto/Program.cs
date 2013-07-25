﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Datos;
using GUI;

namespace appRelojMarcador
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string error = "";
            DataSet config = cargarArchivoConfiguracion(ref error);
            if (error == "")
            {
                string server = config.Tables[0].Rows[0]["Server"].ToString();
                string port = config.Tables[0].Rows[0]["Port"].ToString();
                string database = config.Tables[0].Rows[0]["DataBase"].ToString();
                string user = config.Tables[0].Rows[0]["Usuario"].ToString();
                string pass = config.Tables[0].Rows[0]["Password"].ToString();

                string cadenaConexion = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                                        "(HOST=" + server + ")(PORT=" + port + ")))(CONNECT_DATA=(SERVER=DEDICATED)" +
                                        "(SERVICE_NAME=" + database + ")));User Id=" + user + 
                                        ";Password=" + pass + ";";

                AccesoDatosOracle conexion = new AccesoDatosOracle(cadenaConexion);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmRelojMarcador(conexion));
            }
            else {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataSet cargarArchivoConfiguracion(ref string estado)
        {
            DataSet dsetConf = new DataSet();
            estado = "";
            try
            {
                string archivoXML = Application.StartupPath + "\\INI.xml";
                System.IO.FileStream fsReadXml =
                                 new System.IO.FileStream(archivoXML, System.IO.FileMode.Open);
                dsetConf.ReadXml(fsReadXml);
            }
            catch(Exception e) {
                estado = "Ha ocurrido un error cargando los parámetros de conexión " +
                         "a la base de datos, detalle técnico:" + e.Message;
            }
            return dsetConf;
        }
    }
}
