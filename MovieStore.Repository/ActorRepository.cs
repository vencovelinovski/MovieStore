using MovieStore.Data;
using MovieStore.Entities;
using MovieStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Repository
{
    public class ActorRepository : IActorRepository
    {
        private readonly DataContext _context;
        public void AddActor(Actor actor)
        {
            _context.Add(actor);
            _context.SaveChanges();
        }

        public void DeleteActor(int actorId)
        {
            Actor actor= GetActorById(actorId);
            _context.Remove(actor);
            _context.SaveChanges();
        }

        public void EditActor(Actor actor)
        {
            _context.Update(actor);
            _context.SaveChanges();
        }

        public Actor GetActorById(int id)
        {
            var result = _context.Actors.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IEnumerable<Actor> GetAllActors()
        {
            var result = _context.Actors.AsEnumerable();
            return result;
        }
    }
}
