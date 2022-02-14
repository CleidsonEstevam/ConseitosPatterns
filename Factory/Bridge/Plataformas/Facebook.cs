using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Plataformas
{
    class Facebook : IPlataforma
    {
        public Facebook()
        {
            ConfiguracaoRMTP();
            Console.WriteLine(" Facebook: Transmissao iniciada!");
        }
        public void AuthToken()
        {
            Console.WriteLine("Facebook: autorizando...");
        }

        public void ConfiguracaoRMTP()
        {
            AuthToken();
            Console.WriteLine("Facebook: Configurando Servidor!");
        }
    }
}
