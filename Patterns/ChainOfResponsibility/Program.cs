using ChainOfResponsibility.Middlewares;
using ChainOfResponsibility.Serves;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        private static Server server;
        static void Init()
        {
            server = new Server();

            server.RegisterUser("master@hcode.com.br", "123123sdfsdkjh$@%$");

            server.RegisterUser("user@hcode.com.br", "123456");

            Middleware middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());

            server.SetMiddeware(middleware);

        }

        static void Main(string[] args)
        {

            Init();

            Boolean done = false;

            do
            {

                Console.WriteLine("Digite o seu e-mail:");

                string email = Console.ReadLine();

                Console.WriteLine("Digite a sua senha:");

                string password = Console.ReadLine();

                done = server.Login(email, password);

            } while (!done);

            Console.ReadLine();

        }
    }
}
