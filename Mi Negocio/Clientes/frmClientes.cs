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
    public partial class frmClientes : Form
    {
        public int clienteActual;
        public frmClientes()
        {
            InitializeComponent();
        }

         private void Clientes_Load(object sender, EventArgs e)
        {
            fLoadForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cliente pCliente = new Cliente();
            pCliente.nombre = txtNombre.Text.Trim();
            pCliente.razon_social = txtRazonSocial.Text.Trim();
            pCliente.rfc = txtRfc.Text.Trim();
            pCliente.calle = txtCalle.Text.Trim();
            pCliente.n_ext = txtNumExt.Text.Trim();
            pCliente.n_int = txtNumInt.Text.Trim();
            pCliente.colonia = txtColonia.Text.Trim();
            pCliente.cp = txtCp.Text.Trim();
            pCliente.localidad = txtPoblacion.Text.Trim();
            pCliente.municipio = txtMunicipio.Text.Trim();
            pCliente.estado = txtEstado.Text.Trim();
            pCliente.telefono = txtTelefono.Text.Trim();
            pCliente.email = txtMail.Text.Trim();

            int resultado = ClienteDal.agregarCliente(pCliente);
            if (resultado > 0)
            {
                fLoadForm();
                MessageBox.Show("Cliente Guardado Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al Guardar el cliente", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente pCliente = new Cliente();
            pCliente.nombre = txtNombre.Text.Trim();
            pCliente.razon_social = txtRazonSocial.Text.Trim();
            pCliente.rfc = txtRfc.Text.Trim();
            pCliente.calle = txtCalle.Text.Trim();
            pCliente.n_ext = txtNumExt.Text.Trim();
            pCliente.n_int = txtNumInt.Text.Trim();
            pCliente.colonia = txtColonia.Text.Trim();
            pCliente.cp = txtCp.Text.Trim();
            pCliente.localidad = txtPoblacion.Text.Trim();
            pCliente.municipio = txtMunicipio.Text.Trim();
            pCliente.estado = txtEstado.Text.Trim();
            pCliente.telefono = txtTelefono.Text.Trim();
            pCliente.email = txtMail.Text.Trim();
            pCliente.id_cliente = clienteActual;

            int resultado = ClienteDal.ActualizarCliente(pCliente);
            if (resultado > 0)
            {
                fLoadForm();
                MessageBox.Show("Cliente Actualizado Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Ocurrio un Error al Actualizar el cliente", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fLoadForm();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int nIdCompany = Convert.ToInt32(vClientes["id_cliente", vClientes.CurrentCell.RowIndex].Value.ToString());
            if (nIdCompany > 0)
            {
                if (MessageBox.Show("¿Estas seguro de eliminar este Cliente?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int resultado = ClienteDal.deleteCliente(nIdCompany);
                    if (resultado > 0)
                    {
                        fLoadForm();
                        MessageBox.Show("Cliente Eliminado Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un Error al Eliminar el cliente", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Cuatom Form*/
        private void fLoadForm()
        {
            vClientes.AutoGenerateColumns = false;
            vClientes.DataSource = ClienteDal.Buscar();
            btnGuardar.Enabled = false;
            btnAdd.Enabled = true;
            txtNombre.Text = "";
            txtRazonSocial.Text = "";
            txtCalle.Text = "";
            txtNumExt.Text = "";
            txtNumInt.Text = "";
            txtCp.Text = "";
            txtColonia.Text = "";
            txtPoblacion.Text = "";
            txtMunicipio.Text = "";
            txtEstado.Text = "";
            txtTelefono.Text = "";
            txtRfc.Text = "";
            txtMail.Text = "";
        }

        private void fPreparaEdit()
        {
            btnGuardar.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            vClientes.AutoGenerateColumns = false;
            vClientes.DataSource = ClienteDal.Buscar(txtSearch.Text);
        }

        private void vClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int nIdCompany = Convert.ToInt32(vClientes["id_cliente", vClientes.CurrentCell.RowIndex].Value.ToString());
            Cliente pCliente = ClienteDal.ObtenerCliente(nIdCompany);

            txtRazonSocial.Text = pCliente.razon_social;
            txtNombre.Text = pCliente.nombre;
            txtCalle.Text = pCliente.calle;
            txtNumExt.Text = pCliente.n_ext;
            txtNumInt.Text = pCliente.n_int;
            txtCp.Text = pCliente.cp;
            txtColonia.Text = pCliente.colonia;
            txtPoblacion.Text = pCliente.localidad;
            txtMunicipio.Text = pCliente.municipio;
            txtEstado.Text = pCliente.estado;
            txtTelefono.Text = pCliente.telefono;
            txtRfc.Text = pCliente.rfc;
            txtMail.Text = pCliente.email;
            clienteActual = nIdCompany;
            fPreparaEdit();
        }

       
        

       

       

       
    }
}
