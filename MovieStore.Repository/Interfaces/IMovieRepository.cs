using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Repository.Interfaces
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);
        void EditMovie(Movie movie);
        void DeleteMovie(int movieId);

        Movie GetMovieById(int id);

        IEnumerable<Movie> GetAllMovies();
    }
}
