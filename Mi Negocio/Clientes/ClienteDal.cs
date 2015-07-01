using Mi_Negocio.Datasource;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_Negocio.Clientes
{
    class ClienteDal
    {
            public static int agregarCliente(Cliente pCliente)
            {
                int retorno = 0;
                MySqlConnection conexion = Connection.ObtenerConexion();

                MySqlCommand cmd = new MySqlCommand(string.Format("INSERT INTO clientes " +
                "( nombre ,rfc, encargado, razon_social ,calle ,n_ext ,n_int ,colonia ,cp ,localidad ,municipio ,estado ,telefono ,email)" +
                "VALUES('{0}','{1}','{2}','{3}' ,'{4}' ,'{5}' ,'{6}' ,'{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
                pCliente.nombre, pCliente.rfc, pCliente.encargado, pCliente.razon_social, pCliente.calle, pCliente.n_ext, pCliente.n_int, pCliente.colonia, pCliente.cp, pCliente.localidad,
                pCliente.municipio, pCliente.estado, pCliente.telefono, pCliente.email), conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
                return retorno;
            }

            public static List<Cliente> Buscar(string pSearch = " ")
            {
                List<Cliente> _lista = new List<Cliente>();
                MySqlConnection conexion = Connection.ObtenerConexion();
                MySqlCommand cmd = new MySqlCommand(String.Format(
                    "SELECT id_cliente, rfc ,nombre FROM v_clientes where campo_buscar like '%{0}%' ", pSearch), conexion);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Cliente pCliente = new Cliente();
                    pCliente.id_cliente = reader.GetInt32(0);
                    pCliente.rfc = reader.GetString(1);
                    pCliente.nombre = reader.GetString(2);

                    _lista.Add(pCliente);
                }

                conexion.Close();
                return _lista;
            }

            public static Cliente ObtenerCliente(int pId)
            {
                MySqlConnection conexion = Connection.ObtenerConexion();
                Cliente pCliente = new Cliente();

                MySqlCommand cmd = new MySqlCommand(String.Format(
                    "select id_cliente,  nombre, encargado, razon_social,  rfc,  calle,  n_ext,  n_int,  colonia,  cp,  localidad,  municipio,  estado,  telefono,  email from clientes where id_cliente = {0} ", pId),
                    conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pCliente.id_cliente = reader.GetInt32(0);
                    pCliente.nombre = reader.GetString(1);
                    pCliente.encargado = reader.GetString(2);
                    pCliente.razon_social = reader.GetString(3);
                    pCliente.rfc = reader.GetString(4);
                    pCliente.calle = reader.GetString(5);
                    pCliente.n_ext = reader.GetString(6);
                    pCliente.n_int = reader.GetString(7);
                    pCliente.colonia = reader.GetString(8);
                    pCliente.cp = reader.GetString(9);
                    pCliente.localidad = reader.GetString(10);
                    pCliente.municipio = reader.GetString(11);
                    pCliente.estado = reader.GetString(12);
                    pCliente.telefono = reader.GetString(13);
                    pCliente.email = reader.GetString(14);
                }

                conexion.Close();
                return pCliente;

            }

            public static int ActualizarCliente(Cliente pCliente)
            {
                int retorno = 0;
                MySqlConnection conexion = Connection.ObtenerConexion();
                string squery = string.Format("update clientes set nombre = '{0}',rfc ='{1}' ,calle ='{2}' ,n_ext ='{3}' ,n_int = '{4}' ,colonia = '{5}' ,cp ='{6}' ,localidad = '{7}' ,municipio = '{8}' ,estado = '{9}' ,telefono = '{10}' ,email = '{11}', encargado = '{12}', razon_social = '{13}' where id_cliente = {14} ",
                pCliente.nombre, pCliente.rfc, pCliente.calle, pCliente.n_ext, pCliente.n_int, pCliente.colonia, pCliente.cp, pCliente.localidad,
                pCliente.municipio, pCliente.estado, pCliente.telefono, pCliente.email,pCliente.encargado, pCliente.razon_social, pCliente.id_cliente);
                MySqlCommand cmd = new MySqlCommand(squery, conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
                return retorno;
            }

            public static int deleteCliente(int pIdCliente)
            {
                int retorno = 0;
                MySqlConnection conexion = Connection.ObtenerConexion();

                MySqlCommand cmd = new MySqlCommand(string.Format("delete from clientes where id_cliente = {0}", pIdCliente), conexion);
                retorno = cmd.ExecuteNonQuery();
                conexion.Close();
                return retorno;

            }
    }
}
