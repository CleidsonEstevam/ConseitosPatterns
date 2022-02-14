using Factory.Veiculos;
using Factory.Veiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factores
{
    class TransporteBicicleta : Frota
    {
        protected override IVeiculos CriarVeiculo()
        {
            return new Bicicleta();
        }
    }
}
