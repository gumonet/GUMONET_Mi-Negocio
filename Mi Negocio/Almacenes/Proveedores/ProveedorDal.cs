using Mi_Negocio.Datasource;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Almacenes.Proveedores
{
    class ProveedorDal
    {


        public static int agregar(Proveedor pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("INSERT INTO alm_proveedores( nombre  ,encargado  ,razon_social  ,rfc  ,calle  ,n_ext  ,n_int  ,colonia  ,cp  ,localidad  ,municipio  ,estado  ,telefono  ,email ) "
            + " VALUES ('{0}' ,'{1}' ,'{2}' ,'{3}' ,'{4}' ,'{5}' ,'{6}' ,'{7}' ,'{8}' ,'{9}' ,'{10}' ,'{11}' ,'{12}' ,'{13}')",
               pData.nombre
             , pData.encargado
             , pData.razon_social
             , pData.rfc
             , pData.calle
             , pData.n_ext
             , pData.n_int
             , pData.colonia
             , pData.cp
             , pData.localidad
             , pData.municipio
             , pData.estado
             , pData.telefono
             , pData.email
           );
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            conexion.Close();
            return retorno;
        }
        public static List<Proveedor> Buscar(string pSearch = " ")
        {
            List<Proveedor> _lista = new List<Proveedor>();
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format(
                "SELECT id_proveedor, nombre  ,encargado  ,razon_social  ,rfc  ,calle  ,n_ext  ,n_int  ,colonia  ,cp  ,localidad  ,municipio  ,estado  ,telefono  ,email from v_alm_proveedores where campo_buscar like '%{0}%' ", pSearch), conexion);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Proveedor pData = new Proveedor();
                pData.id_proveedor = reader.GetInt32(0);
                pData.nombre = reader.GetString(1);
                pData.encargado = reader.GetString(2);
                pData.razon_social = reader.GetString(3);
                pData.rfc = reader.GetString(4);
                pData.calle = reader.GetString(5);
                pData.n_ext = reader.GetString(6);
                pData.n_int = reader.GetString(7);
                pData.colonia = reader.GetString(8);
                pData.cp = reader.GetString(9);
                pData.localidad = reader.GetString(10);
                pData.municipio = reader.GetString(11);
                pData.estado = reader.GetString(12);
                pData.telefono = reader.GetString(13);
                pData.email = reader.GetString(14);

                _lista.Add(pData);
            }

            conexion.Close();
            return _lista;
        }

        public static Proveedor obtener(int pId)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
            Proveedor pData = new Proveedor();

            MySqlCommand cmd = new MySqlCommand(String.Format(
                "select id_proveedor, nombre  ,encargado  ,razon_social  ,rfc  ,calle  ,n_ext  ,n_int  ,colonia  ,cp  ,localidad  ,municipio  ,estado  ,telefono  ,email where id_proveedor = {0} ", pId),
                conexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pData.id_proveedor = reader.GetInt32(0);
                pData.nombre = reader.GetString(1);
                pData.encargado = reader.GetString(2);
                pData.razon_social = reader.GetString(3);
                pData.rfc = reader.GetString(4);
                pData.calle = reader.GetString(5);
                pData.n_ext = reader.GetString(6);
                pData.n_int = reader.GetString(7);
                pData.colonia = reader.GetString(8);
                pData.cp = reader.GetString(9);
                pData.localidad = reader.GetString(10);
                pData.municipio = reader.GetString(11);
                pData.estado = reader.GetString(12);
                pData.telefono = reader.GetString(13);
                pData.email = reader.GetString(14);
            }

            conexion.Close();
            return pData;

        }

        public static int actualizar(Proveedor pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("update alm_proveedores set nombre = '{0}', encargado = '{1}', razon_social = '{2}', rfc = '{3}', calle = '{4}', n_ext = '{5}', n_int = '{6}', colonia = '{7}', cp = '{8}', localidad = '{9}', municipio = '{10}', estado = '{11}', telefono = '{12}', email = '{13}' where id_proveedor = {14} ",
               pData.nombre
             , pData.encargado
             , pData.razon_social
             , pData.rfc
             , pData.calle
             , pData.n_ext
             , pData.n_int
             , pData.colonia
             , pData.cp
             , pData.localidad
             , pData.municipio
             , pData.estado
             , pData.telefono
             , pData.email
             , pData.id_proveedor);
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int delete(int pIdData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format("delete from alm_proveedores where id_proveedor = {0}", pIdData), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;

        }
    }
}
