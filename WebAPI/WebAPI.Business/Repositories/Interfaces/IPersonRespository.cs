using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Business.DTOs;
using WebAPI.Data.Models;

namespace WebAPI.Business
{
    public interface IPersonRespository
    {
        IEnumerable<Person> GetPersons();

        Person GetPerson(int id);

        Person GetPersonLoans(int id);

        bool Save();

        void AddPerson(Person person);
    }
}
