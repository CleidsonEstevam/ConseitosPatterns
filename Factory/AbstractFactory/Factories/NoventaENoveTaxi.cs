using AbstractFactory.Aeronaves;
using AbstractFactory.VeiculosTerrestres;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    class NoventaENoveTaxi : ITransporteFactory
    {
        public IAeronave CriarTransporteAerio()
        {
            return new Helicoptero();
        }

        public IVeiculoTerrestre CriarTransporteTerrestre()
        {
            return new Moto();
        }
    }
}
