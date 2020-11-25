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
        public List<Prestamo> Prestamos { get => _prestamos; set => _prestamos= value; }
        public double Comision { get => _comision; set => _comision= value; }
        //public double PorcentajeComision{
        //    get {
        //        double comisiones = 0;
        //        _prestamos.ForEach(prestamo =>
        //        {
        //            comisiones += prestamo.CuotaInteres * prestamo.Plazo * 0.15;
        //        });
        //        return comisiones;
        //    } 
        //}
    }
}
