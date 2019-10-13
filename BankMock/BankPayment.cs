using BankMock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock
{
    public class BankPayment : IBankPaymentInterface
    {
        public PaymentResult ProcessPayment()
        {
            return new PaymentResult();
        }
    }
}
