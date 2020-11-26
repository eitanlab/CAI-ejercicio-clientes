using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operador
    {
        List<Prestamo> _prestamos;
        double _comision;
        double _porcentajeComision;
        public Operador(List<Prestamo> prestamos)
        {
            _prestamos = prestamos;
            _porcentajeComision = 0;
            _prestamos.ForEach(prestamo =>
            {
                _porcentajeComision += prestamo.CuotaInteres * prestamo.Plazo * 0.15;
            });
        }
        public double PorcentajeComision { get => _porcentajeComision; }
    }
}
