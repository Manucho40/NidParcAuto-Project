using Microsoft.AspNetCore.Mvc;
using NidParcAuto.API.Models;
using NidParcAuto.Contract;
using NidParcAuto.Repository.Interfaces;

namespace NidParcAuto.API.Services
{
    public class CommuneServices
    {
       private readonly ICommuneRepository _communeRepository;

       public CommuneServices(ICommuneRepository communeRepository) { _communeRepository = communeRepository; }


        public async Task<IEnumerable<Commune>> FindAll()
        {
            return await _communeRepository.FindAll();
        }

        public async Task<Commune> RegisterAdd(Commune commune)
        {
            var value = new Commune
            {
                LibCommune = commune.LibCommune,
                IdUser = commune.IdUser,
                DateCreation = commune.DateCreation,
                ModifieLe = commune.ModifieLe,
                ModifiePar = commune.ModifiePar,
                StateCode = commune.StateCode,
                StatusCode = commune.StatusCode
            };

            return await _communeRepository.RegisterAdd(value);
        }
    }

}
