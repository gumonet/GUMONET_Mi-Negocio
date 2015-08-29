using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Cotizaciones
{
    class Cotizacion
    {
        public int id_cotizacion { get; set; }
        public String folio { get; set; }
        public int id_cliente { get; set; }
        public DateTime fecha { get; set; }
        public String condicion_pago { get; set; }
        public String plazo_entrega { get; set; }
        public String cond_embarque { get; set; }
        public String atn { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
        public int status { get; set; }

        public Cotizacion()
        {

        }
        public Cotizacion(int id_cotizacion, String folio, int id_cliente, DateTime fecha, String condicion_pago, String plazo_entrega, String cond_embarque, String atn, decimal subtotal, decimal iva, decimal total, int status)
        {
            this.id_cotizacion = id_cotizacion;
            this.folio = folio;
            this.id_cliente = id_cliente;
            this.fecha = fecha;
            this.condicion_pago = condicion_pago;
            this.plazo_entrega = plazo_entrega;
            this.cond_embarque = cond_embarque;
            this.atn = atn;
            this.subtotal = subtotal;
            this.iva = iva;
            this.total = total;
            this.status = status;
        }
    }
}
