using NidParcAuto.API.Models;
using NidParcAuto.Contract;

namespace NidParcAuto.API.Services
{
    public class CommuneServices: IRepositoryBase<Commune> 
    {
       private readonly IRepositoryBase<Commune> _repositoryBase;

       public CommuneServices(IRepositoryBase<Commune> repositoryBase) { _repositoryBase = repositoryBase; }


        public Task<IEnumerable<Commune>> FindAll()
        {
            return _repositoryBase.FindAll();
        }
    }
}
