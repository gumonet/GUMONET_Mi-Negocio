using Mi_Negocio.Datasource;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Almacenes.Categorias
{
    class CategoriaDal
    {
        public static int agregar(Categoria pCategoria)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("INSERT INTO alm_categorias( nombre ,descripcion ) VALUES ('{0}','{1}')", pCategoria.nombre, pCategoria.descripcion);
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
                "SELECT id_categoria, nombre ,descripcion FROM alm_categorias where nombre like '%{0}%' ", pSearch), conexion);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Categoria pData = new Categoria();
                pData.id_categoria = reader.GetInt32(0);
                pData.nombre = reader.GetString(1);
                pData.descripcion = reader.GetString(2);

                _lista.Add(pData);
            }

            conexion.Close();
            return _lista;
        }

        public static Categoria obtener(int pId)
        {
            MySqlConnection conexion = Connection.ObtenerConexion();
            Categoria pData = new Categoria();

            MySqlCommand cmd = new MySqlCommand(String.Format(
                "select id_categoria,  nombre, descripcion from alm_categorias where id_categoria = {0} ", pId),
                conexion);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                pData.id_categoria = reader.GetInt32(0);
                pData.nombre = reader.GetString(1);
                pData.descripcion = reader.GetString(2);                
            }

            conexion.Close();
            return pData;

        }

        public static int actualizar(Categoria pData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("update alm_categorias set nombre = '{0}',descripcion ='{1}' where id_categoria = {2} ",
            pData.nombre, pData.descripcion, pData.id_categoria);
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;
        }

        public static int delete(int pIdData)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();

            MySqlCommand cmd = new MySqlCommand(string.Format("delete from alm_categorias where id_categoria = {0}", pIdData), conexion);
            retorno = cmd.ExecuteNonQuery();
            conexion.Close();
            return retorno;

        }


    }
}
