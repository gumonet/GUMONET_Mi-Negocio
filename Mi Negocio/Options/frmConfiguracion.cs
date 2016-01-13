using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mi_Negocio.Options
{
    public partial class frmConfiguracion : Form
    {
        public Int32 IdEmpresa { get; set; }
        public frmConfiguracion()
        {
            
            InitializeComponent();
        }
        /*Custom Functiosn*/
        private void fLoadData()
        {
            /*--Pestaña empresa*/
            this.IdEmpresa = 1;
            Configuracion pData = ConfiguracionDal.Obtener(this.IdEmpresa);
            txtRazonSocial.Text = pData.nombre;
            txtRfc.Text = pData.rfc;
            txtCalle.Text = pData.calle;
            txtNumExt.Text = pData.n_ext;
            txtNumInt.Text = pData.n_int;
            txtColonia.Text = pData.colonia;
            txtMunicipio.Text = pData.municipio;
            txtPoblacion.Text = pData.localidad;
            txtEstado.Text = pData.estado;
            txtCp.Text = pData.cp;
            txtMail.Text = pData.email;
            txtTelefono.Text = pData.telefono;

            txtRetIsr.Text = pData.ret_isr.ToString();
            txtRetIva.Text = pData.ret_iva.ToString();

            cotSerie.Text = pData.cot_serie;
            cotFolio.Text = pData.cot_folio.ToString();

            ventSerie.Text = pData.ventas_serie.ToString();
            ventFolio.Text = pData.ventas_folio.ToString();
            
            //Pestaña Logotipo
            txtLogoBaner.Text = pData.logo_banner;
            txtLogoCuadrado.Text = pData.logo_cuadrado;
            if (pData.tipo_logo == 1)
            {
                rbLogoQuadro.Checked = true;
                rbLogoBaner.Checked = false;
            }
            if (pData.tipo_logo == 2)
            {
                rbLogoQuadro.Checked = false;
                rbLogoBaner.Checked = true;
            }

            if (File.Exists(txtLogoBaner.Text.Trim()))
            {
                pbLogoBanner.Image = Image.FromFile(txtLogoBaner.Text);
            }
            if (File.Exists(txtLogoCuadrado.Text.Trim()))
            {
                pbLogoCuadrado.Image = Image.FromFile(txtLogoCuadrado.Text);
            }    
           
            //Pestaña Facturación
            txtExpedicion.Text = pData.lugar_expedicion;
            txtRegimen.Text = pData.regimen;
            txtCertificado.Text = pData.path_cer;
            txtLlave.Text = pData.path_key;
            txtNumeroCertificado.Text = pData.num_cer;
            txtCadenaCertificado.Text = pData.cadena_cer;

            

            //Pestaña Otros
        }

        private void saveEmpresa()
        {
            Configuracion pData = new Configuracion();
            pData.nombre = txtRazonSocial.Text;
            pData.rfc = txtRfc.Text;
            pData.calle = txtCalle.Text;
            pData.n_ext = txtNumExt.Text;
            pData.n_int = txtNumInt.Text;
            pData.colonia = txtColonia.Text;
            pData.municipio = txtMunicipio.Text;
            pData.localidad = txtPoblacion.Text;
            pData.estado = txtEstado.Text;
            pData.cp = txtCp.Text;
            pData.email = txtMail.Text;
            pData.telefono = txtTelefono.Text;

            pData.ret_isr = Convert.ToDecimal(txtRetIsr.Text);
            pData.ret_iva = Convert.ToDecimal(txtRetIva.Text);

            pData.cot_serie = cotSerie.Text;
            pData.cot_folio = Convert.ToInt32(cotFolio.Text);

            pData.ventas_serie = ventSerie.Text;
            pData.ventas_folio = Convert.ToInt32(ventFolio.Text);
            pData.id_cfg = this.IdEmpresa;

            int resultado = ConfiguracionDal.updateEmpresa(pData);
            if (resultado > 0)
            {
                MessageBox.Show("Configuración Actualizado Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error al Actualizar la Configuración", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void saveFacturacion()
        {
            Configuracion pData = new Configuracion();
            pData.lugar_expedicion = txtExpedicion.Text;
            pData.regimen = txtRegimen.Text;
            pData.path_cer = txtCertificado.Text;
            pData.path_key = txtLlave.Text;
            pData.sello_pass = selloPass.Text;
            pData.num_cer = txtNumeroCertificado.Text;
            pData.cadena_cer = txtCadenaCertificado.Text;
            pData.factura_serie = factSerie.Text;
            pData.factura_folio = Convert.ToInt32(factFolio.Text);
            pData.timbre_user = timbreUser.Text;
            pData.timbre_pass = timbrePass.Text;
            pData.id_cfg = this.IdEmpresa;

            ConfiguracionDal.saveFacturacion(pData);
            
        }
        /*End custom functions*/
        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            fLoadData();
        }

        private void btnSaveLogo_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            if (rbLogoBaner.Checked)
            {
                tipo = 2;
            }
            if (rbLogoQuadro.Checked)
            {
                tipo = 1;
            }
            if (tipo > 0)
            {
                if (ConfiguracionDal.setLogos(txtLogoCuadrado.Text.Replace(@"\", @"\\"), txtLogoBaner.Text.Replace(@"\", @"\\"), tipo, this.IdEmpresa) > 0)
                {
                    MessageBox.Show("Configuración Almacenada Exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrio un Error al Guardar la Configuración", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Porfavor Seleccione una Opción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSaveCertificado_Click(object sender, EventArgs e)
        {
            saveFacturacion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveEmpresa();
        }

        
    }
}
