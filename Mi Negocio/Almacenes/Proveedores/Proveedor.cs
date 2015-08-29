﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Almacenes.Proveedores
{
    class Proveedor
    {
        public int id_proveedor { get; set; }
        public string nombre { get; set; }
        public string encargado { get; set; }
        public string razon_social { get; set; }
        public string rfc { get; set; }
        public string calle { get; set; }
        public string n_ext { get; set; }
        public string n_int { get; set; }
        public string colonia { get; set; }
        public string cp { get; set; }
        public string localidad { get; set; }
        public string municipio { get; set; }
        public string estado { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public Proveedor()
        {

        }
        public Proveedor(int id_proveedor, string nombre, string encargado, string razon_social, string rfc, string calle, string n_ext, string n_int, string colonia, string cp, string localidad, string municipio, string estado, string telefono, string email)
        {
            this.id_proveedor = id_proveedor;
            this.nombre = nombre;
            this.encargado = encargado;
            this.razon_social = razon_social;
            this.rfc = rfc;
            this.calle = calle;
            this.n_ext = n_ext;
            this.n_int = n_int;
            this.colonia = colonia;
            this.cp = cp;
            this.localidad = localidad;
            this.municipio = municipio;
            this.estado = estado;
            this.telefono = telefono;
            this.email = email;
        }
    }
}
