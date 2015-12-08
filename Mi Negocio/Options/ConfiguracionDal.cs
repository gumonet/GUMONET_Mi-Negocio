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
           "INSERT INTO cfg (regimen ,nombre ,rfc ,calle ,n_ext ,n_int ,colonia ,cp ,localidad ,municipio ,estado ,telefono ,email ,iva ,ieps ,ret_iva ,ret_isr ,lugar_expedicion ,serie ,folio_actual , folio_final, cadena_cer) " +
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
                ")"
                ,
           pData.regimen, pData.nombre, pData.rfc, pData.calle, pData.n_ext, pData.n_int, pData.colonia, pData.cp, pData.localidad, pData.municipio, pData.estado, pData.telefono, pData.email, pData.iva, pData.ieps, pData.ret_iva, pData.ret_isr, pData.lugar_expedicion, pData.serie, pData.folio_actual, pData.folio_final, pData.cadena_cer
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

        //Otener cliente para editar
        public static Configuracion Obtener(int pId)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
            Configuracion pData = new Configuracion();

            MySqlCommand cmd = new MySqlCommand(String.Format("select regimen ,nombre ,rfc ,calle ,n_ext ,n_int ,colonia ,cp ,localidad ,municipio ,estado ,telefono ,email ,iva ,ieps ,ret_iva ,ret_isr ,lugar_expedicion ,serie ,folio_actual ,folio_final, path_cer, path_key, sello_pass, cadena_cer, num_cer, logo_cuadrado, logo_banner,foto_perfil  FROM cfg where id_cfg = {0} ", pId), conexion);
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
                pData.iva = reader.GetDecimal(13);
                pData.ieps = reader.GetDecimal(14);
                pData.ret_iva = reader.GetDecimal(15);
                pData.ret_isr = reader.GetDecimal(16);
                pData.lugar_expedicion = reader.GetString(17);
                pData.serie = reader.GetString(18);
                pData.folio_actual = reader.GetInt32(19);
                pData.folio_final = reader.GetString(20);
                pData.path_cer = reader.GetString(21);
                pData.path_key = reader.GetString(22);
                pData.sello_pass = reader.GetString(23);
                pData.cadena_cer = reader.GetString(24);
                pData.num_cer = reader.GetString(25);
                pData.logo_cuadrado = reader.GetString(26);
                pData.logo_banner = reader.GetString(27);
                pData.foto_perfil = reader.GetInt32(28);
            }

            conexion.Close();
            return pData;

        }

        public static int Actualizar(Configuracion pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format(" UPDATE cfg  " +
            " SET " +
             " regimen = '{0}' " +
             " ,nombre = '{1}' " +
             " ,rfc = '{2}' " +
             " ,calle = '{3}' " +
             " ,n_ext = '{4}' " +
             " ,n_int = '{5}' " +
             " ,colonia = '{6}' " +
             " ,cp = '{7}' " +
             " ,localidad = '{8}' " +
             " ,municipio = '{9}' " +
             " ,estado = '{10}' " +
             " ,telefono = '{11}' " +
             " ,email = '{12}' " +
             " ,iva = {13} " +
             " ,ieps = {14} " +
             " ,ret_iva = {15} " +
             " ,ret_isr = {16} " +
             " ,lugar_expedicion = '{17}' " +
             " ,serie = '{18}' " +
             " ,folio_actual = '{19}' " +
             " ,folio_final = '{20}' " +
            " WHERE " +
              " id_cfg = {21} ",
             pData.regimen, pData.nombre, pData.rfc, pData.calle, pData.n_ext, pData.n_int, pData.colonia, pData.cp, pData.localidad, pData.municipio, pData.estado, pData.telefono, pData.email, pData.iva, pData.ieps, pData.ret_iva, pData.ret_isr, pData.lugar_expedicion, pData.serie, pData.folio_actual, pData.folio_final, pData.id_cfg
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
