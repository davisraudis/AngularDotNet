using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Data.Models;

namespace WebAPI.Business.DTOs
{
    public class LoanDto
    {
        public LoanDto(Loan loan)
        {
            if (loan == null)
                return;

            PersonId = loan.PersonId;
            OwingToId = loan.OwingToId;
            Amount = loan.Amount;
        }

        public int PersonId { get; set; }

        public int OwingToId { get; set; }

        public decimal Amount { get; set; }
    }
}
