using ProductOperation.Core.DTOs;
using ProductOperation.Core.Models;

namespace ProductOperation.Core.Services
{
    public interface IProductionOperationService : IService<ProductionOperation>
    {
        List<ProductionOperationDTO> Reorganize(DateTime dateTime);

    }
}
