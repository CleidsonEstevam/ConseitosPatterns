using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface IPaypalPayment
    {
        Token AuthToken();
        void PaypalPayment();
        void PaypalReceive();

    }
}
