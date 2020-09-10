using Microsoft.AspNetCore.Mvc;
using NuestraApi.Data;
using NuestraApi.Entities;
using NuestraApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuestraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        private DataContext DataContext { get; set; }

        public SerieController(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        // GET: api/<MovieController>
        [HttpGet]
        public List<Serie> GetAllSeries()
        {
            var service = new SerieService(DataContext);
            var series = service.GetAllSeries();
            return series;
        }
        // GET: api/<MovieController>
        [HttpGet("Series")]
        public void PopulateAlbums()
        {
            var service = new PopulateServices(DataContext);
            service.FillDataSerie();
        }

        [HttpGet("{id}")]
        public Serie Get(int requestId)
        {
            var service = new SerieService(DataContext);
            var serie = service.GetById(requestId);
            return serie;
        }

        [HttpPost]
        public string Create([FromBody] Serie SerieRequest)
        {
            var service = new SerieService(DataContext);
            service.Create(SerieRequest);
            return "El recurso se creó correctamente";
        }

        [HttpPut]
        public string Update([FromBody] Serie SerieRequest)
        {
            var service = new SerieService(DataContext);
            service.Update(SerieRequest);
            return "El recurso se modifico correctamente";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            var service = new SerieService(DataContext);
            service.Delete(id);

            return "El recurso se elimino correctamente";

        }
    }
}
