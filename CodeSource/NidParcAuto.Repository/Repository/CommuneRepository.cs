using NidParcAuto.API.Models;
using NidParcAuto.Contract;
using NidParcAuto.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NidParcAuto.Repository.Repository
{
    public class CommuneRepository: RepositoryBase<Commune>, ICommuneRepository
    {
        public CommuneRepository(DbNidParcAutoContext repositoryContext) : base(repositoryContext) { }  
    }
}
