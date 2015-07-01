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
        public static int AgregarCategoria(Categoria pCategoria)
        {
            int retorno = 0;
            MySqlConnection conexion = Connection.ObtenerConexion();
            string squery = string.Format("INSERT INTO alm_categorias( nombre ,descripcion ) VALUES ('{0}','{1}')", pCategoria.nombre, pCategoria.descripcion);
            MySqlCommand cmd = new MySqlCommand(squery, conexion);
            conexion.Close();
            return retorno;
        }


    }
}
