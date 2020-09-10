using NuestraApi.Data;
using NuestraApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuestraApi.Services
{
    public class MovieService
    {
        #region copyPaste
        private DataContext dataContext { get; set; }

        public MovieService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        #endregion

        public List<Movie> GetAllMovies()
        {
            var movies = dataContext.Movies.ToList();
            return movies;
        }

        public Movie GetById(int requestId)
        {
            var movieResponse = new Movie();

            var moviesDatabase = dataContext.Movies.ToList();

            foreach (var movieDb in moviesDatabase)
            {
                if (movieDb.Id == requestId)
                {
                    movieResponse.Id = movieDb.Id;
                    movieResponse.Title = movieDb.Title;
                    movieResponse.Director = movieDb.Director;
                    movieResponse.ReleaseDate = movieDb.ReleaseDate;
                }
            }

            return movieResponse;
        }

    }
}
