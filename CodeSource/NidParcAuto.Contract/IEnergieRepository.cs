using NidParcAuto.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NidParcAuto.Contract
{
    public interface IEnergieRepository
    {
        //Task<Energie> GetEnergieById(int id);
        Task<IEnumerable<Energie>> GetEnergies();
        //Task AddEnergie(Energie energie);
        //Task UpdateEnergie(Energie energie);
        //Task DeleteEnergie(int id);
    }
}
