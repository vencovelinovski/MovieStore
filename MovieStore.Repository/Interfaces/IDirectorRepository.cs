using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Repository.Interfaces
{
    public interface IDirectorRepository
    {
        void AddDirector(Director director);

        void EditDirector(Director director);

        void DeleteDirector(int directorId);

        Director GetDirectorById(int id);

        IEnumerable<Director> GetAllDirectors();
    }
}

