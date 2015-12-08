using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Almacenes.Productos
{
    class Producto
    {
        public int id_producto { get; set; }
        public string identificador { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string unidad_medida { get; set; }
        public string n_parte { get; set; }
        public int tipo { get; set; }
        public int id_categoria { get; set; }
        public int id_provedor { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public decimal inventario_alto { get; set; }
        public decimal inventario_bajo { get; set; }
        public Producto()
        {

        }

        public Producto(int id_producto, string identificador, string nombre, string descripcion, string unidad_medida, string n_parte, int tipo, int id_categoria, int id_provedor, decimal precio_compra, decimal precio_venta, decimal inventario_alto, decimal inventario_bajo)
        {
            this.id_producto = id_producto;
            this.identificador = identificador;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.unidad_medida = unidad_medida;
            this.n_parte = n_parte;
            this.tipo = tipo;
            this.id_categoria = id_categoria;
            this.id_provedor = id_provedor;
            this.precio_compra = precio_compra;
            this.precio_venta = precio_venta;
            this.inventario_alto = inventario_alto;
            this.inventario_bajo = inventario_bajo;
        }
    }
}
