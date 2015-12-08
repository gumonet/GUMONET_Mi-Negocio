using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Contabilidad
{
    class Categoria
    {
        public int id_categoria { get; set; }
        public String nombre { get; set; }
        public String color { get; set; }
        public String descripcion { get; set; }

        public Categoria() { }
        public Categoria(int id_categoria, String nombre, String color, String descripcion)
        {
            this.id_categoria = id_categoria;
            this.nombre = nombre;
            this.color = color;
            this.descripcion = descripcion;
        }
    }
}
