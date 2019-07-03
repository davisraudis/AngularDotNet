namespace WebAPI.Business.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using WebAPI.Business.DTOs;
    using WebAPI.Data;
    using WebAPI.Data.Models;

    public class PersonRepository : IPersonRespository
    {
        private readonly ApiContext _context;

        public PersonRepository(ApiContext context)
        {
            _context = context;
        }

        public Person GetPerson(int id)
        {
            return _context.Persons.FirstOrDefault(p => p.Id == id);
        }

        public Person GetPersonLoans(int id)
        {
            return _context.Persons.Include(p => p.Loans).FirstOrDefault(p => p.Id == id);
        }

        public void AddPerson(Person person)
        {
            _context.Persons.Add(person);
            Save();
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        public IEnumerable<Person> GetPersons()
        {
            return _context.Persons.ToList();
        }
    }
}
