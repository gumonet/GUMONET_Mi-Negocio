using Mi_Negocio.Almacenes.Categorias;
using Mi_Negocio.Almacenes.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mi_Negocio.Almacenes
{
    public partial class frmAlmacen : Form
    {
        public frmAlmacen()
        {
            InitializeComponent();
        }
        /*custom functions*/

        /*Mdi functions*/
       
        private void openInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos form = new frmProductos();
            form.MdiParent = this;
            form.Show();
        }

        private void openMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
