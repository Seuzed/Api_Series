using NuestraApi.Data;
using NuestraApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuestraApi.Services
{
    public class SerieService
    {
        private DataContext dataContext { get; set; }

        public SerieService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }


        public List<Serie> GetAllSeries()
        {
            var series = dataContext.Series.ToList();
            return series;
        }

        public Serie GetById(int requestId)
        {
            var serieResponse = new Serie();

            var seriesDatabase = dataContext.Series.ToList();

            foreach (var serieDb in seriesDatabase)
            {
                if (serieDb.Id == requestId)
                {
                    serieResponse.Id = serieDb.Id;
                    serieResponse.Title = serieDb.Title;
                    serieResponse.Genre = serieDb.Genre;
                    serieResponse.ReleaseDate = serieDb.ReleaseDate;
                    serieResponse.Director = serieDb.Title;
                    serieResponse.Award = serieDb.Award;
                    serieResponse.Older18 = serieDb.Older18;
                }
            }

            return serieResponse;
        }

        internal void Delete(int id)
        {
            throw new NotImplementedException();
        }

        internal void Create(Serie serieRequest)
        {
            throw new NotImplementedException();
        }

        internal void Update(Serie serieRequest)
        {
            throw new NotImplementedException();
        }
    }
}
