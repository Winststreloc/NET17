﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson15_Homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestActionController : ControllerBase
    {
        // GET: api/<TestActionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TestActionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestActionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestActionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestActionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
