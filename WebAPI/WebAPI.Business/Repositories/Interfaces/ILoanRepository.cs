using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Business.DTOs;
using WebAPI.Data.Models;

namespace WebAPI.Business.Repositories.Interfaces
{
    public interface ILoanRepository
    {
        void AddLoan(LoanDto loan);

        IEnumerable<Loan> GetLoans();

        IEnumerable<Loan> GetLoansOwingBy(int personId);

        void AddTransaction(TransactionDto loan);
    }
}
