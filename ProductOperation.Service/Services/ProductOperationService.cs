using AutoMapper;
using ProductOperation.Core.DTOs;
using ProductOperation.Core.Models;
using ProductOperation.Core.UnitOfWorks;
using ProductOperation.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOperation.Service.Services
{
    public class ProductOperationService : Service<ProductionOperation>
    {
        private readonly IMapper _mapper;
        Repository<StandartStopping> _standartRepo;
        public ProductOperationService(Repository<ProductionOperation> repository, IMapper mapper,IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
            _mapper=mapper;
        }

        public List<ProductionOperationDTO> getAllTruely()
        {
            List<ProductionOperationDTO> productionOperationDTOs = new List<ProductionOperationDTO>();
            List<ProductionOperation> products = _repository.GetAll().OrderBy(products=>products.StartDateTime).ToList();
            List<StandartStopping> standarts = _standartRepo.GetAll().OrderBy(standarts=> standarts.StartDateTime).ToList();
            List<TimeOnly> standartStarts = _standartRepo.GetAll().Select(standart => new TimeOnly(standart.StartDateTime.Hour, standart.StartDateTime.Minute)).ToList();

            foreach (var product in products) {
                 foreach(var start in standartStarts)
                {
                    if( new TimeOnly(product.StartDateTime.Hour,product.StartDateTime.Minute)>= start && start>= new TimeOnly(product.EndDateTime.Hour, product.EndDateTime.Minute))
                    {

                    }
                } 
            }
            
            return new List<ProductionOperationDTO>();
        }
    }
}
