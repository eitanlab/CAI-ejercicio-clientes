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
        public static int ModificarSaldo(int id, double saldo)
        {
            if(ExisteCuenta(id))
            {
                Cuenta cuenta = new Cuenta();
                cuenta.Id = id;
                cuenta.Saldo = saldo;

                if (cuenta.Saldo < 0)
                {
                    throw new Exception("El saldo debe ser positivo");
                }    

                if (cuenta.Id <= 0)
                {
                    throw new Exception("Se ha ingresado un id de cuenta inválido");
                }

                TransactionResult t = CuentaMapper.Actualizar(cuenta);

                if (!t.IsOk)
                {
                    throw new Exception("Error al modificar el saldo de la cuenta. " + t.Error);
                }
            } else
            {
                throw new Exception("La cuenta no existe");
            }
            return 0;
        }
        public static bool ExisteCuenta(int id)
        {
            List<Cuenta> cuentas = TraerTodos();
            foreach (Cuenta c in cuentas)
            {
                if (c.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
