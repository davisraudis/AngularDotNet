using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Business.Objects;

namespace WebAPI.Business.DTOs
{
    public class BalanceInformationDto
    {
        public BalanceInformationDto(BalanceInformation balanceInformation)
        {
            if (balanceInformation == null)
                return;

            IsPositive = balanceInformation.GetBalance();
            Person = new PersonDto(balanceInformation.Person);
        }

        public PersonDto Person { get; set; }

        public bool IsPositive { get; set; }
    }
}
