using Bridge.Plataformas;
using Bridge.Transmissao;
using System;

namespace Bridge
{
    class Program
    {
        static void StartLive(IPlataforma plataforma) 
        {
            Console.WriteLine("Aguarde...");
            Live live = new Live(plataforma);

            live.Transmissao();
            live.resultado();
        }

        static void Main(string[] args)
        {
            StartLive(new YouTube());

            Console.ReadLine();
        }
    }
}
