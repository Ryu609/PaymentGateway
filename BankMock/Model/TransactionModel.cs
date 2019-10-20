using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock.Model
{
    public class TransactionModel
    {
        public string TransactionId { get; set; }
        public string CardType { get; set; }
        public int CardNumber { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OTP { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public TransactionStatus Status { get; set; }
    }
    public enum TransactionStatus
    {
        Success = 0,
        Failed = 1,
        Cancelled = 2,
        Pending = 3
    }
}
