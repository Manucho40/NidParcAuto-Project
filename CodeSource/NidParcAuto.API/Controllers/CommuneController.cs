using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NidParcAuto.API.Extensions;
using NidParcAuto.API.Models;
using NidParcAuto.Contract;
using NidParcAuto.Repository.Interfaces;

namespace NidParcAuto.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CommuneController : ControllerBase
    {
        private readonly ICommuneRepository _repositoryBase;

  

        public CommuneController(ICommuneRepository repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        [HttpGet]
        [Route("communes")]
        public async Task<ActionResult<IEnumerable<Commune>>> FindAll()
        {
            var communes = await _repositoryBase.FindAll();
            return Ok(communes);
        }


        // /api/registerCommune
        [HttpPost("commune-register")]
        public async Task<ActionResult> RegisterAddCommune(Commune commune)
        {
        
            var result = await _repositoryBase.RegisterAdd(commune);
            return Ok(result);
        }
    }
}
