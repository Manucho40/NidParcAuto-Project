using NidParcAuto.API.Models;
using NidParcAuto.Contract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NidParcAuto.Repository.Repository
{
    public class MarqueRepository: RepositoryBase<Marque>, IMarqueRepository
    {
        public MarqueRepository(DbNidParcAutoContext repositoryContext) : base(repositoryContext) { }
    }
}
