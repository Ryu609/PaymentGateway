using PaymentTransactions.Models;
using PaymentTransactions.ResultsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTransactions
{
    public class PaymentService
    {
        public TransactionsResultModel CreateDatabaseTransaction(PaymentTransactionModel transaction)
        {
            //todo - mock create to transaction and communicate with bank api
            //todo - connect to bank Api 
            var bankmock = new BankMock.BankPayment();
            var transactionResult = bankmock.ProcessPayment();

            return new TransactionsResultModel();
            //Include Try Catch
        }

        public object GetTransactionDetails(string transactionId)
        {
            //todo - mock search transaction from database
            throw new NotImplementedException();
            //Include Try Catch
        }
    }
}
