using Factory.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factores.BaseVeiculo
{
    class TransporteCarro : Frota
    {
        protected override IVeiculos CriarVeiculo()
        {
            return new Carro();
        }
    }
}
