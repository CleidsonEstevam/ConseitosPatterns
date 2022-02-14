using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.VeiculosTerrestres
{
    class Moto : IVeiculoTerrestre
    {
        public void PegarCarga()
        {
            Console.WriteLine("Passageiro na moto!");
        }
        public void InicioDeRota()
        {
            PegarCarga();
            Console.WriteLine("Moto em deslocamento até o destino.");
        }

       
    }
}
