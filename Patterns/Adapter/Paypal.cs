using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Paypal : IPaypalPayment
    {
        private Token token;
        public Token AuthToken()
        {
           return new Token();
        }

        public void PaypalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com PayPal");
        }

        public void PaypalReceive()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com PayPal");
        }
    }
}
