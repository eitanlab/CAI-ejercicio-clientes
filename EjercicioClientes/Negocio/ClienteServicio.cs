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
        public static List<Cliente> TraerClientes()
        {
            List<Cliente> result = ClienteMapper.TraerTodos();
            return result;
        }
        public static int InsertarCliente(string dni,string nombre,string apellido,string direccion)
        {
            Cliente cliente = new Cliente(dni, nombre, apellido, direccion);
            TransactionResult resultante = ClienteMapper.Insert(cliente);
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
