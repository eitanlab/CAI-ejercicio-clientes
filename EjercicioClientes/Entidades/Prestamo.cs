using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        string _linea;
        double _tna;
        int _plazo;
        double _monto;
        string _usuario;
        int _id;
        public string Linea { get => _linea; set => _linea = value; }
        public double TNA { get => _tna; set => _tna = value; }
        public int Plazo { get => _plazo; set => _plazo = value; }
        public double Monto { get => _monto; set => _monto = value; }
        public string Usuario { get => _usuario; set => _usuario= value; }
        public int Id { get => _id; set => _id = value; }
        public double CuotaCapital()
        {
            double resultado = _monto / _plazo;
            return resultado;
        }
        public double CuotaInteres
        {
            get
            {
                double resultado = CuotaCapital() * (_tna / 12 / 100);
                return resultado;
            }
        }
        public double Cuota
        {
            get
            {
                double resultado = CuotaCapital() + CuotaInteres;
                return resultado;
            }
        }
        public string Info
        {
            get
            {
                return ToString();
            }
        }

        public override string ToString()
        {
            return
                "Codigo: " + Id +
                " TNA: " + TNA +
                " Monto: " + Monto +
                " Plazo: " + Plazo;
        }
    }
}
