using BlazorMovie.Client.Contracts;
using BlazorMovie.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovie.Client.Repositories
{
    public class InMemoryRepository : IRepository
    {
        public List<MovieModel> GetMovies()
        {
            return new List<MovieModel>()
            {
                new MovieModel
                {
                    Release = new DateTime(2018, 5, 25),
                    Title = "Spiderman 1"
                },

                new MovieModel
                {
                    Release = new DateTime(2019, 9, 28),
                    Title = "Spiderman 2"
                },

                new MovieModel
                {
                    Release = new DateTime(2020, 5, 25),
                    Title = "Spiderman 3"
                },
            };
        }
    }
}
