using NidParcAuto.API.Models;
using NidParcAuto.Contract.Interfaces;

namespace NidParcAuto.API.Services
{
    public class EnergieServices
    {
        private readonly IEnergieRepository _energieRepository;

        public EnergieServices(IEnergieRepository energieRepository)
        {
            _energieRepository = energieRepository;
        }

        public async Task<IEnumerable<Energie>> FindAll()
        {
            return await _energieRepository.FindAll();
        }
        
    }
}
