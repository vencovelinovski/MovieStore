using MovieStore.Data;
using MovieStore.Entities;
using MovieStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Repository
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly DataContext _context;
        public void AddDirector(Director director)
        {
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public void DeleteDirector(int directorId)
        {
            Director director = GetDirectorById(directorId);
            _context.Directors.Remove(director);
            _context.SaveChanges();
        }

        public void EditDirector(Director director)
        {
            _context.Directors.Update(director);
            _context.SaveChanges();
        }

        public Director GetDirectorById(int id)
        {
            var result = _context.Directors.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<Director> GetAllDirectors()
        {
            var result = _context.Directors.AsEnumerable();
            return result;
        }
    }
}
