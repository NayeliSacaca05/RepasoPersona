using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoPersona.Core
{
    public class Importe
    {
        public double Monto { get; protected set; }
        public double Saldo { get; private set; }
        public Importe(double monto, double saldo)
        {
            Monto = monto;
            Saldo = saldo;
        }


    }
}