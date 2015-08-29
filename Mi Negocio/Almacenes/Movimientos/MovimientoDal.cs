using Mi_Negocio.Datasource;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Almacenes.Movimientos
{
    class MovimientoDal
    {
        public static int agregar(Movimiento pMovimiento)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("INSERT INTO alm_movimientos (  tipo ,descripcion ,responsable ,fecha ) VALUES ( {0}, {1}, '{2}', NOW() )')", pMovimiento.tipo, pMovimiento.descripcion, pMovimiento.responsable);
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            conexion.Close();
            return retorno;
        }
        public static List<Movimiento> Buscar(string pSearch = " ")
        {
            List<Movimiento> _lista = new List<Movimiento>();
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format(
                "SELECT id_movimiento, nombre ,descripcion FROM v_alm_movimientos where campo_buscar like '%{0}%' ", pSearch), conexion);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Movimiento pData = new Movimiento();
                pData.id_movimiento = reader.GetInt32(0);
                pData.tipo  = reader.GetInt32(1);
                pData.descripcion  = reader.GetString(2);
                pData.responsable = reader.GetString(3);
                pData.fecha = reader.GetDateTime(4);

                _lista.Add(pData);
            }

            conexion.Close();
            return _lista;
        }

        public static Movimiento obtener(int pId)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
            Movimiento pData = new Movimiento();

            MySqlCommand cmd = new MySqlCommand(String.Format(
                "select id_movimiento ,tipo ,descripcion ,responsable ,fecha  from alm_movimientos where id_movimiento = {0} ", pId),
                conexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pData.id_movimiento = reader.GetInt32(0);
                pData.tipo = reader.GetInt32(1);
                pData.descripcion = reader.GetString(2);
                pData.responsable = reader.GetString(3);
                pData.fecha = reader.GetDateTime(4);
            }

            conexion.Close();
            return pData;

        }

        public static int actualizar(Movimiento pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("tipo = {0} ,descripcion = '{1}' ,responsable = '{2}' WHERE  id_movimiento = {3}",
            pData.tipo, pData.descripcion, pData.id_movimiento);
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int delete(int pIdData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format("delete from alm_movimientos where id_movimiento = {0}", pIdData), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;

        }

    }
}
