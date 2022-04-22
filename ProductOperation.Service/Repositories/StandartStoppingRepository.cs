using ProductOperation.Core.Models;
using ProductOperation.Core.Repositories;
using ProductOperation.Core.Services;
using ProductOperation.Core.UnitOfWorks;
using ProductOperation.Repository;
using ProductOperation.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOperation.Service.Repositories
{
    public class StandartStoppingRepository : Repository<StandartStopping>, IStandartStoppingRepository
    {
        public StandartStoppingRepository(AppDbContext context) : base(context)
        {
        }
    }
}
