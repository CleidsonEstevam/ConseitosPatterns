using AbstractFactory.App;
using AbstractFactory.Factories;
using System;


namespace AbstractFactory
{
    class Program
    {
        static Application ConfigurarAplicacao() 
        {
            Application app;

            ITransporteFactory transportefactory;
            string compaia = "99";
            if (compaia == "Uber")
            {
                transportefactory = new Uber();
            }
            else 
            {
                transportefactory = new NoventaENoveTaxi();
            }
            app = new Application(transportefactory);
            return app;
        
        }

        static void Main(string[] args)
        {
            Application app = ConfigurarAplicacao();
            app.IniciarRota();

            Console.ReadLine();
        }
    }
}
