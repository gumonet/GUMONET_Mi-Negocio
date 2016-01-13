using Mi_Negocio.Datasource;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Options
{
    class ConfiguracionDal
    {
        public static int Agregar(Configuracion pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format(
           "INSERT INTO cfg (regimen, nombre, rfc, calle, n_ext, n_int, colonia, cp, localidad, municipio, estado, telefono, email,  ret_iva, ret_isr, lugar_expedicion, factura_serie, factura_folio, tipo_logo, path_cer, path_key, sello_pass, cadena_cer, num_cer, logo_cuadrado, logo_banner, cot_folio, cot_serie, ventas_folio, ventas_serie, timbre_user, timbre_pass) " +
             "VALUES('{0}'" +
                 ",'{1}'" +
                 ",'{2}'" +
                 ",'{3}'" +
                 ",'{4}'" +
                 ",'{5}'" +
                 ",'{6}'" +
                 ",'{7}'" +
                 ",'{8}'" +
                 ",'{9}'" +
                 ",'{10}'" +
                 ",'{11}'" +
                 ",'{12}'" +
                 ",'{13}'" +
                 ",'{14}'" +
                 ",'{15}'" +
                 ",'{16}'" +
                 ",'{17}'" +
                 ",'{18}'" +
                 ",'{19}'" +
                 ",'{20}'" +
                 ",'{21}'" +
                 ",'{22}'" +
                 ",'{23}'" +
                 ",'{24}'" +
                 ",'{25}'" +
                 ",'{26}'" +
                 ",'{27}'" +
                 ",'{28}'" +
                 ",'{29}'" +
                 ",'{30}'" +
                 ",'{31}'" +
                ")"
                ,
pData.regimen,
pData.nombre,
pData.rfc,
pData.calle,
pData.n_ext,
pData.n_int,
pData.colonia,
pData.cp,
pData.localidad,
pData.municipio,
pData.estado,
pData.telefono,
pData.email,
pData.ret_iva,
pData.ret_isr,
pData.lugar_expedicion,
pData.factura_serie,
pData.factura_folio,
pData.tipo_logo,
pData.path_cer,
pData.path_key,
pData.sello_pass,
pData.cadena_cer,
pData.num_cer,
pData.logo_cuadrado,
pData.logo_banner,
pData.cot_folio,
pData.cot_serie,
pData.ventas_folio,
pData.timbre_user,
pData.timbre_pass
), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static List<Configuracion> Buscar()
        {
            List<Configuracion> _lista = new List<Configuracion>();
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format(
                "SELECT  id_cfg, nombre,  rfc  FROM cfg"), conexion);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Configuracion pData = new Configuracion();
                pData.id_cfg = reader.GetInt32(0);
                pData.nombre = reader.GetString(1);
                pData.rfc = reader.GetString(2);

                _lista.Add(pData);
            }

            conexion.Close();
            return _lista;
        }

        //
        public static Configuracion Obtener(int pId)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
            Configuracion pData = new Configuracion();

            MySqlCommand cmd = new MySqlCommand(String.Format("select regimen, nombre, rfc, calle, n_ext, n_int, colonia, cp, localidad, municipio, estado, telefono, email, ret_iva, ret_isr, lugar_expedicion, factura_serie, factura_folio, tipo_logo, path_cer, path_key, sello_pass, cadena_cer, num_cer, logo_cuadrado, logo_banner, cot_folio, cot_serie, ventas_folio, ventas_serie,timbre_user, timbre_pass FROM cfg_configuracion where id_cfg = {0} ", pId), conexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pData.regimen = reader.GetString(0);
                pData.nombre = reader.GetString(1);
                pData.rfc = reader.GetString(2);
                pData.calle = reader.GetString(3);
                pData.n_ext = reader.GetString(4);
                pData.n_int = reader.GetString(5);
                pData.colonia = reader.GetString(6);
                pData.cp = reader.GetString(7);
                pData.localidad = reader.GetString(8);
                pData.municipio = reader.GetString(9);
                pData.estado = reader.GetString(10);
                pData.telefono = reader.GetString(11);
                pData.email = reader.GetString(12);
                pData.ret_iva = reader.GetDecimal(13);
                pData.ret_isr = reader.GetDecimal(14);
                pData.lugar_expedicion = reader.GetString(15);
                pData.factura_serie = reader.GetString(16);
                pData.factura_folio = reader.GetInt32(17);
                pData.tipo_logo = reader.GetInt32(18);
                pData.path_cer = reader.GetString(19);
                pData.path_key = reader.GetString(20);
                pData.sello_pass = reader.GetString(21);
                pData.cadena_cer = reader.GetString(22);
                pData.num_cer = reader.GetString(23);
                pData.logo_cuadrado = reader.GetString(24);
                pData.logo_banner = reader.GetString(25);
                pData.cot_folio = reader.GetInt32(26);
                pData.cot_serie = reader.GetString(27);
                pData.ventas_folio = reader.GetInt32(28);
                pData.ventas_serie = reader.GetString(29);
                pData.timbre_user = reader.GetString(30);
                pData.timbre_pass = reader.GetString(31);
            }

            conexion.Close();
            return pData;

        }

        public static int updateEmpresa(Configuracion pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format(" UPDATE cfg_configuracion  " +
            " SET " +
             " nombre = '{0}'  " +
             " ,rfc = '{1}'  " +
             " ,calle = '{2}'  " +
             " ,n_ext = '{3}'  " +
             " ,n_int = '{4}'  " +
             " ,colonia = '{5}'  " +
             " ,cp = '{6}'  " +
             " ,localidad = '{7}'  " +
             " ,municipio = '{8}'  " +
             " ,estado = '{9}'  " +
             " ,telefono = '{10}'  " +
             " ,email = '{11}'  " +
             " ,ret_iva = {12}  " +
             " ,ret_isr = {13}  " +
             " ,cot_folio = {14}  " +
             " ,cot_serie = '{15}'  " +
             " ,ventas_folio = 16  " +
             " ,ventas_serie = '{17}'  " +
            " WHERE " +
              " id_cfg = {18}  " ,
              pData.nombre,
             pData.rfc,
             pData.calle,
             pData.n_ext,
             pData.n_int,
             pData.colonia,
             pData.cp,
             pData.localidad,
             pData.municipio,
             pData.estado,
             pData.telefono,
             pData.email,
             pData.ret_iva,
             pData.ret_isr,
             pData.cot_folio,
             pData.cot_serie,
             pData.ventas_folio,
             pData.ventas_serie,
             pData.id_cfg
            ), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int saveFacturacion(Configuracion pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format(" UPDATE cfg_configuracion  " +
            " SET " +
              "regimen = '{0}'"
             +",lugar_expedicion = '{1}'"
             +",factura_serie = '{2}'"
             +",factura_folio = {3}"
             +",path_cer = '{4}'"
             +",path_key = '{5}'"
             +",sello_pass = '{6}'"
             +",cadena_cer ={7} "
             +",num_cer = '{8}'"
             +",timbre_pass = ''{9},"
             +",timbre_user = '{10}'"+
            " WHERE " +
              " id_cfg = {11}  ",
                pData.regimen,
                pData.lugar_expedicion,
                pData.factura_serie,
                pData.factura_folio,
                pData.path_cer,
                pData.path_key,
                pData.sello_pass,
                pData.cadena_cer,
                pData.num_cer,
                pData.timbre_pass,
                pData.timbre_user,
             pData.id_cfg
            ), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        /*Aumenta el folio */
        public static void setFolio(int id_cfg, int folio)
        {

            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE cfg set folio_actual = {0} WHERE  id_cfg = {1} ", folio, id_cfg), conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public static int setSelloInfo(string certificado, string key, string pass, string cadena, string numero, int id_cfg)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE cfg set path_cer = '{0}', path_key = '{1}', sello_pass = '{2}', cadena_cer = '{3}', num_cer='{4}'  WHERE  id_cfg = {5} ",
                                                                         certificado, key, pass, cadena, numero, id_cfg), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        public static int setLogos(string cuadrado, string banner, int tipo, int id_cfg)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE cfg set logo_cuadrado = '{0}', logo_banner = '{1}', foto_perfil = {2} WHERE  id_cfg = {3} ",
                                                                         cuadrado, banner, tipo, id_cfg), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        /*Setea las hubicacion del certificado */
        public static void setCertificado(string certificado, int id_cfg)
        {

            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE cfg set path_cer = '{0}' WHERE  id_cfg = {1} ", certificado, id_cfg), conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        // Setea la hubicación de la key
        public static void setKey(string key, int id_cfg)
        {

            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(string.Format("UPDATE cfg set  path_key = '{0}' WHERE  id_cfg = {1} ", key, id_cfg), conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        //Obtener Logo cuadrado para el perfil
        public static string getLogoCuadrado(int idEmpresa)
        {
            string resultado = "";
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(string.Format("select logo_cuadrado  from cfg WHERE  id_cfg = {0} ", idEmpresa), conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                resultado = reader.GetString(0);
            }
            conexion.Close();

            return resultado;

        }

        //Iniciar sesion
        public static int login(string usuario, string pass)
        {
            int resultado = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(string.Format("SELECT 1 as 'usuario' FROM xconfig where usuario = '{0}' and pass = '{1}'", usuario, pass), conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                resultado = reader.GetInt32(0);
            }
            conexion.Close();

            return resultado;
        }
    }
}
