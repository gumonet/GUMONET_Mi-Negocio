using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mi_Negocio.Contabilidad
{
    public partial class frmContabilidad : Form
    {
        public frmContabilidad()
        {
            InitializeComponent();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaForm ctf = new  CategoriaForm();
            ctf.ShowDialog();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentaForm ctf = new CuentaForm();
            ctf.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
