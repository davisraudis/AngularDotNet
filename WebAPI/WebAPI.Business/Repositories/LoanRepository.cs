using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI.Business.DTOs;
using WebAPI.Business.Repositories.Interfaces;
using WebAPI.Data;
using WebAPI.Data.Models;

namespace WebAPI.Business.Repositories
{
    public class LoanRepository : ILoanRepository
    {
        private readonly ApiContext _context;

        public LoanRepository(ApiContext context)
        {
            _context = context;
        }

        public void AddLoan(LoanDto loan)
        {
            _context.Loans.Add(
                new Loan
                {
                    PersonId = loan.PersonId,
                    OwingToId = loan.OwingToId,
                    Amount = loan.Amount
                });

            Save();
        }

        public void AddTransaction(TransactionDto loan)
        {
            _context.Transactions.Add(
                new Transaction
                {
                    LoanId = loan.LoanId,
                    Amount = loan.Amount
                });

            Save();
        }

        public IEnumerable<Loan> GetLoans()
        {
            return _context.Loans.ToList();
        }

        public IEnumerable<Loan> GetLoansOwingBy(int personId)
        {
            return _context.Loans.Where(l => l.OwingToId == personId);
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}
