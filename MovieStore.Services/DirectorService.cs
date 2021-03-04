using MovieStore.Entities;
using MovieStore.Repository.Interfaces;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
   public class DirectorService:IDirectorService
    {

        private readonly IDirectorRepository _directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        public void Add(Director director)
        {
            _directorRepository.AddDirector(director);
        }

        public void Delete(int directorId)
        {
            _directorRepository.DeleteDirector(directorId);
        }

        public void Edit(Director director)
        {
            _directorRepository.EditDirector(director);
        }

        public IEnumerable<Director> GetAllDirectors()
        {
            var result = _directorRepository.GetAllDirectors();
            return result;
        }

        public Director GetDirectorById(int id)
        {
            var result=_directorRepository.GetDirectorById(id);
            return result;
        }
    }
}
