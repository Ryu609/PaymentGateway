﻿using PaymentTransactions;
using PaymentTransactions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PaymentGateway.Controllers
{
    public class PaymentController : ApiController
    {
        public void Process([FromBody] PaymentTransactionModel Transaction)
        {
            if (ModelState.IsValid)
            {
                // query to create entry in object, in this scenario i am just created a new object
                var PaymentService = new PaymentTransactions.PaymentTransactions();
                var result = PaymentService.CreateDatabaseTransaction();
                
                
            }
        }
    }
}