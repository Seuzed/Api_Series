using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NuestraApi.Data;
using NuestraApi.Services;

namespace NuestraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopulateController : ControllerBase
    {
        private DataContext DataContext { get; set; }

        public PopulateController(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }


        // GET: api/<MovieController>
        [HttpGet("Movies")]
        public void PopulateMovies()
        {
            var service = new PopulateServices(DataContext);
            service.FillDataMovies();
        }

        // GET: api/<MovieController>
        [HttpGet("Series")]
        public void PopulateAlbums()
        {
            var service = new PopulateServices(DataContext);
            service.FillDataSerie();
        }

        // GET: api/<MovieController>
        [HttpGet("Games")]
        public void PopulateGames()
        {
            var service = new PopulateServices(DataContext);
            service.FillDataGames();
        }
    }
}
