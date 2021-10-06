using FinancialFitness.Data;
using FinancialFitness.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinancialFitness.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IRepository<Transaction> Repository;

        public TransactionController(IRepository<Transaction> repo)
        {
            Repository = repo;
        }

        // GET: api/<TransactionController>
        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            List<Transaction> transList = this.Repository.FindAll().ToList();

            return transList;            
        }

        // GET api/<TransactionController>/5
        [HttpGet("{id}")]
        public Transaction Get(int id)
        {
            Transaction trans = this.Repository.Get(x => x.Id == id);

            return trans;
        }

        // POST api/<TransactionController>
        [HttpPost]
        public void Post([FromBody] Transaction value)
        {
            this.Repository.Create(value);
        }

        // PUT api/<TransactionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Transaction value)
        {
            this.Repository.Update(value);
        }

        // DELETE api/<TransactionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Transaction trans = this.Repository.Get(x => x.Id == id);

            if(trans != null)
            {
                this.Repository.Delete(trans);
            }            
        }
    }
}
