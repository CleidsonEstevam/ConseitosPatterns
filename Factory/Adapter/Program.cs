using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaypalPayment payment = new PayonnerAdapter(new Payonner());

            payment.PaypalPayment();
            payment.PaypalReceive();

            Console.ReadLine();
        }
    }
}
