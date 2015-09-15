using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mi_Negocio.frmCotizaciones
{
    public partial class frmDetalle : Form
    {
        private int empresa_actual { get; set; }
        public frmDetalle()
        {
            InitializeComponent();
        }

        private void frmCotizaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            floadFacturas();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dataFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fAbrirFactura();
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAbrirFactura();
        }

        //Custom functions

        private void fAbrirFactura()
        {
            string idCotizacion = dataFacturas["id_cotizacion", dataFacturas.CurrentCell.RowIndex].Value.ToString();
            frmDetalle det = new frmDetalle();
            det.idCotizacion = this.idCotizacion;
            if (det.ShowDialog() != DialogResult.OK) //se coloca OK solo para que siempre se ejecute, por que el formulario no regresa nada
            {
                floadFacturas();
            }

        }
        private void fDeleteFactura()
        {
            int status_factura = Convert.ToInt32(dataFacturas["timbrado", dataFacturas.CurrentCell.RowIndex].Value.ToString());
            if (status_factura == 1)
            {
                string idFactura = dataFacturas["id_factura", dataFacturas.CurrentCell.RowIndex].Value.ToString();
                if (MessageBox.Show("¿Esta seguro de Eliminar la Factura?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (CotizacionDal.eliminar(idFactura) > 0)
                    {
                        MessageBox.Show("La Factura Fue Eliminada con Exito", "Factura Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        floadFacturas();
                    }
                }
            }
            else
            {
                MessageBox.Show("La factrua no puede ser eliminada \n Ya ha sido timbrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalle det = new frmDetalle();
            det.empresa_actual = this.empresa_actual;
            if (det.ShowDialog() != DialogResult.OK) //se coloca OK solo para que siempre se ejecute, por que el formulario no regresa nada
            {
                floadFacturas();
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este se debe de analizar");
            /*frmCliemtes wClientes = new frmCliemtes();
            wClientes.ShowDialog();*/
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este se debe de analizar");
           /* frmConfig wConfig = new frmConfig(this.empresa_actual);
            wConfig.ShowDialog();*/
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDeleteFactura();
        }

        private void floadFacturas()
        {
            string searchDate = "fecha BETWEEN '" + Convert.ToDateTime(dateInicio.Text).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dateFinal.Text).ToString("yyyy-MM-dd") + "' ";
            dataFacturas.AutoGenerateColumns = false;
            dataFacturas.DataSource = FacturaDal.buscar(this.empresa_actual, searchDate, txtSearch.Text);
            foreach (DataGridViewRow row in dataFacturas.Rows)
            {
                switch (Convert.ToInt32(row.Cells["timbrado"].Value))
                {
                    case 1: row.DefaultCellStyle.BackColor = Color.LightBlue; break;
                    case 2: row.DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case 3: row.DefaultCellStyle.BackColor = Color.Red; break;

                }

            }

            //this.datagridview1.selectedrows[0].cells[0].selected = false;
            //dataFacturas.SelectedRows[0].Cells[0].Selected = false;
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            frmCotizacion det = new frmCotizacion();
            det.empresa_actual = this.empresa_actual;
            if (det.ShowDialog() != DialogResult.OK) //se coloca OK solo para que siempre se ejecute, por que el formulario no regresa nada
            {
                floadFacturas();
            }
        }

    /*    private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dataFacturas.RowCount > 0)
            {
                if (Convert.ToInt32(dataFacturas["timbrado", dataFacturas.CurrentCell.RowIndex].Value.ToString()) == 2)
                {
                    factura_cfdi cfdi = new factura_cfdi();
                    string serie_folio = dataFacturas["folio", dataFacturas.CurrentCell.RowIndex].Value.ToString();
                    try
                    {
                        cfdi.showPDF(@"C:\gumonet-factura\Archivos\" + this.empresa_actual + @"\facturas\" + serie_folio + ".pdf");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Factura aun no ha sido Timbrada", "¡ Error al Imprimir !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("No existen facturas para imprimir", "¡ Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        */
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (dataFacturas.RowCount > 0)
            {
                if (Convert.ToInt32(dataFacturas["timbrado", dataFacturas.CurrentCell.RowIndex].Value.ToString()) == 2)
                {
                    string serie_folio = dataFacturas["folio", dataFacturas.CurrentCell.RowIndex].Value.ToString();
                    string email = dataFacturas["email", dataFacturas.CurrentCell.RowIndex].Value.ToString();
                    if (EnviarMail.sendMail(this.empresa_actual, this.empresaActual.rfc, serie_folio, email))
                    {
                        MessageBox.Show("Factura Enviada Correctamente a: " + email, "Factura Enviada");
                    }
                    else
                    {

                        MessageBox.Show("No se pudo enviar el Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Factura aun no ha sido Timbrada", "¡ Error al Enviar !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No existen facturas para enviar", "¡ Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

    }
}
