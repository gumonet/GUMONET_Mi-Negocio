using Mi_Negocio.Datasource;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Cotizaciones
{
    class CotizacionDal
    {


        public static Int64 agregar(Cotizacion pData)
        {
            Int64 retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("INSERT INTO ventas ( folio_cotizacion ,fecha_cotizacion ,importe_sub ,iva_tras ,ieps ,total ,metodo_pago ,status ,forma_pago ,condicion_pago ,condicion_embarque ,plazo_entrega ,tipo ,importe_desc  ) "
            + " VALUES ('{0}' ,now(),'{1}' ,'{2}','{3}' ,'{4}' ,'{5}' ,'{6}' ,'{7}' ,'{8}' ,'{9}' ,'{10}', '{11}', '{12}' )",
                pData.folio,
                pData.importe_sub,
                pData.iva_tras,
                pData.ieps,
                pData.total,
                pData.metodo_pago,
                pData.status,
                pData.forma_pago,
                pData.condicion_pago,
                pData.condicion_embarque,
                pData.plazo_entrega,
                pData.tipo,
                pData.importe_desc
           );
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            cmd.ExecuteNonQuery();
            retorno = cmd.LastInsertedId;
            conexion.Close();
            return retorno;
        }
        public static List<Cotizacion> buscar(string pSearch = " ", string date = " ")
        {
            List<Cotizacion> _lista = new List<Cotizacion>();
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format(
                "select id_cotizacion,id_cliente, folio, fecha,  rfc, subtotal, total, cliente, status  FROM v_cotizaciones where campo_buscar like '%{0}%' {1} ", pSearch, date), conexion);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Cotizacion pData = new Cotizacion();
                pData.id_cotizacion = reader.GetInt64(0);
                pData.id_cliente = reader.GetInt32(1);
                pData.folio = reader.GetString(2);
                pData.fecha = reader.GetDateTime(3);
                pData.rfc = reader.GetString(4);
                pData.importe_sub = reader.GetDecimal(5);
                pData.total = reader.GetDecimal(6);
                pData.cliente = reader.GetString(7);
                pData.status = reader.GetInt32(8);

                _lista.Add(pData);
            }

            conexion.Close();
            return _lista;
        }

        public static Cotizacion obtener(Int64 pId)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
            Cotizacion pData = new Cotizacion();

            MySqlCommand cmd = new MySqlCommand(String.Format(
                "SELECT vc.id_cotizacion, vc.id_cliente, vc.folio, vc.fecha, vc.subtotal, vc.iva, vc.ieps, vc.total, vc.metodo_pago, "
            +"vc.status, vc.forma_pago, vc.condicion_pago, vc.condicion_embarque, vc.plazo_entrega FROM v_cotizaciones vc where id_cotizacion = {0} ", pId),
                conexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pData.id_cotizacion = reader.GetInt64(0);
                pData.id_cliente = reader.GetInt32(1);
                pData.folio = reader.GetString(2);
                pData.fecha = reader.GetDateTime(3);
                pData.importe_sub = reader.GetDecimal(4);
                pData.iva_tras = reader.GetDecimal(5);
                pData.ieps = reader.GetDecimal(6);
                pData.total = reader.GetDecimal(7);
                pData.metodo_pago = reader.GetString(8);
                pData.status = reader.GetInt32(9);
                pData.forma_pago = reader.GetString(10);
                pData.condicion_pago = reader.GetString(11);
                pData.condicion_embarque = reader.GetString(12);
                pData.plazo_entrega = reader.GetString(13);
            }

            conexion.Close();
            return pData;

        }

      /*  public static int actualizar(Cotizacion pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("  ",
                 pData.folio
                , pData.id_cliente
                , pData.fecha
                , pData.condicion_pago
                , pData.plazo_entrega
                , pData.cond_embarque
                , pData.subtotal
                , pData.iva
                , pData.total
                , pData.status
                , pData.id_cotizacion);
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }
        */
        public static int eliminar(Int64 pIdData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format("delete from cotizaciones where id_cotizacion = {0}", pIdData), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;

        }
    }
}
