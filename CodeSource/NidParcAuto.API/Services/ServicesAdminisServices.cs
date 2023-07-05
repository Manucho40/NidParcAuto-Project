using Newtonsoft.Json.Linq;
using NidParcAuto.API.Models;
using NidParcAuto.Contract.Interfaces;

namespace NidParcAuto.API.Services
{
    public class ServicesAdminisServices
    {
        private readonly IServicesAdminisRepository _servicesAdminisRepository;
        public ServicesAdminisServices(IServicesAdminisRepository servicesAdminisRepository) { _servicesAdminisRepository = servicesAdminisRepository; }
        public async Task<IEnumerable<Service>> FindAll()
        {
            return await _servicesAdminisRepository.FindAll();
        }
        public async Task<Service> RegisterAdd(Service service)
        {
            var newService = new Service
            {
                LibService = service.LibService,
                IdUser = service.IdUser,
                DateCreation = service.DateCreation,
                ModifieLe = service.ModifieLe,
                ModifiePar = service.ModifiePar,
                StateCode = service.StateCode, 
                StatusCode = service.StatusCode,
            };

                return await _servicesAdminisRepository.RegisterAdd(newService);
        }
    }
}
