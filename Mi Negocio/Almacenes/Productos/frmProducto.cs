using Mi_Negocio.Almacenes.Categorias;
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
    public partial class frmProducto : Form
    {
        public int idCategoria { get; set; }
        public Int64 id_producto { get; set; }

        private bool guardado { get; set; }
        public frmProducto()
        {
            InitializeComponent();
        }

        /*Custom Functions*/
        private void iniciarForm()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtUnidad.Text = "";
            txtParte.Text = "";
            idCategoria = 0;
            txtProveedor.Text = "";
            txtPrecio.Text = (0.00M).ToString("$##,##0.##");
            txtCosto.Text = (0.00M).ToString("$##,##0.##");
            txtInventario.Text = (0.00M).ToString();
            txtIva.Text = (0.00M).ToString("%##0.##");
            txtIeps.Text = (0.00M).ToString("%##0.##");
            txtImagen.Text = "";
        }
        private void saveProducto(){
            Producto pData = new Producto();

            pData.identificador = txtCodigo.Text;
            pData.nombre = txtNombre.Text;
            pData.descripcion = txtDescripcion.Text;
            pData.unidad_medida = txtUnidad.Text;
            pData.n_parte = txtParte.Text;
            pData.tipo = 1;
            pData.id_categoria = this.idCategoria;
            pData.proveedor = txtProveedor.Text;
            pData.precio_compra = Convert.ToDecimal(txtPrecio.Text);
            pData.precio_venta = Convert.ToDecimal(txtCosto.Text) ;
            pData.inventario_bajo = Convert.ToDecimal(txtInventario.Text);
            pData.iva = Convert.ToDecimal(txtIva.Text);
            pData.ieps = Convert.ToDecimal(txtIeps.Text);
            pData.imagen = txtImagen.Text;

            if (this.id_producto == 0)
            {
                createData(pData);
            }
            else
            {
                pData.id_producto = this.id_producto;
                updateData(pData);
            }
            
        }

        private void createData(Producto producto)
        {
            int resultado = ProductoDal.agregar(producto);
            if (resultado > 0)
            {
                MessageBox.Show("Producto agregado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iniciarForm();
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al agregar el producto", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateData(Producto producto)
        {
            int resultado = ProductoDal.actualizar(producto);
            if (resultado > 0)
            {
                MessageBox.Show("Producto Actualizado correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al Actualizar el producto", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fLoadData()
        {
            Producto pData = ProductoDal.obtener(this.id_producto);
            txtCodigo.Text = pData.identificador;
            txtNombre.Text = pData.nombre;
            txtDescripcion.Text = pData.descripcion;
            txtUnidad.Text = pData.unidad_medida;
            txtParte.Text = pData.n_parte;
            this.idCategoria = pData.id_categoria;
            txtDepartamento.Text = pData.categoria;
            txtProveedor.Text = pData.proveedor;
            txtPrecio.Text = (pData.precio_compra).ToString();
            txtCosto.Text = (pData.precio_venta).ToString();
            txtInventario.Text = (pData.inventario_bajo).ToString();
            txtIva.Text = (pData.iva).ToString();
            txtIeps.Text = (pData.ieps).ToString();
            txtImagen.Text = pData.imagen;
            txtExistencias.Text = pData.existencia.ToString();
            txtExistencias.Enabled = false;
            txtCodigo.Enabled = false;
        }

        /*Form Functions*/

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveProducto();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectDepto_Click(object sender, EventArgs e)
        {
            frmListCategorias frm = new frmListCategorias();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.idCategoria = frm.categoria;
                txtDepartamento.Text = frm.nombre;
            }
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            this.guardado = false;
            if (this.id_producto != 0) {
                fLoadData();
            }
            else
            {
                iniciarForm();
            }
        }

        

        
    }
}
