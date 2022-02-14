using Builder.Buildes;
using Builder.Componentes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Diretores
{
    class Diretor
    {
        IBuilder builder;

        public Diretor(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstruirCarroSedan() 
        {
            builder.TipoDeVeiculo(TipoDeVeiculo.ESPORTIVO);
            builder.Motor(new Motor(2000));
            builder.Cambio(Cambio.AUTOMATICO);
        }
    }
}
