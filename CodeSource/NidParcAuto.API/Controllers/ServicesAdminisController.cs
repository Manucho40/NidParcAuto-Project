using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NidParcAuto.API.Models;
using NidParcAuto.Contract.Interfaces;
using NidParcAuto.Repository.Interfaces;
using NidParcAuto.API.Models;
namespace NidParcAuto.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ServicesAdminisController : ControllerBase
    {
        private readonly IServicesAdminisRepository _repositoryBase;
        public ServicesAdminisController(IServicesAdminisRepository repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        [HttpGet]
        [Route("services")]
        public async Task<ActionResult<IEnumerable<Service>>> FindAll()
        {
            var services = await _repositoryBase.FindAll();
            return Ok(services);
        }
        // /api/registerServices
        [HttpPost("services-register")]
        public async Task<ActionResult> RegisterAddServices(Service service)
        {

            var result = await _repositoryBase.RegisterAdd(service);
            return Ok(result);
        }

    }
}
