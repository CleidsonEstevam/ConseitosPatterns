using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Aeronaves
{
    class Aviao : IAeronave
    {
        public void ChecarClima()
        {
            Console.WriteLine("Ventos ok, temperatura ok!");
        }
        public void PegarCarga()
        {
            Console.WriteLine("Passageiros a bordo!");
        }

        public void InicioDeRota()
        {
            ChecarClima();
            PegarCarga();
            Console.WriteLine("Avião decolando!");
        }

       
    }
}
