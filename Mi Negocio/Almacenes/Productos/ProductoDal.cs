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
            string squery = string.Format("INSERT INTO alm_productos( identificador ,nombre ,descripcion ,unidad_medida ,n_parte ,tipo ,id_categoria ,proveedor ,precio_compra ,precio_venta ,inventario_bajo ,iva ,ieps ,imagen ) VALUES (  '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}','{12}','{13}' )",
                pData.identificador,
                pData.nombre,
                pData.descripcion,
                pData.unidad_medida,
                pData.n_parte,
                pData.tipo,
                pData.id_categoria,
                pData.proveedor,
                pData.precio_compra,
                pData.precio_venta,
                pData.inventario_bajo,
                pData.iva,
                pData.ieps,
                pData.imagen
           );
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }
        public static List<Producto> Buscar(string pSearch = " ")
        {
            List<Producto> _lista = new List<Producto>();
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format(
                "SELECT id_producto, identificador, nombre, unidad_medida, categoria, id_categoria, precio_compra, precio_venta, iva, ieps, existencia from v_alm_productos where campo_buscar like '%{0}%' ", pSearch), conexion);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Producto pData = new Producto();
                pData.id_producto = reader.GetInt64(0);
                pData.identificador = reader.GetString(1);
                pData.nombre = reader.GetString(2);
                pData.unidad_medida = reader.GetString(3);
                pData.categoria = reader.GetString(4);
                pData.id_categoria = reader.GetInt32(5);
                pData.precio_compra = reader.GetDecimal(6);
                pData.precio_venta = reader.GetDecimal(7);
                pData.iva = reader.GetDecimal(8);
                pData.ieps = reader.GetDecimal(9);
                pData.existencia = reader.GetDecimal(10);
                
                _lista.Add(pData);
            }

            conexion.Close();
            return _lista;
        }

        public static List<Producto> frmBuscar(string pSearch = " ")
        {
            List<Producto> _lista = new List<Producto>();
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format(
                "SELECT id_producto, identificador, concat_ws(' ',nombre, descripcion) nombre from v_alm_productos where campo_buscar like '%{0}%' ", pSearch), conexion);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Producto pData = new Producto();
                pData.id_producto = reader.GetInt64(0);
                pData.identificador = reader.GetString(1);
                pData.nombre = reader.GetString(2);
              /*  pData.unidad_medida = reader.GetString(3);
                pData.categoria = reader.GetString(4);
                pData.id_categoria = reader.GetInt32(5);
                pData.precio_compra = reader.GetDecimal(6);
                pData.precio_venta = reader.GetDecimal(7);
                pData.iva = reader.GetDecimal(8);
                pData.ieps = reader.GetDecimal(9);
                pData.existencia = reader.GetDecimal(10);*/

                _lista.Add(pData);
            }

            conexion.Close();
            return _lista;
        }


        public static Producto obtener(Int64 pId)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
            Producto pData = new Producto();

            MySqlCommand cmd = new MySqlCommand(String.Format(
                "select id_producto, identificador, nombre, unidad_medida, categoria, id_categoria, precio_compra, precio_venta, iva, ieps, existencia, descripcion, n_parte, proveedor, inventario_bajo, imagen  from v_alm_productos where id_producto = {0} ", pId),
                conexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pData.id_producto = reader.GetInt64(0);
                pData.identificador = reader.GetString(1);
                pData.nombre = reader.GetString(2);
                pData.unidad_medida = reader.GetString(3);
                pData.categoria = reader.GetString(4);
                pData.id_categoria = reader.GetInt32(5);
                pData.precio_compra = reader.GetDecimal(6);
                pData.precio_venta = reader.GetDecimal(7);
                pData.iva = reader.GetDecimal(8);
                pData.ieps = reader.GetDecimal(9);
                pData.existencia = reader.GetDecimal(10);
                pData.descripcion = reader.GetString(11);
                pData.n_parte = reader.GetString(12);
                pData.proveedor = reader.GetString(13);
                pData.inventario_bajo = reader.GetDecimal(14);
                pData.imagen = reader.GetString(15);
            }

            conexion.Close();
            return pData;

        }

        public static int actualizar(Producto pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("UPDATE alm_productos SET identificador = '{0}' ,nombre = '{1}' ,descripcion = '{2}' ,unidad_medida = '{3}' ,n_parte = '{4}' ,id_categoria = {5} ,"+
                "proveedor = '{6}' ,precio_compra = {7} ,precio_venta = {8} ,inventario_bajo = {10} ,iva = {11} ,ieps = {12} ,imagen = '{13}' WHERE   id_producto = {14} ",
                pData.identificador,
                pData.nombre,
                pData.descripcion,
                pData.unidad_medida,
                pData.n_parte,
                pData.id_categoria,
                pData.proveedor,
                pData.precio_compra,
                pData.precio_venta,
                pData.existencia,
                pData.inventario_bajo,
                pData.iva,
                pData.ieps,
                pData.imagen,
                pData.id_producto);
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int delete(Int64 pIdData)
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
