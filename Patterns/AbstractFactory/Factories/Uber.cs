using AbstractFactory.Aeronaves;
using AbstractFactory.VeiculosTerrestres;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    class Uber : ITransporteFactory
    {
        public IAeronave CriarTransporteAerio()
        {
            return new Aviao();
        }

        public IVeiculoTerrestre CriarTransporteTerrestre()
        {
            return new Carro();
        }
    }
}
