using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Mi_Negocio.Connection
{
    class Connection
    {
        public static MySqlConnection ObtenerConexion()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("");
            //cadena de conexión
            //string cdnCon = "server=localhost; database=facturadb; Uid=root; pwd=;";
            string servidor = "";
            string usuario = "";
            string pwd = "";
            string db = "";

            string cdnCon = "server=" + servidor + "; database=" + db + "; Uid=" + usuario + "; pwd=" + pwd + ";";
            MySqlConnection conectar = new MySqlConnection(cdnCon);
            conectar.Open();
            return conectar;
        }
        
    }
}
