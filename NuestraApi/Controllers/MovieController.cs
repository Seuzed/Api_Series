using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using NuestraApi.Data;
using NuestraApi.Entities;
using NuestraApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NuestraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        #region copyPaste
        private DataContext dataContext { get; set; }

        public MovieController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        #endregion

        // GET: api/<MovieController>
        [HttpGet]
        public List<Movie> GetAllMovies()
        {
            var service = new MovieService(dataContext);
            var movies = service.GetAllMovies();
            return movies;
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public Movie Get(int requestId)
        {
            var service = new MovieService(dataContext);
            var movie = service.GetById(requestId);
            return movie;
        }

        // POST api/<MovieController>
        [HttpPost]
        public void Post([FromBody] Movie request)
        {
            //var service = new MovieService(dataContext);
            //var movie = service.Create(request);
            //return movie;
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
