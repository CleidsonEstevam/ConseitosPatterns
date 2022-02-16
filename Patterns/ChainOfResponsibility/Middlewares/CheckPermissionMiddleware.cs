using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Middlewares
{
    class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Equals("master@gmail.com.br")) 
            {
                Console.WriteLine("Seja bem-vindo ADM.");
            }
            Console.WriteLine("Seja bem-vindo!");

            return CheckNext(email, password);
        }
    }
}
