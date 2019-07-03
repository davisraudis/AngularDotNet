namespace WebAPI.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public int LoanId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public Loan Loan { get; set; }

        public DateTime Date { get; set; }
    }
}
