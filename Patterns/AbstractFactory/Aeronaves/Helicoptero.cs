using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Aeronaves
{
    class Helicoptero : IAeronave
    {
        public void ChecarClima()
        {
            Console.WriteLine("Clima Ok!");
        }
        public void PegarCarga()
        {
            Console.WriteLine("Passageiro a Bordo!");
        }
        public void InicioDeRota()
        {
            ChecarClima();
            PegarCarga();
            Console.WriteLine("Helicóptero decolando.");
        }
    }
}
