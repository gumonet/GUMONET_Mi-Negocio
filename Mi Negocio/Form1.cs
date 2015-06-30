using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Mi_Negocio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = AppDomain.CurrentDomain.BaseDirectory;
            string path = AppDomain.CurrentDomain.BaseDirectory.ToString();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("config.xml");
            XmlNode configuracion = xDoc.DocumentElement.SelectSingleNode("/configuracion/database");
            textBox1.Text = configuracion.Attributes["host"].Value;
            textBox2.Text = configuracion.Attributes["database"].Value;
            textBox3.Text = configuracion.Attributes["usuario"].Value;
            textBox4.Text = configuracion.Attributes["password"].Value;

            /*
             * XmlDocument doc = new XmlDocument();
doc.LoadXml(xmlstring);

XmlNode errorNode = doc.DocumentElement.SelectSingleNode("/DataChunk/ResponseChunk/Errors/error");

string errorCode = errorNode.Attributes["code"].Value;
string errorMessage = errorNode.InnerText;
             * 
             * 
             * XmlNodeList personas = xDoc.GetElementsByTagName("personas");
XmlNodeList lista = 
    ((XmlElement)personas[0]).GetElementsByTagName("persona"); 
foreach (XmlElement nodo in lista)
{
int i=0;
XmlNodeList nNombre = 
nodo.GetElementsByTagName("nombre");

XmlNodeList nApellido1 = 
nodo.GetElementsByTagName("apellido1");

XmlNodeList nApellido2 = 
nodo.GetElementsByTagName("apellido2");

Console.WriteLine("Elemento nombre ... {0} {1} {2}", 
                             nNombre[i].InnerText, 
                             nApellido1[i].InnerText,
                             nApellido2[i++].InnerText);

} */
        }
    }
}
