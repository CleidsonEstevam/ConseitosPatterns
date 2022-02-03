using Factory.Veiculos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Factores
{
    class TransporteMoto : Frota
    {
        protected override IVeiculos CriarVeiculo()
        {
            return new Moto();
        }
    }
}
