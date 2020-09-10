using NuestraApi.Data;
using NuestraApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuestraApi.Services
{
    public class PopulateServices
    {
        private DataContext DataContext { get; set; }

        public PopulateServices(DataContext DataContext)
        {
            this.DataContext = DataContext;
        }

        public void FillDataMovies()
        {
            var movie1 = new Movie()
            {
                Title = "Deadpool",
                Director = "Samira Cardenas",
                ReleaseDate = DateTime.Now
            };

            DataContext.Movies.Add(movie1);

            var movie2 = new Movie()
            {
                Title = "Harry Potter and the Deathly Hallows",
                Director = "Tomos Coleman",
                ReleaseDate = DateTime.Now
            };

            DataContext.Movies.Add(movie2);

            var movie3 = new Movie()
            {
                Title = "Bloodshot",
                Director = "Anil Derrick",
                ReleaseDate = DateTime.Now
            };

            DataContext.Movies.Add(movie3);

            var movie4 = new Movie()
            {
                Title = "Ice Age",
                Director = "Dafydd Gibbs",
                ReleaseDate = DateTime.Now
            };

            DataContext.Movies.Add(movie4);

            var movie5 = new Movie()
            {
                Title = "The Pale Door",
                Director = "Ines Storey",
                ReleaseDate = DateTime.Now
            };

            DataContext.Movies.Add(movie5);

            var movie6 = new Movie()
            {
                Title = "The Shawshank Redemption",
                Director = "Zain Holden",
                ReleaseDate = DateTime.Now
            };

            DataContext.Movies.Add(movie6);

            var movie7 = new Movie()
            {
                Title = "Gladiator",
                Director = "Eric Hayden",
                ReleaseDate = DateTime.Now
            };

            DataContext.Movies.Add(movie7);

            var movie8 = new Movie()
            {
                Title = "Troya",
                Director = "Beauden Crawford",
                ReleaseDate = DateTime.Now
            };

            DataContext.Movies.Add(movie8);

            var movie9 = new Movie()
            {
                Title = "300",
                Director = "Harrison Kirkpatrick",
                ReleaseDate = DateTime.Now
            };

            DataContext.Movies.Add(movie9);

            var movie10 = new Movie()
            {
                Title = "The Fifth Element",
                Director = "Reon Powell",
                ReleaseDate = DateTime.Now
            };

            DataContext.Movies.Add(movie10);

            DataContext.SaveChanges();
        }

        public void FillDataGames()
        {
            //var game01 = new Game()
            //{
            //    Id = 1,
            //    <prop02> = <value02>,
            //    <prop03> = <value03>,
            //    <prop04> = <value04>,
            //    <prop05> = <value05>,
            //    <prop06> = <value06>
            //};
            //DataContext.Games.Add(game01);

            //var game02 = new Game()
            //{
            //    Id = 2,
            //    <prop02> = <value02>,
            //    <prop03> = <value03>,
            //    <prop04> = <value04>,
            //    <prop05> = <value05>,
            //    <prop06> = <value06>
            //};
            //DataContext.Games.Add(game02);

            //var game03 = new Game()
            //{
            //    Id = 3,
            //    <prop02> = <value02>,
            //    <prop03> = <value03>,
            //    <prop04> = <value04>,
            //    <prop05> = <value05>,
            //    <prop06> = <value06>
            //};
            //DataContext.Games.Add(game03);

            //var game04 = new Game()
            //{
            //    Id = 4,
            //    <prop02> = <value02>,
            //    <prop03> = <value03>,
            //    <prop04> = <value04>,
            //    <prop05> = <value05>,
            //    <prop06> = <value06>
            //};
            //DataContext.Games.Add(game04);

            //var game05 = new Game()
            //{
            //    Id = 5,
            //    <prop02> = <value02>,
            //    <prop03> = <value03>,
            //    <prop04> = <value04>,
            //    <prop05> = <value05>,
            //    <prop06> = <value06>
            //};
            //DataContext.Games.Add(game05);


            DataContext.SaveChanges();
        }

        public void FillDataSerie()
        {
            var serie01 = new Serie()
            {
                
                Title = "Chernobyl",
                Genre = "Drama",
                ReleaseDate = DateTime.Parse("05/06/2019"),
                Director = "Johan Renck",
                Award = true,
                Older18 = false,
            };
            DataContext.Series.Add(serie01);

            var serie02 = new Serie()
            {
               
                Title = "Breaking Bad",
                Genre = "Drama criminal",
                ReleaseDate = DateTime.Parse("01/20/2008"),
                Director = "Vince Gilligan, Terry McDonough, Johan Renck, Michelle MacLaren, Colin Bucksey y Michael Slovis",
                Award = true,
                Older18 = false,
            };
            DataContext.Series.Add(serie02);

            var serie03 = new Serie()
            {
                
                Title = "Peaky Blinders",
                Genre = "Crimen Ficticio",
                ReleaseDate = DateTime.Parse("09/12/2013"),
                Director = "Tim Mielants y David Caffrey",
                Award = true,
                Older18 = true,
            };
            DataContext.Series.Add(serie03);

            var serie04 = new Serie()
            {
                
                Title = "The Witcher",
                Genre = "Fantasia",
                ReleaseDate = DateTime.Parse("12/20/2019"),
                Director = "‎Mike Ostrowski",
                Award = false,
                Older18 = true,
            };
            DataContext.Series.Add(serie04);

            var serie05 = new Serie()
            {
                
                Title = "Hunter x Hunter",
                Genre = "Anime, Aventura",
                ReleaseDate = DateTime.Parse("10/02/2011"),
                Director = "Kazuhiro Furuhashi",
                Award = false,
                Older18 = false,
            };
            DataContext.Series.Add(serie05);


            DataContext.SaveChanges();
        }
    }
}
