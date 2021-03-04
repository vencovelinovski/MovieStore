using MovieStore.Data;
using MovieStore.Entities;
using MovieStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStore.Repository
{
    public class ProdusentRepository : IProdusentRepository
    {

        private readonly DataContext _context;
        public void AddProdusent(Produsent produsent)
        {
            _context.Produsers.Add(produsent);
            _context.SaveChanges();
        }

        public void DeleteProdusent(int produsentId)
        {
            Produsent produsent = GetProdusentById(produsentId);
            _context.Produsers.Remove(produsent);
            _context.SaveChanges();
        }

        public void EditProdusent(Produsent produsent)
        {
            _context.Produsers.Update(produsent);
            _context.SaveChanges();
        }

        public IEnumerable<Produsent> GetAllProdusents()
        {
            var result = _context.Produsers.AsEnumerable();
            return result;
        }

        public Produsent GetProdusentById(int id)
        {
            var result = _context.Produsers.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
