using NidParcAuto.API.Models;
using NidParcAuto.Contract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NidParcAuto.Repository.Repository
{
    public class ServicesAdminisRepository: RepositoryBase<Service>, IServicesAdminisRepository
    {
        public ServicesAdminisRepository(DbNidParcAutoContext repositoryContext) : base(repositoryContext) { }
    }
}
