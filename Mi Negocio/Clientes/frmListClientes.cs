using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mi_Negocio.Clientes
{
    public partial class frmListClientes : Form
    {
        public frmListClientes()
        {
            InitializeComponent();
        }
        public int id_cte { get; set; }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            vClientes.AutoGenerateColumns = false;
            vClientes.DataSource = ClienteDal.Buscar(txtSearch.Text);
        }

        private void vClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_cte = Convert.ToInt32(vClientes["id_cliente", vClientes.CurrentCell.RowIndex].Value.ToString());
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListClientes_Load(object sender, EventArgs e)
        {
            vClientes.AutoGenerateColumns = false;
            vClientes.DataSource = ClienteDal.Buscar(txtSearch.Text);

        }
    }
}
