using Builder.Componentes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Produtos
{
    class Veiculo
    {
        private TipoDeVeiculo tipoDeVeiculo;
        private Cambio cambio;
        private Motor motor;

        public TipoDeVeiculo TipoDeVeiculo { get; set; }
        public Cambio Cambio { get; set; }
        public Motor Motor { get; set; }
    }
}
