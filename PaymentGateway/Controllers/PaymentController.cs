using PaymentTransactions;
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
        public HttpResponseMessage Process([FromBody] PaymentTransactionModel Transaction)
        {
            if (ModelState.IsValid)
            {
                // query to create entry in object, in this scenario i am just creating a new object
                var PaymentService = new PaymentService();
                var result = PaymentService.CreateDatabaseTransaction(Transaction);
                
                

                // Log result
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Wrong Parameters Passed!");
        }

        public HttpResponseMessage GetDetails(string TransactionId)
        {
            var PaymentService = new PaymentService();
            var result = PaymentService.GetTransactionDetails(TransactionId);
            
            //Log Result
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }        
    }
}
