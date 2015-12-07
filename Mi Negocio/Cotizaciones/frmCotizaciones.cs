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
    public partial class frmCotizaciones : Form
    {
        public frmCotizaciones()
        {
            InitializeComponent();
        }

        private void frmCotizaciones_Load(object sender, EventArgs e)
        {
            dateFinal.Text = (DateTime.Now.AddDays(1)).ToString();
            floadCotizaciones();            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            floadCotizaciones();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dataCotizaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
           Int64 id_cotizacion = Convert.ToInt64(dataCotizaciones["id_cotizacion", dataCotizaciones.CurrentCell.RowIndex].Value);
            frmDetalle det = new frmDetalle();
            det.id_cotizacion = id_cotizacion;
            if (det.ShowDialog() != DialogResult.OK) //se coloca OK solo para que siempre se ejecute, por que el formulario no regresa nada
            {
                floadCotizaciones();
            }

        }
        private void fDeleteFactura()
        {
            int status_factura = Convert.ToInt32(dataCotizaciones["timbrado", dataCotizaciones.CurrentCell.RowIndex].Value.ToString());
            if (status_factura == 1)
            {
                Int64 id_cotizacion = Convert.ToInt64(dataCotizaciones["id_cotizacion", dataCotizaciones.CurrentCell.RowIndex].Value);
                if (MessageBox.Show("¿Esta seguro de Eliminar la Factura?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (CotizacionDal.eliminar(id_cotizacion) > 0)
                    {
                        MessageBox.Show("La Factura Fue Eliminada con Exito", "Factura Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        floadCotizaciones();
                    }
                }
            }
            else
            {
                MessageBox.Show("La factrua no puede ser eliminada \n Ya ha sido timbrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

       /* private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetalle det = new frmDetalle();
            det.id_cotizacion = this.empresa_actual;
            if (det.ShowDialog() != DialogResult.OK) //se coloca OK solo para que siempre se ejecute, por que el formulario no regresa nada
            {
                floadCotizaciones();
            }

        }*/

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

        private void floadCotizaciones()
        {
            string searchDate = " AND fecha BETWEEN '" + Convert.ToDateTime(dateInicio.Text).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(dateFinal.Text).ToString("yyyy-MM-dd") + "' ";
            dataCotizaciones.AutoGenerateColumns = false;
            dataCotizaciones.DataSource = CotizacionDal.buscar(txtSearch.Text, searchDate );
            /*foreach (DataGridViewRow row in dataCotizaciones.Rows)
            {
                switch (Convert.ToInt32(row.Cells["timbrado"].Value))
                {
                    case 1: row.DefaultCellStyle.BackColor = Color.LightBlue; break;
                    case 2: row.DefaultCellStyle.BackColor = Color.LightGreen; break;
                    case 3: row.DefaultCellStyle.BackColor = Color.Red; break;

                }

            }*/

            //this.datagridview1.selectedrows[0].cells[0].selected = false;
            //dataCotizaciones.SelectedRows[0].Cells[0].Selected = false;
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            frmDetalle det = new frmDetalle();
            det.id_cotizacion = 0;
            if (det.ShowDialog() != DialogResult.OK) //se coloca OK solo para que siempre se ejecute, por que el formulario no regresa nada
            {
                floadCotizaciones();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {/*
            if (dataCotizaciones.RowCount > 0)
            {
                if (Convert.ToInt32(dataCotizaciones["timbrado", dataCotizaciones.CurrentCell.RowIndex].Value.ToString()) == 2)
                {
                    factura_cfdi cfdi = new factura_cfdi();
                    string serie_folio = dataCotizaciones["folio", dataCotizaciones.CurrentCell.RowIndex].Value.ToString();
                    try
                    {
                        cfdi.showPDF(@"C:\gumonet-factura\Archivos\" + this.empresa_actual + @"\Cotizaciones\" + serie_folio + ".pdf");
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
                MessageBox.Show("No existen Cotizaciones para imprimir", "¡ Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
        }
        
        private void btnEnviar_Click(object sender, EventArgs e)
        {/*
            if (dataCotizaciones.RowCount > 0)
            {
                if (Convert.ToInt32(dataCotizaciones["timbrado", dataCotizaciones.CurrentCell.RowIndex].Value.ToString()) == 2)
                {
                    string serie_folio = dataCotizaciones["folio", dataCotizaciones.CurrentCell.RowIndex].Value.ToString();
                    string email = dataCotizaciones["email", dataCotizaciones.CurrentCell.RowIndex].Value.ToString();
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
                MessageBox.Show("No existen Cotizaciones para enviar", "¡ Alerta !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

*/
        }

    }
}
