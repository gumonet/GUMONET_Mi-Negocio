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
    public partial class frmCategorias : Form
    {
        public int categoriaActual;
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            vDepartamentos.AutoGenerateColumns = false;
            vDepartamentos.DataSource = CategoriaDal.buscar(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Categoria pCategoria = new Categoria();
            pCategoria.nombre = txtNombre.Text.Trim();
            pCategoria.descripcion = txtDescripcion.Text.Trim();

            int resultado = CategoriaDal.agregar(pCategoria);
            if (resultado > 0)
            {
                fLoadForm();
                MessageBox.Show("Categoria Guardada Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al Guardar la Categoría", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Categoria pCategoria = new Categoria();
            pCategoria.nombre = txtNombre.Text.Trim();
            pCategoria.descripcion = txtDescripcion.Text.Trim();
            pCategoria.id_categoria = categoriaActual;

            int resultado = CategoriaDal.actualizar(pCategoria);
            if (resultado > 0)
            {
                fLoadForm();
                MessageBox.Show("Registro Actualizado Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ocurrio un Error al Actualizar el registro", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fLoadForm();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int nIdCategoria = Convert.ToInt32(vDepartamentos["id_categoria", vDepartamentos.CurrentCell.RowIndex].Value.ToString());
            if (nIdCategoria > 0)
            {
                if (MessageBox.Show("¿Estas seguro de eliminar este Cliente?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int resultado = CategoriaDal.delete(nIdCategoria);
                    if (resultado > 0)
                    {
                        fLoadForm();
                        MessageBox.Show("Registro Eliminado Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un Error al Eliminar el registro", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            vDepartamentos.AutoGenerateColumns = false;
            vDepartamentos.DataSource = CategoriaDal.buscar(txtSearch.Text);
        }


        private void vClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int nIdCategoria = Convert.ToInt32(vDepartamentos["id_categoria", vDepartamentos.CurrentCell.RowIndex].Value.ToString());
            Categoria pCategoria = CategoriaDal.obtener(nIdCategoria);
            txtNombre.Text = pCategoria.nombre;
            txtDescripcion.Text = pCategoria.descripcion;
            categoriaActual = nIdCategoria;
            fPreparaEdit();
        }

        /*Custom Form*/
        private void fLoadForm()
        {
            vDepartamentos.AutoGenerateColumns = false;
            vDepartamentos.DataSource = CategoriaDal.buscar(txtSearch.Text);
            btnGuardar.Enabled = false;
            btnAdd.Enabled = true;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
        }

        private void fPreparaEdit()
        {
            btnGuardar.Enabled = true;
            btnAdd.Enabled = false;
        }

    }
}
