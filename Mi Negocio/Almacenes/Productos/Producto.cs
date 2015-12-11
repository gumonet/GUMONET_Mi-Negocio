using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Almacenes.Productos
{
    class Producto
    {
        public Int64 id_producto { get; set; }
        public String identificador { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string unidad_medida { get; set; }
        public string n_parte { get; set; }
        public int tipo { get; set; }
        public int id_categoria { get; set; }
        public String  proveedor { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public decimal inventario_bajo { get; set; }
        public decimal iva { get; set; }
        public decimal ieps { get; set; }
        public String imagen { get; set; }

        public Decimal existencia { get; set; }

        public String categoria { get; set; }

        public Producto()
        {

        }

        public Producto(int id_producto, string identificador, string nombre, string descripcion, string unidad_medida, string n_parte, int tipo, int id_categoria,
            String proveedor, decimal precio_compra, decimal precio_venta, decimal inventario_bajo, Decimal iva, Decimal ieps, String imagen, Decimal existencia, String categoria)
        {
            this.id_producto = id_producto;
            this.identificador = identificador;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.unidad_medida = unidad_medida;
            this.n_parte = n_parte;
            this.tipo = tipo;
            this.id_categoria = id_categoria;
            this.proveedor = proveedor;
            this.precio_compra = precio_compra;
            this.precio_venta = precio_venta;
            this.inventario_bajo = inventario_bajo;
            this.iva = iva;
            this.ieps = ieps;
            this.imagen = imagen;
            this.existencia = existencia;
            this.categoria = categoria;
        }
    }
}
