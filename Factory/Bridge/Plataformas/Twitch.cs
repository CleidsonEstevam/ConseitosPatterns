using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Plataformas
{
    class Twitch : IPlataforma
    {
        public Twitch()
        {
            ConfiguracaoRMTP();
            Console.WriteLine("Twitch: Transmissao iniciada!");
        }
        public void AuthToken()
        {
            Console.WriteLine("Twitch: autorizando...");
        }

        public void ConfiguracaoRMTP()
        {
            AuthToken();
            Console.WriteLine("Twitch? Configurando Servidor!");
        }
    }
}
