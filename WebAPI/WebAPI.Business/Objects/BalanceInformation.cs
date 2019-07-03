using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Data.Models;

namespace WebAPI.Business.Objects
{
    public class BalanceInformation
    {
        public Person Person { get; set; }

        public BalanceInformation(Person person)
        {
            if (person == null)
                return;

            Person = person;
        }

        public bool GetBalance()
        {
            return Person.Balance >= 0;
        }
    }
}
