using Factory.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factores
{
    class Carro : IVeiculos
    {
        public void GetCarga()
        {
            Console.WriteLine("Passageiro a bordo");
        }

        public void ComecarRota()
        {
            ComecarRota();
            Console.WriteLine("Em rota.");
        }
    }
}
