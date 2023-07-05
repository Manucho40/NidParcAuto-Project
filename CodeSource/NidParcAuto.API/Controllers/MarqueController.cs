using Microsoft.AspNetCore.Mvc;
using NidParcAuto.API.Models;
using NidParcAuto.Contract.Interfaces;
using NidParcAuto.Repository.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NidParcAuto.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class MarqueController : ControllerBase
    {
        private readonly IMarqueRepository _repositoryBase;



        public MarqueController(IMarqueRepository repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        // GET: api/<MarqueController>
        [HttpGet]
        [Route("marques")]
        public async Task<ActionResult<IEnumerable<Marque>>> FindAll()
        {
            var marques = await _repositoryBase.FindAll();
            return Ok(marques);
        }

    }
}
