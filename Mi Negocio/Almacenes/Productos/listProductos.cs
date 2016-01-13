using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mi_Negocio.Almacenes.Productos
{
    public partial class listProductos : Form
    {
        public Int64 idProducto { get; set; }
        public listProductos()
        {
            InitializeComponent();
        }

        private void listProductos_Load(object sender, EventArgs e)
        {

        }

        private void loadProducts()
        {
            vProductos.AutoGenerateColumns = false;
            vProductos.DataSource = ProductoDal.Buscar(txtSearch.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void vProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idProducto = Convert.ToInt32(vProductos["id_producto", vProductos.CurrentCell.RowIndex].Value.ToString());
            DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
