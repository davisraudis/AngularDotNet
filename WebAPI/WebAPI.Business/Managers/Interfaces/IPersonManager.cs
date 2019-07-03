using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Business.DTOs;

namespace WebAPI.Business.Managers.Interfaces
{
    public interface IPersonManager
    {
        PersonDto GetPerson(int personId);

        PersonDto GetPersonMaxOwing();

        PersonDto GetPersonWithHighestTransactionPercent();

        decimal GetPersonAverageOwingAmount(int personId);

        PersonDto GetTheBiggestOwingPerson();

        PersonDto GetTheBiggestLoanPerson();

        IEnumerable<BalanceInformationDto> GetAllPeopleBalance();

        IEnumerable<PersonDto> GetPersons();

        void AddPerson(PersonDto person);
    }
}
