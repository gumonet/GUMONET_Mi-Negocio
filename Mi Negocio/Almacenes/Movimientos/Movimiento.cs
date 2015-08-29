using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Almacenes.Movimientos
{
    class Movimiento
    {
        public int  id_movimiento { get; set; }
        public int tipo { get; set; }
        public string descripcion { get; set; }
        public string responsable { get; set; }
        public DateTime fecha { get; set; }

        public Movimiento(){

        }
        public Movimiento(int id_movimiento, int tipo, string descripcion, string responsable, DateTime fecha)
        {
            this.id_movimiento = id_movimiento;
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.responsable = responsable;
            this.fecha = fecha;
        }
    }
}
