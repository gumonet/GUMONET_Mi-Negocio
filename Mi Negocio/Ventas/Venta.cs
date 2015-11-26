using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Ventas
{
    class Venta
    {
         public Int64 id_venta{ get; set;}
         public int id_cliente{ get; set;}
         public String folio_venta{ get; set;}
         public String folio_cotizacion{ get; set;}
         public DateTime fecha_cotizacion{ get; set;}
         public DateTime fecha{ get; set;}
         public Decimal importe_sub{ get; set;}
         public Decimal iva_tras { get; set; }
         public Decimal iva_ret { get; set; }
         public Decimal isr_tras { get; set; }
         public Decimal ieps { get; set; }
         public Decimal isr_ret { get; set; }
         public Decimal total { get; set; }
         public String metodo_pago{ get; set;}
         public int status{ get; set;}
         public String forma_pago{ get; set;}
         public String condicion_pago{ get; set;}
         public String condicion_embarque{ get; set;}
         public String plazo_entrega{ get; set;}
         public int tipo{ get; set;}
         public String num_cta{ get; set;}
         public Decimal importe_desc { get; set; }
         public int facturado{ get; set;}

        public Venta() { }

        public Venta(Int64 id_venta, int id_cliente, String folio_venta, String folio_cotizacion, DateTime fecha_cotizacion, DateTime fecha, Decimal importe_sub, Decimal iva_tras, Decimal iva_ret, Decimal isr_tras, Decimal ieps, Decimal isr_ret, Decimal total, String metodo_pago, int status, String forma_pago, String condicion_pago, String condicion_embarque, String plazo_entrega, int tipo, String num_cta, Decimal importe_desc, int facturado) {
            this.id_venta = id_venta;
            this.id_cliente = id_cliente;
            this.folio_venta = folio_venta;
            this.folio_cotizacion = folio_cotizacion;
            this.fecha_cotizacion = fecha_cotizacion;
            this.fecha = fecha;
            this.importe_sub = importe_sub;
            this.iva_tras = iva_tras;
            this.iva_ret = iva_ret;
            this.isr_tras = isr_tras;
            this.ieps = ieps;
            this.isr_ret = isr_ret;
            this.total = total;
            this.metodo_pago = metodo_pago;
            this.status = status;
            this.forma_pago = forma_pago;
            this.condicion_pago = condicion_pago;
            this.condicion_embarque = condicion_embarque;
            this.plazo_entrega = plazo_entrega;
            this.tipo = tipo;
            this.num_cta = num_cta;
            this.importe_desc = importe_desc;
            this.facturado = facturado; 
        }



    }
}
