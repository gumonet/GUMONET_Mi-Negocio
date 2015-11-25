using Mi_Negocio.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mi_Negocio.Cotizaciones
{
    public partial class frmDetalle : Form
    {
        private int idCliente { get; set; }
        private int guardado = 0;
        private String vRfcEmisor;
        private bool isNew { get; set; }
        public Int64 id_cotizacion { get; set; }
        
        
        
        public frmDetalle()
        {
            InitializeComponent();
        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {
            if (this.id_cotizacion == 0)
            {
                createNew();
                this.isNew = true;
            }
            else
            {
               // getData();
                //fLoadConceptos();
                this.guardado = 1;
            }
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
            txtRfc.Text = pCliente.rfc;
            txtEmail.Text = pCliente.email;

        }

        private void btnConceptoAdd_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        /************************************
                    Custom Functios 
         ************************************/
        //Crea una nueva factura
        private void createNew()
        {
            //Obtiene los datos para una nueva cotización.
            Cotizacion pData = new Cotizacion();
            pData.folio = "";
            pData.condicion_pago = "";
            pData.plazo_entrega = "";
            pData.cond_embarque = "";
            pData.subtotal = 0.00m;
            pData.iva = 0.00m;
            pData.total = 0.00m;
            pData.status = 0;
            pData.forma_pago ="";
            pData.metodo_pago = "";

            this.id_cotizacion = CotizacionDal.agregar(pData);


            /*Configuracion cfgFactura = ConfigDal.Obtener(this.empresa_actual);
            Facturas pData = new Facturas();
            pData.id_factura = id_factura;
            pData.idcfg = this.empresa_actual;
            int tmpFolio = (cfgFactura.folio_actual + 1);
            pData.folio = Convert.ToString(tmpFolio);
            pData.serie = cfgFactura.serie;
            pData.timbrado = 0;
            pData.lugar_expedicion = cfgFactura.lugar_expedicion;
            pData.moneda = "MXN";
            pData.tipo_cambio = "1.00";
            pData.tasa_iva = cfgFactura.iva;
            pData.tasa_ieps = cfgFactura.ieps;
            pData.importe_subtotal = 0.00m;
            pData.importe_total = 0.00m;
            pData.importe_iva_tras = 0.00m;
            pData.importe_ieps_tras = 0.00m;

            //Agrega una nueva factura
            FacturaDal.agregar(pData);//Crea la instancia de una factura nueva
            //Aumentar Folio
            ConfigDal.setFolio(this.empresa_actual, tmpFolio);
            getData();//Obtiene los datos de la factura creada

            this.guardado = 0;/*Coloca una variable para saber si la factura se guardo antes de cerrar el formulario*/
        }

        //Optiene los datos de la factura
        /*private void getData()
        {
            Configuracion cfgFactura = ConfigDal.Obtener(this.empresa_actual);
            this.vRfcEmisor = cfgFactura.rfc.ToString();//Se agrego para obtener el nombre que se enviara en el Email
            Facturas factura = FacturaDal.obtener(this.id_factura);
            txtFolio.Text = factura.folio;
            txtIEPS.Text = Convert.ToString(factura.tasa_ieps);
            txtIva.Text = Convert.ToString(factura.tasa_iva);
            txtMoneda.Text = factura.moneda;
            txtCambio.Text = factura.tipo_cambio;
            txtSerie.Text = factura.serie;
            txtFecha.Text = Convert.ToDateTime(factura.fecha).ToString("dd/MM/yyyy");
            txtSubtotal.Text = (factura.importe_subtotal).ToString("$###,##0.##");
            txtTotal.Text = (factura.importe_total).ToString("$###,##0.##");
            txtTotalieps.Text = (factura.importe_ieps_tras).ToString("$###,##0.##");
            txtTotalIva.Text = (factura.importe_iva_tras).ToString("$###,##0.##");
            //condición_lógica ? valor_si_verdadero : valor_si_falso;
            txtCambio.Text = factura.tipo_cambio;
            txtForma.Text = factura.forma_pago;
            txtCondiciones.Text = factura.condiciones_pago;
            txtMetodo.Text = factura.metodo_pago;
            txtNumCta.Text = factura.num_cta;
            txtLugar_exp.Text = factura.lugar_expedicion;
            if (factura.idcliente != 0)
            {
                this.idCliente = factura.idcliente;
                loadDataCliente();
            }
            if (factura.timbrado == 2)
            {
                disableForTimbrado();
                this.svUuid = factura.timbre_uuid;
                pbCbb.ImageLocation = (@"C:\gumonet-factura\Archivos\" + this.empresa_actual + @"\facturas\" + factura.serie + "-" + factura.folio + ".jpg");
            }
            if (factura.timbrado == 3)
            {
                disableCancelado();
            }
            if (factura.timbrado < 2)
            {
                disableNormal();
            }
        }

            //Guardar Factura
        private int saveFactura()
        {
            Configuracion cfgFactura = ConfigDal.Obtener(this.empresa_actual);
            Facturas pData = new Facturas();
            pData.id_factura = this.id_factura;
            pData.moneda = txtMoneda.Text;
            pData.tipo_cambio = txtCambio.Text;
            pData.idcfg = this.empresa_actual;
            pData.idcliente = this.idCliente;
            pData.folio = txtFolio.Text;
            pData.serie = txtSerie.Text;
            pData.timbrado = 1;
            pData.lugar_expedicion = cfgFactura.lugar_expedicion;
            pData.moneda = txtMoneda.Text;
            pData.tipo_cambio = txtCambio.Text;
            pData.forma_pago = txtForma.Text;
            pData.condiciones_pago = txtCondiciones.Text;
            pData.metodo_pago = txtMetodo.Text;
            pData.num_cta = txtNumCta.Text;
            // pData.importe_desc =; Importe descuento
            pData.importe_subtotal = Convert.ToDecimal(txtSubtotal.Text.Replace("$", ""));
            pData.importe_total = Convert.ToDecimal(txtTotal.Text.Replace("$", ""));
            pData.tasa_iva = Convert.ToDecimal(txtIva.Text.Replace("%", ""));
            pData.tasa_ieps = Convert.ToDecimal(txtIEPS.Text.Replace("%", ""));
            //pData.importe_iva_ret = Convert.ToDecimal(txtIva.Text); Importe de iva retenido (Arrendamiento, fletes, etc)
            pData.importe_iva_tras = Convert.ToDecimal(txtTotalIva.Text.Replace("$", ""));
            pData.importe_ieps_tras = Convert.ToDecimal(txtTotalieps.Text.Replace("$", ""));
            //pData.importe_isr_ret = txt;           
            pData.id_factura = this.id_factura;
            return FacturaDal.actualizar(pData);
        }

        //Obtiene los totales y los asigna en los textbox
        private void getTotales()
        {
            decimal dsubtotal= 0.00m;
            decimal dtotalIva = 0.00m;
            decimal dtotalIeps = 0.00m;

            foreach (DataGridViewRow row in dataDetail.Rows)
            {
                dsubtotal += Convert.ToDecimal(row.Cells["v_importe"].Value);
                dtotalIva += Convert.ToDecimal(row.Cells["importe_iva"].Value);
                dtotalIeps += Convert.ToDecimal(row.Cells["importe_ieps"].Value);
            }

            txtSubtotal.Text = dsubtotal.ToString("$##,##0.##");
            txtTotalIva.Text = dtotalIva.ToString("$##,##0.##");
            txtTotalieps.Text = dtotalIeps.ToString("$##,##0.##");
            txtTotal.Text = (dsubtotal + dtotalIva + dtotalIeps).ToString("$##,##0.##");

        }




        /************************************
                  End custom Functios 
        ************************************/
      
    }
}
