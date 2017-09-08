using Microsoft.AspNetCore.Mvc;
using MyMovieApi.Models;
using MyMovieApi.Service;
using System.Collections.Generic;

namespace MyMovieApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private ImovieService res;


        public ValuesController(ImovieService resService)
        {
            res = resService;


        }
        // GET api/values
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return res.Get();
        }

        // GET api/values/5
        [Route("api/values/{id}")]
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return res.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Movie value)
        {
            res.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Movie value)
        {
            res.Update(id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        { 

             res.Delete(id);
        }
    }
}
