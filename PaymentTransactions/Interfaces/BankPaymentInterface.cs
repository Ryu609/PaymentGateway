using BankMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTransactions.Interfaces
{
    public interface BankPaymentInterface
    {
        PaymentResult ProcessPayment();
    }
}
