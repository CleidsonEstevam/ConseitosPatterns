using ChainOfResponsibility.Serves;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Middlewares
{
    class CheckUserMiddleware : Middleware
    {
        private Server server;
        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }
        public override bool Check(string email, string password)
        {
            if (!server.HasEmail(email))
            {
                Console.WriteLine("Email inválido!");
            }
            if (!server.IsValidPassword(email, password)) 
            {
                Console.WriteLine("Email e?ou Senha inválidos!");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
