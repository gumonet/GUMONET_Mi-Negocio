using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Cotizaciones
{
    class Cotizacion 
    {
        public Int64 id_cotizacion{ get; set;}
         public int id_cliente{ get; set;}
         public String folio{ get; set;}
         public DateTime fecha{ get; set;}
         public Decimal importe_sub{ get; set;}
         public Decimal iva_tras { get; set; }
         public Decimal ieps { get; set; }
         public Decimal total { get; set; }
         public String metodo_pago{ get; set;}
         public int status{ get; set;}
         public String forma_pago{ get; set;}
         public String condicion_pago{ get; set;}
         public String condicion_embarque{ get; set;}
         public String plazo_entrega{ get; set;}
         public int tipo{ get; set;}
         public Decimal importe_desc { get; set; }

        /*for view Variabls*/
         public String rfc { get; set; }
         public String cliente { get; set; }
        public Cotizacion() { }

        public Cotizacion(Int64 id_cotizacion, int id_cliente, String folio,  DateTime fecha, Decimal importe_sub,
            Decimal iva_tras,  Decimal ieps,  Decimal total, 
            String metodo_pago, int status, String forma_pago, String condicion_pago, String condicion_embarque, 
            String plazo_entrega, int tipo,  Decimal importe_desc)
        {
            this.id_cotizacion = id_cotizacion;
            this.id_cliente = id_cliente;
            this.folio = folio;
            this.fecha = fecha;
            this.importe_sub = importe_sub;
            this.iva_tras = iva_tras;
            this.ieps = ieps;
            this.total = total;
            this.metodo_pago = metodo_pago;
            this.status = status;
            this.forma_pago = forma_pago;
            this.condicion_pago = condicion_pago;
            this.condicion_embarque = condicion_embarque;
            this.plazo_entrega = plazo_entrega;
            this.tipo = tipo;
            this.importe_desc = importe_desc;
        }
    }
}
