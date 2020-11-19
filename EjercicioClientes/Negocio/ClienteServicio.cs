using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class ClienteServicio
    {
        private static ClienteMapper mapper = new ClienteMapper();
        public static List<Cliente> TraerClientes()
        {
            List<Cliente> result = mapper.TraerTodos();
            return result;
        }
        public static int InsertarCliente(string dni,string nombre,string apellido,string direccion)
        {
            Cliente cliente = new Cliente(dni, nombre, apellido, direccion);
            TransactionResult resultante = mapper.Insert(cliente);
            if (resultante.IsOk)
            {
                return resultante.Id;
            }
            else
            {
                throw new Exception("Hubo un problema con la petición al servidor. Detalle: " + resultante.Error);
            }
        }
    }
}
