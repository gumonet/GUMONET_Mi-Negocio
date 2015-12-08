using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Contabilidad
{
    class Cuenta
    {
        public int id_cuenta { get; set; }
        public String nombre { get; set; }
        public  String descripcion { get; set; }

        public Cuenta() { }
        public Cuenta(int id_cuenta, String nombre, String descripcion)
        {
            this.id_cuenta = id_cuenta;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}
