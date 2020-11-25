using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public static class PrestamoServicio
    {
        public static List<Prestamo> TraerTodos()
        {
            List<Prestamo> result = PrestamoMapper.TraerTodos();
            return result;
        }
    }
}
