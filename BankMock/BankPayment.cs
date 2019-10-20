using BankMock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock
{
    public class BankPayment : IBankPayment
    {
        public async Task<PaymentResult> ProcessPayment()
        {
            await Task.Delay(1000);
            return new PaymentResult();
        }
    }
}
