using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mi_Negocio.Almacenes.Categorias
{
    public partial class frmListCategorias : Form
    {
        public frmListCategorias()
        {
            InitializeComponent();
        }

        private void frmListCategorias_Load(object sender, EventArgs e)
        {
            vCategorias.AutoGenerateColumns = false;
            vCategorias.DataSource = CategoriaDal.buscar(txtSearch.Text);
        }

        public int categoria { get; set; }
        public String nombre { get; set; }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            vCategorias.AutoGenerateColumns = false;
            vCategorias.DataSource = CategoriaDal.buscar(txtSearch.Text);
        }

        private void vClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            categoria = Convert.ToInt32(vCategorias["id_categoria", vCategorias.CurrentCell.RowIndex].Value.ToString());
            nombre = vCategorias["nombre", vCategorias.CurrentCell.RowIndex].Value.ToString();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListClientes_Load(object sender, EventArgs e)
        {
            vCategorias.AutoGenerateColumns = false;
            vCategorias.DataSource = CategoriaDal.buscar(txtSearch.Text);

        }
    }
}
