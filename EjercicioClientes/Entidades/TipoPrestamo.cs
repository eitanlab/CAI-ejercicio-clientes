using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoPrestamo
    {
        string _linea;
        double _tna;
        public string Linea { get => _linea; set => _linea = value; }
        public double TNA { get => _tna; set => _tna = value; }
    }
}
