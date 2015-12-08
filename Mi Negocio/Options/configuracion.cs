using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Options
{
    class Configuracion
    {
        public int id_cfg { set; get; }
        public string regimen { set; get; }
        public string nombre { set; get; }
        public string rfc { set; get; }
        public string calle { set; get; }
        public string n_ext { set; get; }
        public string n_int { set; get; }
        public string colonia { set; get; }
        public string cp { set; get; }
        public string localidad { set; get; }
        public string municipio { set; get; }
        public string estado { set; get; }
        public string telefono { set; get; }
        public string email { set; get; }
        public decimal iva { set; get; }
        public decimal ieps { set; get; }
        public decimal ret_iva { set; get; }
        public decimal ret_isr { set; get; }
        public string lugar_expedicion { set; get; }
        public string serie { set; get; }
        public int folio_actual { set; get; }
        public string folio_final { set; get; }
       public int foto_perfil { set; get; }
      public string path_cer { set; get; }
       public string path_key  { set; get; }
       public string sello_pass { set; get; }
       public string logo_cuadrado { set; get; }
       public string logo_banner { set; get; }
       public string cadena_cer { set; get; }
       public string num_cer { set; get; }

        public Configuracion() { }

        public Configuracion(int id_cfg, string regimen, string nombre, string rfc, string calle, string n_ext, string n_int, string colonia, string cp, string localidad, string municipio, string estado, string telefono, string email, decimal iva, decimal ieps, decimal ret_iva, decimal ret_isr, string lugar_expedicion, string serie, int folio_actual, string folio_final
            , int foto_perfil, string path_cer, string path_key, string sello_pass, string logo_cuadrado, string logo_banner, string cadena_cer, string num_cer)
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
            this.serie = serie;
            this.folio_actual = folio_actual;
            this.folio_final = folio_final;
            this.foto_perfil = foto_perfil;
            this.path_cer = path_cer;
            this.path_key=path_key;
            this.sello_pass = sello_pass;
            this.logo_cuadrado = logo_cuadrado;
            this.logo_banner = logo_banner;
            this.cadena_cer = cadena_cer;
            this.num_cer = num_cer;
        }
    }
}
