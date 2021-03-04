using MovieStore.Entities;
using MovieStore.Repository.Interfaces;
using MovieStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Services
{
    public class ProdusentService:IProdusentService
    {
        private readonly IProdusentRepository _produsentRepository;

        public ProdusentService(IProdusentRepository produsentRepository)
        {
            _produsentRepository = produsentRepository;
        }

        public void Add(Produsent produsent)
        {
            _produsentRepository.AddProdusent(produsent);
        }

        public void Delete(int produsentId)
        {
            _produsentRepository.DeleteProdusent(produsentId);
        }

        public void Edit(Produsent produsent)
        {
            _produsentRepository.EditProdusent(produsent);
        }

        public IEnumerable<Produsent> GetAllProdusents()
        {
            var result = _produsentRepository.GetAllProdusents();
            return result;
        }

        public Produsent GetProdusentById(int id)
        {
            var result = _produsentRepository.GetProdusentById(id);
            return result;
        }
    }
}
