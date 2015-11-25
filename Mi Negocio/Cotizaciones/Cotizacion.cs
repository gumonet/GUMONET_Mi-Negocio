using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Cotizaciones
{
    class Cotizacion
    {
        public Int64 id_cotizacion { get; set; }
        public String folio { get; set; }
        public int id_cliente { get; set; }
        public DateTime fecha { get; set; }
        public String condicion_pago { get; set; }
        public String plazo_entrega { get; set; }
        public String cond_embarque { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
        public int status { get; set; }
        public String forma_pago { get; set; }
        public String metodo_pago { get; set; }
        public decimal ieps { get; set; }

        /*Custom fields*/
        public string cliente { get; set; }
        public string str_status { get; set; }

        public Cotizacion()
        {

        }
        public Cotizacion(int id_cotizacion, String folio, int id_cliente, DateTime fecha, String condicion_pago, String plazo_entrega, String cond_embarque, decimal subtotal, decimal iva, decimal total, int status, String forma_pago, String metodo_pago, Decimal ieps)
        {
            this.id_cotizacion = id_cotizacion;
            this.folio = folio;
            this.id_cliente = id_cliente;
            this.fecha = fecha;
            this.condicion_pago = condicion_pago;
            this.plazo_entrega = plazo_entrega;
            this.cond_embarque = cond_embarque;
            this.subtotal = subtotal;
            this.iva = iva;
            this.total = total;
            this.status = status;
            this.forma_pago = forma_pago;
            this.metodo_pago = metodo_pago;
            this.ieps = ieps;
        }
    }
}
