using System.Collections.Generic;
using WebAPI.Business.DTOs;

namespace WebAPI.Business.Managers
{
    public interface ILoanManager
    {
        IEnumerable<LoanDto> GetLoans();

        void AddLoan(LoanDto loan);

        void AddTransaction(TransactionDto loan);
    }
}