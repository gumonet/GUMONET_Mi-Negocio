using Mi_Negocio.Datasource;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Almacenes.Productos
{
    class ProductoDal
    {
        public static int agregar(Producto pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("INSERT INTO alm_productos( identificador ,nombre ,descripcion ,unidad_medida ,n_parte ,tipo ,id_categoria ,id_provedor ,precio_compra ,precio_venta ,inventario_alto ,inventario_bajo ) VALUES (  '{0}', '{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}, {8}, {9}, {10}, {11} )",
                pData.identificador,
                pData.nombre,
                pData.descripcion,
                pData.unidad_medida,
                pData.n_parte,
                pData.tipo,
                pData.id_categoria,
                pData.id_provedor,
                pData.precio_compra,
                pData.precio_venta,
                pData.inventario_alto,
                pData.inventario_bajo
           );
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            conexion.Close();
            return retorno;
        }
        public static List<Producto> Buscar(string pSearch = " ")
        {
            List<Producto> _lista = new List<Producto>();
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format(
                "SELECT identificador ,nombre ,descripcion ,unidad_medida ,n_parte ,tipo ,id_categoria ,id_provedor ,precio_compra ,precio_venta ,inventario_alto ,inventario_bajo from v_alm_productos where campo_buscar like '%{0}%' ", pSearch), conexion);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Producto pData = new Producto();
                pData.id_producto = reader.GetInt32(0);
                pData.identificador = reader.GetString(1);
                pData.nombre = reader.GetString(2);
                pData.descripcion = reader.GetString(3);
                pData.unidad_medida = reader.GetString(4);
                pData.n_parte = reader.GetString(5);
                pData.tipo = reader.GetInt32(6);
                pData.id_categoria = reader.GetInt32(7);
                pData.id_provedor = reader.GetInt32(8);
                pData.precio_compra = reader.GetDecimal(9);
                pData.precio_venta = reader.GetDecimal(10);
                pData.inventario_alto = reader.GetDecimal(11);
                pData.inventario_bajo = reader.GetDecimal(12);

                _lista.Add(pData);
            }

            conexion.Close();
            return _lista;
        }

        public static Producto obtener(int pId)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
            Producto pData = new Producto();

            MySqlCommand cmd = new MySqlCommand(String.Format(
                "select identificador ,nombre ,descripcion ,unidad_medida ,n_parte ,tipo ,id_categoria ,id_provedor ,precio_compra ,precio_venta ,inventario_alto ,inventario_bajo from alm_productos where id_producto = {0} ", pId),
                conexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pData.id_producto = reader.GetInt32(0);
                pData.identificador = reader.GetString(1);
                pData.nombre = reader.GetString(2);
                pData.descripcion = reader.GetString(3);
                pData.unidad_medida = reader.GetString(4);
                pData.n_parte = reader.GetString(5);
                pData.tipo = reader.GetInt32(6);
                pData.id_categoria = reader.GetInt32(7);
                pData.id_provedor = reader.GetInt32(8);
                pData.precio_compra = reader.GetDecimal(9);
                pData.precio_venta = reader.GetDecimal(10);
                pData.inventario_alto = reader.GetDecimal(11);
                pData.inventario_bajo = reader.GetDecimal(12);
            }

            conexion.Close();
            return pData;

        }

        public static int actualizar(Producto pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("update alm_productos set nombre = '{0}', encargado = '{1}', razon_social = '{2}', rfc = '{3}', calle = '{4}', n_ext = '{5}', n_int = '{6}', colonia = '{7}', cp = '{8}', localidad = '{9}', municipio = '{10}', estado = '{11}', telefono = '{12}', email = '{13}' where id_producto = {14} ",
                pData.identificador,
                pData.nombre,
                pData.descripcion,
                pData.unidad_medida,
                pData.n_parte,
                pData.tipo,
                pData.id_categoria,
                pData.id_provedor,
                pData.precio_compra,
                pData.precio_venta,
                pData.inventario_alto,
                pData.inventario_bajo
             , pData.id_producto);
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int delete(int pIdData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format("delete from alm_productos where id_producto = {0}", pIdData), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;

        }
    }
}
