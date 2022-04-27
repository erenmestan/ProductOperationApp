using ProductOperation.Core.Models;
using ProductOperation.Core.Repositories;
using ProductOperation.Repository;

namespace ProductOperation.Service.Repositories
{
    public class ProductionOperationRepository : Repository<ProductionOperation>, IProductionOperationRepository
    {
        public ProductionOperationRepository(AppDbContext context) : base(context)
        {
        }

    }
}
