using Mi_Negocio.Datasource;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Contabilidad
{
    class CuentaDal
    {

        public static int agregar(Cuenta pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("INSERT INTO cont_cuentas (  nombre  ,descripcion) VALUES (  '{0}' ,'{1}') ",
                pData.nombre, pData.descripcion);
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }
        public static List<Cuenta> buscar(string pSearch = " ")
        {
            List<Cuenta> _lista = new List<Cuenta>();
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format(
                "SELECT id_cuenta, nombre ,descripcion FROM cont_cuentas where nombre like '%{0}%'  ", pSearch), conexion);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Cuenta pData = new Cuenta();
                pData.id_cuenta = reader.GetInt32(0);
                pData.nombre = reader.GetString(1);
                pData.descripcion = reader.GetString(2);
                _lista.Add(pData);
            }

            conexion.Close();
            return _lista;
        }

        public static Cuenta obtener(Int32 pId)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
            Cuenta pData = new Cuenta();

            MySqlCommand cmd = new MySqlCommand(String.Format(
                "select  id_cuenta, nombre ,descripcion  from cont_cuentas where id_cuenta = {0} ", pId),
                conexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pData.id_cuenta = reader.GetInt32(0);
                pData.nombre = reader.GetString(1);
                pData.descripcion = reader.GetString(2);
            }

            conexion.Close();
            return pData;

        }

        public static int actualizar(Cuenta pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format(" UPDATE cont_cuentas SET  nombre = '{0}' ,descripcion = '{1}' WHERE id_cuenta = {2} ", pData.nombre, pData.descripcion, pData.id_cuenta);
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int eliminar(int pIdData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format("delete from cont_cuentas where id_cuenta = {0}", pIdData), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;

        }
    }
}
