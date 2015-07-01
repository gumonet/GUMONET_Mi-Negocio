using Mi_Negocio.Datasource;
using MySql.Data.MySqlClient;
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
            iniConfig cfg = new iniConfig();
            cfg.getConfigDatabase();
            textBox1.Text = cfg.db_host;
            textBox2.Text = cfg.db_password;
            textBox3.Text = cfg.db_user;
            textBox4.Text = cfg.db_database;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
        }
    }
}
