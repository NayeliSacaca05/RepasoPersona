using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoPersona.Core
{
    public class Cuenta
    {
        public double Saldo { get; protected set; }
        public int CBU { get; private set; }
        public Cuenta() => Saldo = 0;

        public Cuenta (double saldo, int cbu)
        {
            saldo = Saldo;
            cbu = CBU;
        }

        public void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > Saldo)
                throw new InvalidOperationException("El monto supera al efectivo.");
            Saldo -= monto;
        }

    }
}