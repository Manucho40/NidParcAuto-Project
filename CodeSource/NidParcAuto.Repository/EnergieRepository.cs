using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NidParcAuto.API.Model;
using NidParcAuto.Contract;

namespace NidParcAuto.Repository
{
    public class EnergieRepository: IEnergieRepository
    {
        private readonly NidParcAutoContext _dbContext;

        public EnergieRepository(NidParcAutoContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public async Task<Energie> GetEnergieById(int id)
        //{
        //    return await _dbContext.Energies.FindAsync(id);
        //}

        public async Task<IEnumerable<Energie>> GetEnergies()
        {
            Console.WriteLine("Hello GetEnergies");
            return await _dbContext.Energies.ToListAsync();
        }

        //public async Task AddEnergie(Energie energie)
        //{
        //    await _dbContext.Energies.AddAsync(energie);
        //    await _dbContext.SaveChangesAsync();
        //}

        //public async Task UpdateEnergie(Energie energie)
        //{
        //    _dbContext.Entry(energie).State = EntityState.Modified;
        //    await _dbContext.SaveChangesAsync();
        //}

        //public async Task DeleteEnergie(int id)
        //{
        //    var user = await _dbContext.Energies.FindAsync(id);
        //    if (user != null)
        //    {
        //        _dbContext.Energies.Remove(user);
        //        await _dbContext.SaveChangesAsync();
        //    }
        //}
    }
}

