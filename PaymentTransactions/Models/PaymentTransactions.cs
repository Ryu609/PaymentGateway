using PaymentTransactions.Models;
using PaymentTransactions.ResultsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTransactions
{
    public class PaymentTransactions
    {
        public TransactionsResultModel CreateDatabaseTransaction(PaymentTransactionModel transaction)
        {
            return new TransactionsResultModel();
        }

        public object GetTransactionDetails(string transactionId)
        {
            throw new NotImplementedException();
        }
    }
}
