using NidParcAuto.API.Models;
using NidParcAuto.Contract.Interfaces;
using NidParcAuto.Repository.Interfaces;
using NidParcAuto.Repository.Repository;

namespace NidParcAuto.API.Services
{
    public class FonctionServices
    {
        private readonly IFonctionRepository _fonctionRepository;
        public FonctionServices(IFonctionRepository fonctionRepository) { _fonctionRepository = fonctionRepository; }

        //public async Task<Fonction> RegisterAdd(Fonction fonction)
        //{
        //    var value = new Fonction
        //    {
        //        LibFonction = fonction.LibFonction,

        //    };

        //    return await _communeRepository.RegisterAdd(value);
        //}
    }
}
