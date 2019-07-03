namespace WebAPI.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Person
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(32)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(32)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(12)]
        public string PersonalCode { get; set; }

        [Required]
        public DateTime Added { get; set; }

        public decimal Balance { get; set; }

        public List<Loan> Loans { get; set; }

        public List<Loan> LoansOwing { get; set; }
    }
}
