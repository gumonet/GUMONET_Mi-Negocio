using Mi_Negocio.Datasource;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Contabilidad
{
    class MovimientoDal
    {

        public static int agregar(Movimiento pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("INSERT INTO cont_movimientos ( nombre ,concepto ,monto ,id_categoria ,id_cuenta ,fecha ,adjunto ,metodo_pago ,tipo, id_usuario ) "
            + " VALUES ('{0}' ,'{1}' ,'{2}' ,'{3}' ,'{4}' ,'{5}' ,'{6}' ,'{7}' ,'{8}', {9})",
                pData.nombre,
                pData.concepto,
                pData.monto,
                pData.id_categoria,
                pData.id_cuenta,
                pData.fecha,
                pData.adjunto,
                pData.metodo_pago,
                pData.tipo,
                pData.id_usuario
           );
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            conexion.Close();
            return retorno;
        }
        public static List<Movimiento> buscar(string pSearch = " ", string date = " ")
        {
            List<Movimiento> _lista = new List<Movimiento>();
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format(
                "SELECT id_movimiento, nombre, monto, concepto, id_categoria, categoria, id_cuenta, cuenta, fecha, adjunto, metodo_pago, tipo, id_usuario, usuario FROM v_cont_movimientos  where campo_buscar like '%{0}%' {1} ", pSearch, date), conexion);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Movimiento pData = new Movimiento();

                pData.id_movimiento = reader.GetInt64(0);
                pData.nombre = reader.GetString(1);
                pData.monto = reader.GetDecimal(2);
                pData.concepto = reader.GetString(3);
                pData.id_categoria = reader.GetInt32(4);
                pData.categoria = reader.GetString(4);
                pData.id_cuenta = reader.GetInt32(6);
                pData.cuenta = reader.GetString(7);
                pData.fecha = reader.GetDateTime(8);
                pData.adjunto = reader.GetString(9);
                pData.metodo_pago = reader.GetString(10);
                pData.tipo = reader.GetInt32(11);
                pData.id_usuario = reader.GetInt32(12);
                pData.usuario = reader.GetString(13);

                _lista.Add(pData);
            }

            conexion.Close();
            return _lista;
        }

        public static Movimiento obtener(Int64 pId)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
            Movimiento pData = new Movimiento();

            MySqlCommand cmd = new MySqlCommand(String.Format(
                "select id_movimiento, nombre, monto, concepto, id_categoria, categoria, id_cuenta, cuenta, fecha, adjunto, metodo_pago, tipo, id_usuario, usuario FROM v_cont_movimientos   where id_movimiento = {0} ", pId),
                conexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pData.id_movimiento = reader.GetInt64(0);
                pData.nombre = reader.GetString(1);
                pData.monto = reader.GetDecimal(2);
                pData.concepto = reader.GetString(3);
                pData.id_categoria = reader.GetInt32(4);
                pData.categoria = reader.GetString(4);
                pData.id_cuenta = reader.GetInt32(6);
                pData.cuenta = reader.GetString(7);
                pData.fecha = reader.GetDateTime(8);
                pData.adjunto = reader.GetString(9);
                pData.metodo_pago = reader.GetString(10);
                pData.tipo = reader.GetInt32(11);
                pData.id_usuario = reader.GetInt32(12);
                pData.usuario = reader.GetString(13);
            }

            conexion.Close();
            return pData;

        }

        public static int actualizar(Movimiento pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("UPDATE cont_movimientos SET nombre = '{0}'   ,concepto = '{1}'   ,monto = {2}   ,id_categoria = {3}   ,id_cuenta = {4} " +
                ", fecha = {5}   ,adjunto = '{6}'   ,metodo_pago = '{7}'   ,tipo = {8}   ,id_usuario = {9}  WHERE id_movimiento = {10} ",

                pData.nombre,
                pData.concepto,
                pData.monto,
                pData.id_categoria,
                pData.id_cuenta,
                pData.fecha,
                pData.adjunto,
                pData.metodo_pago,
                pData.tipo,
                pData.id_usuario,
                pData.id_movimiento
                
                );
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int eliminar(Int64 pIdData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format("delete from cont_movimientos  where id_movimiento = {0}", pIdData), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;

        }
    }
}
