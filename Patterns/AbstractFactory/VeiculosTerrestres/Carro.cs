using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.VeiculosTerrestres
{
    class Carro : IVeiculoTerrestre
    {
        public void PegarCarga()
        {
            Console.WriteLine("Pegamos os Passageiros!");
        }
        public void InicioDeRota()
        {
            PegarCarga();
            Console.WriteLine("Carro em movimento, rota iniciada!");
        }
    }
}
