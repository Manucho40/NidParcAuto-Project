using NidParcAuto.API.Models;
using NidParcAuto.Contract.Interfaces;

namespace NidParcAuto.API.Services
{
    public class MarqueServices
    {
        private readonly IMarqueRepository _marqueRepositiory;

        public MarqueServices(IMarqueRepository marqueRepository) { _marqueRepositiory = marqueRepository; }

        public async Task<IEnumerable<Marque>> FindAll()
        {
            return await _marqueRepositiory.FindAll();
        }
    }
}
