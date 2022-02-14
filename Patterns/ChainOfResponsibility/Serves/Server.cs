using ChainOfResponsibility.Middlewares;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Serves
{
    class Server
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();
        private Middleware middleware;

        public void SetMiddeware(Middleware middlewares) 
        {
            this.middleware = middleware;
        }

        public Boolean Login(string email, string password) 
        {
            if (middleware.Check(email, password)) 
            {
              Console.WriteLine("Usuario autorizado");
                return true;
            }
            return false;
        }
        public void RegisterUser(string email, string password)
        {
            users[email] = password;
        }
        public Boolean HasEmail(string email)
        {
            return users.ContainsKey(email);
        }
        public Boolean IsValidPassword(string email, string password)
        {
            string value = "";
            users.TryGetValue(email, out value);
            return password == value;
        }


    }
}
