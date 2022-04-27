using ProductOperation.Core.Models;
using ProductOperation.Core.Repositories;
using ProductOperation.Core.Services;
using ProductOperation.Core.UnitOfWorks;

namespace ProductOperation.Service.Services
{
    public class StandartStoppingService : Service<StandartStopping>, IStandartStoppingService
    {
        public StandartStoppingService(IRepository<StandartStopping> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
