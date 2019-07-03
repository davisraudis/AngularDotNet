using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Data.Models;

namespace WebAPI.Business.DTOs
{
    public class PersonDto
    {
        public PersonDto(Person person)
        {
            if (person == null)
                return;

            FirstName = person.FirstName;
            LastName = person.LastName;
            PersonalCode = person.PersonalCode;
            Balance = person.Balance;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PersonalCode { get; set; }

        public decimal Balance { get; set; }
    }
}
