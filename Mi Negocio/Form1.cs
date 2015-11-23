using Mi_Negocio.Clientes;
using Mi_Negocio.Contabilidad;
using Mi_Negocio.Cotizaciones;
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
            /*iniConfig cfg = new iniConfig();
            cfg.getConfigDatabase();
            textBox1.Text = cfg.db_host;
            textBox2.Text = cfg.db_password;
            textBox3.Text = cfg.db_user;
            textBox4.Text = cfg.db_database;*/
        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            frmCotizaciones fCot = new frmCotizaciones();
            fCot.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes fC = new frmClientes();
            fC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmContabilidad fC = new frmContabilidad();
            fC.Show();
        }

    }
}
