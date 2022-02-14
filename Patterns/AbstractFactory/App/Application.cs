using AbstractFactory.Aeronaves;
using AbstractFactory.Factories;
using AbstractFactory.VeiculosTerrestres;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.App
{
    class Application
    {
        private IAeronave aeronave;
        private IVeiculoTerrestre veiculoTerrestre;

        public Application(ITransporteFactory factory) 
        {
            aeronave = factory.CriarTransporteAerio();
            veiculoTerrestre = factory.CriarTransporteTerrestre();
        }

        public void IniciarRota() 
        {
            veiculoTerrestre.InicioDeRota();
            aeronave.InicioDeRota();
        }

    }
}
