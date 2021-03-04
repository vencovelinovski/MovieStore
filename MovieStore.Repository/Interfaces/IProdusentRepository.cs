using MovieStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Repository.Interfaces
{
   public interface IProdusentRepository
    {

        void AddProdusent(Produsent produsent);
        void EditProdusent(Produsent produsent);
        void DeleteProdusent(int produsentId);

        Produsent GetProdusentById(int id);

        IEnumerable<Produsent> GetAllProdusents();
    }
}
