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
    public partial class CuentaForm : Form
    {
        public int cuentaActual { get; set; }
        public CuentaForm()
        {
            InitializeComponent();
        }

        private void CuentaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cuenta pCliente = new Cuenta();
            pCliente.nombre = txtNombre.Text.Trim();
            pCliente.descripcion = txtDescripcion.Text.Trim();

            int resultado = CuentaDal.agregar(pCliente);
            if (resultado > 0)
            {
                fLoadForm();
                MessageBox.Show("Cuenta Guardada Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al Guardar la Categoría", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cuenta pCuenta = new Cuenta();
            pCuenta.nombre = txtNombre.Text.Trim();
            pCuenta.descripcion = txtDescripcion.Text.Trim();
            pCuenta.id_cuenta = cuentaActual;

            int resultado = CuentaDal.actualizar(pCuenta);
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
            int nIdCuenta = Convert.ToInt32(vCuentas["id_cuenta", vCuentas.CurrentCell.RowIndex].Value.ToString());
            if (nIdCuenta > 0)
            {
                if (MessageBox.Show("¿Estas seguro de eliminar este Cliente?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int resultado = CuentaDal.eliminar(nIdCuenta);
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
            vCuentas.AutoGenerateColumns = false;
            vCuentas.DataSource = CuentaDal.buscar(txtSearch.Text);
        }


        private void vClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int nIdCuenta = Convert.ToInt32(vCuentas["id_cuenta", vCuentas.CurrentCell.RowIndex].Value.ToString());
            Cuenta pCuenta = CuentaDal.obtener(nIdCuenta);

            txtNombre.Text = pCuenta.nombre;
            txtDescripcion.Text = pCuenta.descripcion;
            cuentaActual = nIdCuenta;
            fPreparaEdit();
        }

        /*Custom Form*/
        private void fLoadForm()
        {
            vCuentas.AutoGenerateColumns = false;
            vCuentas.DataSource = CuentaDal.buscar(txtSearch.Text);
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

        private void CuentaForm_Load_1(object sender, EventArgs e)
        {
            vCuentas.AutoGenerateColumns = false;
            vCuentas.DataSource = CuentaDal.buscar(txtSearch.Text);
        }
    }
}
