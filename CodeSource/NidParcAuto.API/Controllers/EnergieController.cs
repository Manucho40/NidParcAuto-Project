using Microsoft.AspNetCore.Mvc;
using NidParcAuto.API.Model;
using NidParcAuto.Contract;
using System.Threading.Tasks;

namespace NidParcAuto.API.Controllers
{
    [ApiController]
    [Route("/api/")]
    public class EnergieController : ControllerBase
    {
        private readonly IEnergieRepository _energieRepository;

        public EnergieController(IEnergieRepository energieRepository)
        {
            _energieRepository = energieRepository;
        }

        // GET: api/energies
        [HttpGet("energies")]
        public async Task<ActionResult<IEnumerable<Energie>>> GetEnergies()
        {
            var energies = await _energieRepository.GetEnergies();

            if (energies == null)
            {
                return NotFound();
            }

            return energies.ToList();
        }

        // POST: api/energie
        //[HttpPost]
        //public async Task<ActionResult<Energie>> AddEnergie(Energie energie)
        //{
        //    await _energieRepository.AddEnergie(energie);

        //    return CreatedAtAction(nameof(GetEnergieById), new { id = energie.IdEnergie }, energie);
        //}

        // POST: api/energie/5
        //[HttpPost("{id}")]
        //public async Task<ActionResult<Energie>> GetEnergieById(int id)
        //{
        //    Energie energie = await _energieRepository.GetEnergieById(id);

        //    if (energie == null)
        //    {
        //        return NotFound();
        //    }

        //    return energie;
        //}


        // PUT: api/energie/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateEnergie(int id, Energie energie)
        //{
        //    if (id != energie.IdEnergie)
        //    {
        //        return BadRequest();
        //    }

        //    await _energieRepository.UpdateEnergie(energie);

        //    return NoContent();
        //}

        // DELETE: api/energie/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteEnergie(int id)
        //{
        //    Energie energie = await _energieRepository.GetEnergieById(id);

        //    if (energie == null)
        //    {
        //        return NotFound();
        //    }

        //    await _energieRepository.DeleteEnergie(id);

        //    return NoContent();
        //}
    }
}
