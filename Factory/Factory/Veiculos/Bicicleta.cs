using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Veiculos.Interfaces
{
    class Bicicleta : IVeiculos
    {
        public void GetCarga()
        {
            Console.WriteLine("Bicicleta em movimento"); 
        }

        public void ComecarRota()
        {
            GetCarga();
            Console.WriteLine("Ciclista a caminho.");
        }
    }
}
