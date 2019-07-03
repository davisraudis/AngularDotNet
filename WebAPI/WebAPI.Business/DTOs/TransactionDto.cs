using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Business.DTOs
{
    public class TransactionDto
    {
        public decimal Amount { get; set; }

        public int LoanId { get; set; }
    }
}
