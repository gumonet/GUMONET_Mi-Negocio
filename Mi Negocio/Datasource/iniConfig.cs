using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Mi_Negocio.Datasource
{
    class iniConfig
    {
        public string db_host { get; set; }
        public string db_database { get; set; }
        public string db_user { get; set; }
        public string db_password { get; set; }

        public void getConfigDatabase()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path+"config.xml");
            XmlNode configuracion = xDoc.DocumentElement.SelectSingleNode("/configuracion/database");
            this.db_host = configuracion.Attributes["host"].Value;
            this.db_database = configuracion.Attributes["database"].Value;
            this.db_user = configuracion.Attributes["usuario"].Value;
            this.db_password = configuracion.Attributes["password"].Value;
        }
        public void getConfigEmail()
        {
           /* string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path + "config.xml");
            XmlNode configuracion = xDoc.DocumentElement.SelectSingleNode("/configuracion/database");
            this.db_host = configuracion.Attributes["host"].Value;
            this.db_database = configuracion.Attributes["database"].Value;
            this.db_user = configuracion.Attributes["usuario"].Value;
            this.db_password = configuracion.Attributes["password"].Value;*/
        }

        
    }
}
