using Bridge.Plataformas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Transmissao
{
    class Live : ITransmissao
    {
        protected IPlataforma plataforma;
        public Live(IPlataforma plataforma)
        {
            this.plataforma = plataforma;
        }
        public void resultado()
        {
            Console.WriteLine("No Ar!");
        }

        public void Transmissao()
        {
            Console.WriteLine($"Iniciando a transmissão: {plataforma}");
        }
    }
}
