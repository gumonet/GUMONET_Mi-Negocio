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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        /*Custom functions*/

        private void openProduct()
        {
            //dataFacturas["id_factura", dataFacturas.CurrentCell.RowIndex].Value.ToString();
            Int64 idProducto = Convert.ToInt64(vProductos["id_producto", vProductos.CurrentCell.RowIndex].Value.ToString());
            frmProducto p = new frmProducto();
            p.id_producto = idProducto;
            if (p.ShowDialog() != DialogResult.OK) //se coloca OK solo para que siempre se ejecute, por que el formulario no regresa nada
            {
                loadProducts();
            }
        }

        private void loadProducts()
        {
            vProductos.AutoGenerateColumns = false;
            vProductos.DataSource = ProductoDal.Buscar(txtSearch.Text);
        }
        /*End Custom Functions*/
        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void vProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openProduct();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openProduct();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caracteristica no instalada, contacte a soporte", "Atención");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProducto form = new frmProducto();
            form.id_producto = 0;

            if (form.ShowDialog() != DialogResult.OK) //se coloca OK solo para que siempre se ejecute, por que el formulario no regresa nada
            {
                loadProducts();
            }
        }
    }
}
