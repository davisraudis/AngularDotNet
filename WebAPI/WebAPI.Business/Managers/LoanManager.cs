using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI.Business.DTOs;
using WebAPI.Business.Repositories.Interfaces;

namespace WebAPI.Business.Managers
{
    public class LoanManager : ILoanManager
    {
        private readonly IPersonRespository _personRepository;
        private readonly ILoanRepository _loanRepository;

        public LoanManager(IPersonRespository personRespository, ILoanRepository loanRepository)
        {
            _personRepository = personRespository;
            _loanRepository = loanRepository;
        }

        public IEnumerable<LoanDto> GetLoans()
        {
            return _loanRepository.GetLoans().Select(l => new LoanDto(l));
        }

        public void AddLoan(LoanDto loan)
        {
            _loanRepository.AddLoan(loan);
        }

        public void AddTransaction(TransactionDto loan)
        {
            _loanRepository.AddTransaction(loan);
        }
    }
}
