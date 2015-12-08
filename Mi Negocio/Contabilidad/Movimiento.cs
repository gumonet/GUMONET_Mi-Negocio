using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Contabilidad
{
    class Movimiento
    {
        public Int64 id_movimiento { get; set; }
         public String nombre { get; set; }
        public String concepto { get; set; }
        public Decimal monto { get; set; }
        public int id_categoria { get; set; }
        public int id_cuenta { get; set; }
        public DateTime fecha { get; set; }
        public String adjunto { get; set; }
        public String metodo_pago { get; set; }
        public int tipo { get; set; }
        public int id_usuario { get; set; }

        /*Only data view*/
        public String categoria { get; set; }
        public String cuenta { get; set; }
        public String usuario { get; set; }

        public Movimiento() { }
        public Movimiento(Int64 id_movimiento, int id_usuario, String nombre, String concepto, Decimal monto, int id_categoria, int id_cuenta, DateTime fecha, String adjunto, String metodo_pago, int tipo)
        {
            this.id_movimiento = id_movimiento;
            this.nombre = nombre;
            this.concepto = concepto;
            this.monto = monto;
            this.id_categoria = id_categoria;
            this.id_cuenta = id_cuenta;
            this.fecha = fecha;
            this.adjunto = adjunto;
            this.metodo_pago = metodo_pago;
            this.tipo = tipo;
            this.id_usuario = id_usuario;

        }
    }
}
