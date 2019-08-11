using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmMenu.DAO;
using frmMenu.Entidades;
using System.Text.RegularExpressions;

namespace frmMenu.BO
{

    public class ClienteBO
    {
        ClienteDAO cdao;
        //string para verificar el correo
        string exp = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        /// <summary>
        /// instancia del cliente para ingreasar al DAOCliente
        /// </summary>
        /// 
        public ClienteBO()
        {
            cdao = new ClienteDAO();
        }
        /// <summary>
        /// verifica los datos del cliente para ingresarlos
        /// </summary>
        /// <param name="pt">contiene los datos del cliente</param>
        /// <returns></returns>
        public string Validar(Cliente pt)
        {
            if (!(pt.Nombre == "" || pt.Cedula == ""|| pt.TelefonoCel == ""))

            {
                return cdao.RegistrarCliente(pt).Id > 0 ? "Registro con exito" : "Se ingreso el nuevo Cliente";
            }
            else
            {
                return "Hay espacios requeridos vacios o erroneos";
            }
        }
        /// <summary>
        /// modifica los datos del cliente en la BD
        /// </summary>
        /// <param name="pt">contiene los datos del cliente modificados</param>
        /// <returns></returns>
        public string ModificarCli(Cliente pt)
        {
            if (!(pt.Nombre == "" || pt.Cedula == "" || pt.TelefonoCel == ""))

            {
                return cdao.ModificarCliente(pt).Id > 0 ? "Registro con exito" : "Exito al Modificar";
            }
            else
            {
                return "Hay espacios requeridos vacios o erroneos";
            }

        }
        /// <summary>
        /// elimina de manera permanente un cliente
        /// </summary>
        /// <param name="idCli">id del cliente a eliminar</param>
        /// <returns></returns>
        public bool EliminarCliente(int idCli)
        {
            return cdao.Eliminar_Cliente(idCli);
        }
        /// <summary>
        /// obtiene los datos del cliente a consultar por nombre
        /// </summary>
        /// <param name="nombcli">nombre del cliente</param>
        /// <returns></returns>
        public List<Cliente> GetCliente(string nombcli)
        {
            cdao = new ClienteDAO();
            return cdao.GetCliente(nombcli);
        }
        /// <summary>
        /// obtiene los datos del cliente a consultar por cedula
        /// </summary>
        /// <param name="cedu">cedula del cliente</param>
        /// <returns></returns>
        public List<Cliente> GetClienteCed(string cedu)
        {
            cdao = new ClienteDAO();
            return cdao.GetClienteCed(cedu);
        }
        /// <summary>
        /// carga todos los datos de los clientes registrados
        /// </summary>
        /// <returns>lista con todos los clientes del sistema</returns>
        public List<Cliente> GetCargarClientes()
        {
            cdao = new ClienteDAO();
            return cdao.GetClientesDatos();
        }
    }
}
