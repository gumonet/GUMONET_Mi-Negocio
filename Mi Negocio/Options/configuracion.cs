using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Options
{
    class Configuracion
    {
        public Int32 id_cfg { get; set; }
        public String regimen { get; set; }
        public String nombre { get; set; }
        public String rfc { get; set; }
        public String calle { get; set; }
        public String n_ext { get; set; }
        public String n_int { get; set; }
        public String colonia { get; set; }
        public String cp { get; set; }
        public String localidad { get; set; }
        public String municipio { get; set; }
        public String estado { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public decimal iva { get; set; }
        public decimal ieps { get; set; }
        public decimal ret_iva { get; set; }
        public decimal ret_isr { get; set; }
        public String lugar_expedicion { get; set; }
        public String factura_serie { get; set; }
        public Int32 factura_folio { get; set; }
        public Int32 tipo_logo { get; set; }
        public String path_cer { get; set; }
        public String path_key { get; set; }
        public String sello_pass { get; set; }
        public String cadena_cer { get; set; }
        public String num_cer { get; set; }
        public String logo_cuadrado { get; set; }
        public String logo_banner { get; set; }
        public Int32 cot_folio { get; set; }
        public String cot_serie { get; set; }
        public Int32 ventas_folio { get; set; }
        public String ventas_serie { get; set; }
        public String timbre_user { get; set; }
        public String timbre_pass { get; set; }

        public Configuracion() { }

        public Configuracion(Int32 id_cfg, String regimen, String nombre, String rfc, String calle, String n_ext, String n_int, String colonia, String cp, String localidad, String municipio, String estado, String telefono, String email, decimal iva, decimal ieps, decimal ret_iva, decimal ret_isr, String lugar_expedicion, String factura_serie, Int32 factura_folio, Int32 tipo_logo, String path_cer, String path_key, String sello_pass, String cadena_cer, String num_cer, String logo_cuadrado, String logo_banner, Int32 cot_folio, String cot_serie, Int32 ventas_folio, String ventas_serie, String timbre_user, String timbre_pass)
        {
            this.id_cfg = id_cfg;
            this.regimen = regimen;
            this.nombre = nombre;
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
            this.iva = iva;
            this.ieps = ieps;
            this.ret_iva = ret_iva;
            this.ret_isr = ret_isr;
            this.lugar_expedicion = lugar_expedicion;
            this.factura_serie = factura_serie;
            this.factura_folio = factura_folio;
            this.tipo_logo = tipo_logo;
            this.path_cer = path_cer;
            this.path_key = path_key;
            this.sello_pass = sello_pass;
            this.cadena_cer = cadena_cer;
            this.num_cer = num_cer;
            this.logo_cuadrado = logo_cuadrado;
            this.logo_banner = logo_banner;
            this.cot_folio = cot_folio;
            this.cot_serie = cot_serie;
            this.ventas_folio = ventas_folio;
            this.ventas_serie = ventas_serie;
            this.timbre_user = timbre_user;
            this.timbre_pass = timbre_pass;
        }
    }
}
