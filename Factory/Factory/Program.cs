using Factory.Factores;
using Factory.Factores.BaseVeiculo;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Frota transporte = null; 

            if (args.Length > 0 && args[0] == "Carro")
            {
                transporte = new TransporteCarro();
                Console.WriteLine(transporte);
            }
            else if (args.Length > 0 && args[0] == "Moto")
            {
                transporte = new TransporteMoto();
                Console.WriteLine(transporte);
            }
            else 
            {
                transporte = new TransporteBicicleta();
                Console.WriteLine(transporte);
            }

            transporte.CriandoTransporte();
            Console.ReadLine();
        }
    }
}
