using Mi_Negocio.Datasource;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Contabilidad
{
    class CategriaDal
    {

        public static int agregar(Categoria pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            String squery = string.Format("INSERT INTO cont_categorias (  nombre ,color ,descripcion) VALUES (  '{0}' ,'{1}' ,'{2}') ",
                pData.nombre, pData.color, pData.descripcion  );
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }
        public static List<Categoria> buscar(string pSearch = " ")
        {
            List<Categoria> _lista = new List<Categoria>();
            MySqlConnection conexion = Connection.ObtenerConexion();
            MySqlCommand cmd = new MySqlCommand(String.Format(
                "SELECT id_categoria, nombre ,color ,descripcion FROM cont_categorias where nombre like '%{0}%' ", pSearch), conexion);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Categoria pData = new Categoria();
                pData.id_categoria = reader.GetInt32(0);
                pData.nombre = reader.GetString(1);
                pData.color = reader.GetString(2);
                pData.descripcion = reader.GetString(3);
                _lista.Add(pData);
            }

            conexion.Close();
            return _lista;
        }

        public static Categoria obtener(Int32 pId)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
            Categoria pData = new Categoria();

            MySqlCommand cmd = new MySqlCommand(String.Format(
                "select  id_categoria, nombre ,color ,descripcion  from cont_categorias where id_categoria = {0} ", pId),
                conexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pData.id_categoria = reader.GetInt32(0);
                pData.nombre = reader.GetString(1);
                pData.color = reader.GetString(2);
                pData.descripcion = reader.GetString(3);
            }

            conexion.Close();
            return pData;

        }

        public static int actualizar(Categoria pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format(" UPDATE cont_categorias SET  nombre = '{0}',color = '{1}' ,descripcion = '{2}' WHERE id_categoria = {3} ", pData.nombre, pData.color, pData.descripcion, pData.id_categoria);
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int eliminar(int pIdData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format("delete from cont_categorias where id_categoria = {0}", pIdData), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;

        }
    }
}
