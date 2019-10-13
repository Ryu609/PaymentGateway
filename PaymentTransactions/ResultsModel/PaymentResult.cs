using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTransactions.ResultsModel
{
    public class PaymentResult
    {
        public int TransactionId { get; set; }        
        public TransactionResult TransactionResult { get; set; }
        
    }
   public enum TransactionResult
    {
        Success = 0,
        Failed = 1,
        Cancelled = 2,
        Pending = 3        
    }
}
