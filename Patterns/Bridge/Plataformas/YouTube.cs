using System;

namespace Bridge.Plataformas
{
    class YouTube : IPlataforma
    {
        public YouTube()
        {
            ConfiguracaoRMTP();
            Console.WriteLine("Youtube: Transmissao iniciada!");
        }
        public void AuthToken()
        {
            Console.WriteLine("Youtube: autorizando...");
        }

        public void ConfiguracaoRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando Servidor!");
        }
    }
}
