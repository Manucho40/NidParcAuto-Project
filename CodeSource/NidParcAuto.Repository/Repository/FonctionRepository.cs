using NidParcAuto.API.Models;
using NidParcAuto.Contract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NidParcAuto.Repository.Repository
{
    internal class FonctionRepository: RepositoryBase<Fonction>, IFonctionRepository
    {
        public FonctionRepository(DbNidParcAutoContext repositoryContext) : base(repositoryContext) { }
    }
}
