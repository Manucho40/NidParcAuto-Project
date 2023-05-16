using NidParcAuto.API.Model;
using NidParcAuto.Contract;

namespace NidParcAuto.API.Services
{
    public class EnergieService: IEnergieRepository
    {
        private readonly IEnergieRepository _energieRepository;

        public EnergieService(IEnergieRepository energieRepository)
        {
            _energieRepository = energieRepository;
        }

        //public async Task<Energie> GetEnergieById(int id)
        //{
        //    return await _energieRepository.GetEnergieById(id);
        //}

        public async Task<IEnumerable<Energie>> GetEnergies()
        {
            return await _energieRepository.GetEnergies();
        }

        //public async Task AddEnergie(Energie energie)
        //{
        //    await _energieRepository.AddEnergie(energie);
        //}

        //public async Task UpdateEnergie(Energie energie)
        //{
        //    await _energieRepository.UpdateEnergie(energie);
        //}

        //public async Task DeleteEnergie(int id)
        //{
        //    await _energieRepository.DeleteEnergie(id);
        //}
    }
}
