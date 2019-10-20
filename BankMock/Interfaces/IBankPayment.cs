﻿using BankMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock.Interfaces
{
    public interface IBankPayment
    {
         Task<PaymentResult> ProcessPayment();
    }
}
