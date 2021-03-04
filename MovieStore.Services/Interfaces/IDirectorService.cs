using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services.Interfaces
{
    public interface IDirectorService
    {
        void Add(Director director);

        void Edit(Director director);

        void Delete(int directorId);

        Director GetDirectorById(int id);

        IEnumerable<Director> GetAllDirectors();
    }
}
