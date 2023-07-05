using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NidParcAuto.API.Models;
using NidParcAuto.Contract.Interfaces;
using NidParcAuto.Repository.Interfaces;

namespace NidParcAuto.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class EnergieController : ControllerBase
    {
        private readonly IEnergieRepository _repositoryBase;



        public EnergieController(IEnergieRepository repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        [HttpGet]
        [Route("energies")]
        public async Task<ActionResult<IEnumerable<Energie>>> FindAll()
        {
            var energies = await _repositoryBase.FindAll();
            return Ok(energies);
        }
    }
}
