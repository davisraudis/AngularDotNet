using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI.Business.DTOs;
using WebAPI.Business.Managers.Interfaces;
using WebAPI.Business.Objects;
using WebAPI.Business.Repositories.Interfaces;
using WebAPI.Data.Models;

namespace WebAPI.Business.Managers
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRespository _personRepository;
        private readonly ILoanRepository _loanRepository;

        public PersonManager(IPersonRespository personRespository, ILoanRepository loanRepository)
        {
            _personRepository = personRespository;
            _loanRepository = loanRepository;
        }

        public PersonDto GetPerson(int personId)
        {
            return new PersonDto(_personRepository.GetPerson(personId));
        }

        public IEnumerable<PersonDto> GetPersons()
        {
            return _personRepository
                    .GetPersons()
                    .Select(p => new PersonDto(p));
        }

        public void AddPerson(PersonDto person)
        {
            _personRepository.AddPerson(new Person
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                PersonalCode = person.PersonalCode,
                Balance = person.Balance,
                Added = DateTime.Now
            });
        }

        // Par katru cilvēku noskaidro vai viņa bilance ir pozitīva vai negatīva
        public IEnumerable<BalanceInformationDto> GetAllPeopleBalance()
        {
            return _personRepository
                    .GetPersons()
                    .Select(p => new BalanceInformation(p))
                    .Select(b => new BalanceInformationDto(b));
        }

        // Atrod pašu lielāko aizdevēju
        public PersonDto GetTheBiggestLoanPerson()
        {
            var biggestLoan = _personRepository
                .GetPersons()
                .OrderByDescending(p => p.Loans?.Sum(l => l.Amount))
                .FirstOrDefault();

            return new PersonDto(biggestLoan);
        }

        // Atrod pašu lielāko aizņēmēju
        public PersonDto GetTheBiggestOwingPerson()
        {
            var biggestOwingPerson = _personRepository
                .GetPersons()
                .OrderByDescending(p => _loanRepository.GetLoansOwingBy(p.Id).Sum(l => l.Amount))
                .FirstOrDefault();

            return new PersonDto(biggestOwingPerson);
        }

        // Atrod katra cilvēka vidējo aizņēmumu lielumu
        public decimal GetPersonAverageOwingAmount(int personId)
        {
            return _loanRepository
                    .GetLoansOwingBy(personId)
                    .Average(l => l.Amount);
        }

        // Vislielāko procentu no aizņemtā ir atdevis
        public PersonDto GetPersonWithHighestTransactionPercent()
        {
            var person = _personRepository
                        .GetPersons()
                        .OrderByDescending(p => 
                            _loanRepository.GetLoansOwingBy(p.Id)
                            .Select(l => l.Transactions?.Sum(t => t.Amount) / l.Amount))
                        .FirstOrDefault();

            return new PersonDto(person);
        }

        // Vislielāko kopsummu aizņēmies.
        public PersonDto GetPersonMaxOwing()
        {
            var person = _personRepository
                        .GetPersons()
                        .OrderByDescending(p => _loanRepository.GetLoansOwingBy(p.Id).Sum(l => l.Amount))
                        .FirstOrDefault();

            return new PersonDto(person);
        }
    }
}
