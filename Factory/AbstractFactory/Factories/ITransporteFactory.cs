using AbstractFactory.Aeronaves;
using AbstractFactory.VeiculosTerrestres;

namespace AbstractFactory.Factories
{
    interface ITransporteFactory
    {
        IAeronave CriarTransporteAerio();
        IVeiculoTerrestre CriarTransporteTerrestre();
    }
}
