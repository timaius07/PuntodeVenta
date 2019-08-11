using frmMenu.Entidades;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMenu.DAO
{
   public  class ClienteDAO
    {
        public Cliente RegistrarCliente(Cliente pt)
        {
            Cliente cli = new Cliente();

            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                NpgsqlTransaction tran = con.BeginTransaction();

                string sql = @"INSERT INTO cliente( cedula, nombre, apellidos, direcion, numtelf, 
                  numcel)
                  VALUES (:ced, :nomb, :apell, :dirc, :telcasa, :telcel) 
                  RETURNING id_cliente;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("ced", pt.Cedula);
                cmd.Parameters.AddWithValue("nomb", pt.Nombre);
                cmd.Parameters.AddWithValue("apell", pt.Apellido);
                cmd.Parameters.AddWithValue("dirc", pt.Direccion);
                cmd.Parameters.AddWithValue("telcasa", pt.TelefonoCasa);
                cmd.Parameters.AddWithValue("telcel", pt.TelefonoCel);                
                pt.Id = Convert.ToInt32(cmd.ExecuteScalar());
                tran.Commit();
                return pt;
            }
        }
        public Cliente ModificarCliente(Cliente pt)
        {
            Cliente cli = new Cliente();

            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                NpgsqlTransaction tran = con.BeginTransaction();

                string sql = @"UPDATE cliente
                 SET  cedula= :ced, nombre= :nomb, apellidos= :apell, direcion= :dirc,
                 numtelf= :telcasa, numcel= :telcel
                 WHERE id_cliente= :id_cli;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("ced", pt.Cedula);
                cmd.Parameters.AddWithValue("nomb", pt.Nombre);
                cmd.Parameters.AddWithValue("apell", pt.Apellido);
                cmd.Parameters.AddWithValue("dirc", pt.Direccion); 
                cmd.Parameters.AddWithValue("telcasa", pt.TelefonoCasa);
                cmd.Parameters.AddWithValue("telcel", pt.TelefonoCel);
                cmd.Parameters.AddWithValue("id_cli", pt.Id);
                pt.Id = Convert.ToInt32(cmd.ExecuteScalar());
                tran.Commit();
                return pt;
            }
        }
        public bool Eliminar_Cliente(int idCli)
        {
            bool estado = false;
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                try
                {
                    con.Open();
                    string sql = @"DELETE FROM cliente
                    WHERE id_cliente= :id_cli;";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("id_cli", idCli);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    estado = true;
                }
                catch (Exception)
                {
                    estado = false;
                    MessageBox.Show(" No ha seleccionado ningún Cliente", "Eliminar Cliente Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return estado;
        }
        public List<Cliente> GetCliente(string nombcli)
        {
            List<Cliente> clie = new List<Cliente>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                //abre
                string sql = @"select * from cliente
                                 where nombre like " + "'%" + nombcli + "%'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                // cmd.Parameters.AddWithValue("nom", nombcli);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    clie.Add(cargaCliente(reader));
                }
                return clie;
            }
        }//
        public List<Cliente> GetClienteCed(string cedu)
        {
            List<Cliente> clie = new List<Cliente>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                //abre
                string sql = @"select * from cliente
                                 where cedula like " + "'%" + cedu + "%'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                // cmd.Parameters.AddWithValue("nom", nombcli);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    clie.Add(cargaCliente(reader));
                }
                return clie;
            }
        }//

        /// <summary>
        /// carga los valores que se va a modificar luego de aplicar la compra
        /// </summary>
        /// muestra los valores por codigo de articulo</param>
        /// <returns>lista con los valores seleccionados</returns>
        public List<Cliente> GetClientesDatos()
        {
            List<Cliente> art = new List<Cliente>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.CadenaConexion))
            {
                con.Open();
                //abre
                string sql = @"SELECT *
                FROM cliente ;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    art.Add(cargaCliente(reader));
                }
                return art;
            }
        }


        private Cliente cargaCliente(NpgsqlDataReader reader)
        {
            return new Cliente
            {
                Id = reader.GetInt32(0),
                Cedula = reader.GetString(1),
                Nombre = reader.GetString(2),
                Apellido = reader.GetString(3),
                Direccion = reader.GetString(4),
                TelefonoCasa = reader.GetString(5),
                TelefonoCel = reader.GetString(6)
               
            };
        }
    }
}
