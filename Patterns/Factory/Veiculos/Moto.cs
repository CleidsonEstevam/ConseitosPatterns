using Factory.Veiculos;
using System;

namespace Factory.Factores
{
    public class Moto : IVeiculos
    {
        public void GetCarga()
        {
            Console.WriteLine("Encomenda coletada.");
        }

        public void ComecarRota()
        {
            GetCarga();
            Console.WriteLine("A caminho.");
        }
    }
}
