using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Cotizaciones
{
    class Detalle
    {
        public Int64 id_detalle { get; set; }
        public Int64 id_cotizacion { get; set; }
        public Int64 id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal importe_iva { get; set; }
        public decimal precio { get; set; }
        public decimal importe_ieps { get; set; }

        public Detalle(Int64 id_detalle, Int64 id_cotizacion, Int64 id_producto, int cantidad, decimal importe_iva, decimal precio, decimal importe_ieps) {
            this.id_detalle = id_detalle;
            this.id_cotizacion = id_cotizacion;
            this.id_producto = id_producto;
            this.cantidad = cantidad;
            this.importe_iva = importe_iva;
            this.precio = precio;
            this.importe_ieps = importe_ieps; 
        }

        public Detalle()
        {

        }


    }
}
