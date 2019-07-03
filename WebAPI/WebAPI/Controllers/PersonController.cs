
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Business;
using WebAPI.Business.DTOs;
using WebAPI.Business.Managers.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonManager _personManager;

        public PersonController(IPersonManager personManager)
        {
            _personManager = personManager;
        }

        // GET: api/Person
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personManager.GetPersons());
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            return Ok(_personManager.GetPerson(id));
        }

        [HttpGet]
        [Route("GetPersonWithHighestTransactionPercent")]
        public IActionResult GetPersonWithHighestTransactionPercent()
        {
            return Ok(_personManager.GetPersonWithHighestTransactionPercent());
        }

        [HttpGet]
        [Route("GetTheBiggestLoanPerson")]
        public IActionResult GetTheBiggestLoanPerson()
        {
            return Ok(_personManager.GetTheBiggestLoanPerson());
        }

        [HttpGet]
        [Route("GetTheBiggestOwingPerson")]
        public IActionResult GetTheBiggestOwingPerson()
        {
            return Ok(_personManager.GetTheBiggestOwingPerson());
        }

        // POST: api/Person
        [HttpPost]
        public IActionResult Post([FromBody] PersonDto person)
        {
            try
            {
                _personManager.AddPerson(person);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
