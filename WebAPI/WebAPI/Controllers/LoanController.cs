using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Business.DTOs;
using WebAPI.Business.Managers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILoanManager _loanManager;

        public LoanController(ILoanManager loanManager)
        {
            _loanManager = loanManager;
        }

        // GET: api/Loan
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_loanManager.GetLoans());
            }
            catch(Exception e)
            {
                return BadRequest();
            }
        }

        // POST: api/Loan
        [HttpPost]
        [Route("Loan")]
        public void Post([FromBody] LoanDto loan)
        {
            _loanManager.AddLoan(loan);
        }

        [HttpPost]
        [Route("Transaction")]
        public void Post([FromBody] TransactionDto transaction)
        {
            _loanManager.AddTransaction(transaction);
        }
    }
}
