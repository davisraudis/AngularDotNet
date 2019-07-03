using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI.Data.Models;

namespace WebAPI.Business.Objects
{
    public class LoanInformation
    {
        private Loan Loan { get; }

        public LoanInformation(Loan loan)
        {
            if (loan == null)
                return;

            Loan = loan;
        }

        public decimal GetLoanBalance()
        {
            return Loan.Amount - Loan.Transactions.Sum(t => t.Amount);
        }
    }
}
