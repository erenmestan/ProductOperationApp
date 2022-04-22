using ProductOperation.Core.Models;
using ProductOperation.Core.Repositories;
using ProductOperation.Core.Services;
using ProductOperation.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOperation.Service.Services
{
    public class StandartStoppingService : Service<StandartStopping>, IStandartStoppingService
    {
        public StandartStoppingService(IRepository<StandartStopping> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
