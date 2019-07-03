namespace WebAPI.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Loan
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        public int OwingToId { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public Person Person { get; set; }

        public Person OwingToPerson { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
