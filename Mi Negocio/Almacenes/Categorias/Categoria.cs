using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Almacenes.Categorias
{
    class Categoria
    {
        public int id_categoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Categoria(){

        }
        public Categoria( int id_categoria, string nombre, string descripcion)
        {
            this.id_categoria = id_categoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

    }
}
