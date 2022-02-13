using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class PayonnerAdapter : IPaypalPayment
    {
        private Payonner payonner;
        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
        }
        public Token AuthToken()
        {
            return this.payonner.AuthToken();
        }

        public void PaypalPayment()
        {
            this.payonner.SendPayment();
        }

        public void PaypalReceive()
        {
            this.payonner.ReceivePayment();
        }
    }
}
