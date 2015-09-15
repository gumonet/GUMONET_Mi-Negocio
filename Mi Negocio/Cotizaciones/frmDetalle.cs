using Mi_Negocio.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mi_Negocio.frmDetalle
{
    public partial class frmDetalle : Form
    {
        private int idCliente { get; set; }
        private String vRfcEmisor;
        public int idCotizacion { get; set; }
        public string id_factura { get; set; }
        private int guardado = 1;
        private string svUuid { get; set; }
        private bool isNew { get; set; }
        public frmDetalle()
        {
            InitializeComponent();
        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {

        }

        private void txtRfc_DoubleClick(object sender, EventArgs e)
        {
            frmListClientes listaClientes = new frmListClientes();
            if (listaClientes.ShowDialog() == DialogResult.OK)
            {
                this.idCliente = listaClientes.id_cte;
                this.guardado = 0;//Establece guardado en 0 la factura se modifico y no ha sido guardada
                loadDataCliente();
            }
        }

        /*Custom Functions*/
        //Carga la información del cliente
        private void loadDataCliente()
        {
            Cliente pCliente = ClienteDal.ObtenerCliente(this.idCliente);
            txtRazonSocial.Text = pCliente.nombre;
          //  txtDomicilio.Text = pCliente.calle + ", N. Ext: " + pCliente.n_ext + ", N. Int: " + pCliente.n_int;
            //txtCp.Text = pCliente.cp;
            //txtColonia.Text = pCliente.colonia;
            //txtLocMun.Text = pCliente.localidad + ", " + pCliente.municipio;
            //txtEstado.Text = pCliente.estado;
            txtRfc.Text = pCliente.rfc;
            txtEmail.Text = pCliente.email;

        }

        private void btnConceptoAdd_Click(object sender, EventArgs e)
        {

        }
      
    }
}
