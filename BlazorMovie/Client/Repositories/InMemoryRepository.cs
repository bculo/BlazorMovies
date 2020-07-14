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
                    Release = new DateTime(2002, 5, 25),
                    Title = "Spider-Man",
                    Poster = "https://m.media-amazon.com/images/M/MV5BZDEyN2NhMjgtMjdhNi00MmNlLWE5YTgtZGE4MzNjMTRlMGEwXkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_.jpg"
                },

                new MovieModel
                {
                    Release = new DateTime(2012, 9, 28),
                    Title = "The Amazing Spider-Man",
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjMyOTM4MDMxNV5BMl5BanBnXkFtZTcwNjIyNzExOA@@._V1_SY1000_CR0,0,674,1000_AL_.jpg"
                },

                new MovieModel
                {
                    Release = new DateTime(2014, 5, 25),
                    Title = "The Amazing Spider-Man 2",
                    Poster = "https://m.media-amazon.com/images/M/MV5BOTA5NDYxNTg0OV5BMl5BanBnXkFtZTgwODE5NzU1MTE@._V1_SY1000_SX675_AL_.jpg"
                },
            };
        }
    }
}
