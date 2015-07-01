using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mi_Negocio.Datasource
{
    public class Connection
    {
        public static MySqlConnection ObtenerConexion()
        {

            iniConfig cfg = new iniConfig();
            cfg.getConfigDatabase();
            string servidor = cfg.db_host;
            string pwd = cfg.db_password;
            string usuario = cfg.db_user;
            string db = cfg.db_database;

            string cdnCon = "server=" + servidor + "; database=" + db + "; Uid=" + usuario + "; pwd=" + pwd + ";";
            MySqlConnection conectar = new MySqlConnection(cdnCon);
            try
            { 
                conectar.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Ocurrio un Error al realizar la conexión a la base de datos \n "+e.Message,"Error en la conexión",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
            return conectar;
        }        
    }
}
