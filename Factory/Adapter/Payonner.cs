using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Payonner : IPayonnerPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo com Payonner!");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Fazendo pagamento com Payonner!");
        }
    }
}
