using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoPrestamo
    {
        int _id;
        string _linea;
        double _tna;
        public int Id { get => _id; set => _id = value; }
        public string Linea { get => _linea; set => _linea = value; }
        public double TNA { get => _tna; set => _tna = value; }
    }
}
