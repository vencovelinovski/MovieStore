using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services.Interfaces
{
    public interface IProdusentService
    {
        void Add(Produsent produsent);
        void Edit(Produsent produsent);
        void Delete(int produsentId);

        Produsent GetProdusentById(int id);

        IEnumerable<Produsent> GetAllProdusents();
    }
}
