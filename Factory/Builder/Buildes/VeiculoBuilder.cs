using Builder.Componentes;
using Builder.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Buildes
{
    class VeiculoBuilder : IBuilder
    {
        private Veiculo veiculo = new Veiculo();
        public void GetCambio(Cambio cambio)
        {
            veiculo.Cambio = cambio;
        }

        public Veiculo GetVeiculo()
        {
            Veiculo result = veiculo;
            Reset();
            return result;
        }

        public void Motor(Motor motor)
        {
            veiculo.Motor = motor;
        }

        public void Reset()
        {
            veiculo = new Veiculo();
        }

        public void TipoDeVeiculo(TipoDeVeiculo tipoDeVeiculo)
        {
            veiculo.TipoDeVeiculo = tipoDeVeiculo;
        }
    }
}
