using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class CuentasServicio
    {
        public static List<Cuenta> TraerTodos()
        {
            List<Cuenta> lst = CuentaMapper.TraerTodos();
            return lst;
        }
        public static int InsertarCuenta(string nroCuenta, string descripcion, int idCliente)
        {
            if (ClienteServicio.ExisteCliente(idCliente))
            {
                Cuenta cuenta = new Cuenta(nroCuenta, descripcion, idCliente);
                TransactionResult resultante = CuentaMapper.Insert(cuenta);
                if (resultante.IsOk)
                {
                    return resultante.Id;
                }
                else
                {
                    throw new Exception("Hubo un problema con la petición al servidor: " + resultante.Error);
                }
            } else
            {
                throw new Exception("El cliente que quiere asociar a la cuenta no existe");
            }
            
        } 
    }
}
