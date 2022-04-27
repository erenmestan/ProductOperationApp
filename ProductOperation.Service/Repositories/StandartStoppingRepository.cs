using ProductOperation.Core.Models;
using ProductOperation.Core.Repositories;
using ProductOperation.Repository;

namespace ProductOperation.Service.Repositories
{
    public class StandartStoppingRepository : Repository<StandartStopping>, IStandartStoppingRepository
    {
        public StandartStoppingRepository(AppDbContext context) : base(context)
        {
        }
    }
}
