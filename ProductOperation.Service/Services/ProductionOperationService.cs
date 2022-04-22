using AutoMapper;
using ProductOperation.Core.DTOs;
using ProductOperation.Core.Models;
using ProductOperation.Core.Repositories;
using ProductOperation.Core.Services;
using ProductOperation.Core.UnitOfWorks;
using ProductOperation.Service.Repositories;

namespace ProductOperation.Service.Services
{
    public class ProductionOperationService : Service<ProductionOperation>, IProductionOperationService
    {
        private readonly IStandartStoppingRepository _standardRepo;
        private readonly IMapper _mapper;

        public ProductionOperationService(IRepository<ProductionOperation> repository, IUnitOfWork unitOfWork, IStandartStoppingRepository standardRepo,IMapper mapper) : base(repository, unitOfWork)
        {
            _standardRepo = standardRepo;
            _mapper = mapper;
        }

        public List<ProductionOperationDTO> Reorganize(DateTime dateTime)
        {
            List<ProductionOperationDTO> productionOperationDTOs = new List<ProductionOperationDTO>();

            List<ProductionOperationDTO> products = _mapper.Map<List<ProductionOperationDTO>>(_repository.GetAll().Where(p=>p.StartDateTime.Date == dateTime.Date).OrderBy(products => products.StartDateTime));
            List<StandartStoppingDto> standarts = _mapper.Map<List<StandartStoppingDto>>(_standardRepo.GetAll().OrderBy(standarts => standarts.StartDateTime));
           

            foreach (var product in products)
            {
                if (!product.Status)
                {
                    product.TotalTime =product.EndDateTime-product.StartDateTime;

                    productionOperationDTOs.Add(product);
                }
                else {
                    int productionSize = productionOperationDTOs.Count;
                    foreach (var standart in standarts)
                    {
                        if (product.StartDateTime.TimeOfDay < standart.StartTime && product.EndDateTime.TimeOfDay > standart.StartTime)
                        {
                            ProductionOperationDTO productionOperationDTO = new ProductionOperationDTO();
                            productionOperationDTO.No = product.No;
                            productionOperationDTO.StartDateTime = product.StartDateTime;
                            productionOperationDTO.EndDateTime = product.StartDateTime.Date +standart.StartTime;
                            productionOperationDTO.Status =product.Status;
                            productionOperationDTO.StoppingReason = product.StoppingReason;
                            productionOperationDTO.TotalTime = productionOperationDTO.EndDateTime-productionOperationDTO.StartDateTime;

                            ProductionOperationDTO productionOperationDTO2 = new ProductionOperationDTO();
                            productionOperationDTO2.No = product.No;
                            productionOperationDTO2.StartDateTime = product.StartDateTime.Date + standart.StartTime;
                            productionOperationDTO2.EndDateTime = product.StartDateTime.Date + standart.EndTime;
                            productionOperationDTO2.Status = false;
                            productionOperationDTO2.StoppingReason = standart.StoppingReason;
                            productionOperationDTO2.TotalTime = productionOperationDTO2.EndDateTime-productionOperationDTO2.StartDateTime;

                            ProductionOperationDTO productionOperationDTO3 = new ProductionOperationDTO();
                            productionOperationDTO3.No = product.No;
                            productionOperationDTO3.StartDateTime = product.StartDateTime.Date + standart.EndTime;
                            productionOperationDTO3.EndDateTime = product.EndDateTime;
                            productionOperationDTO3.Status =product.Status;
                            productionOperationDTO3.StoppingReason = product.StoppingReason;
                            productionOperationDTO3.TotalTime = productionOperationDTO3.EndDateTime-productionOperationDTO3.StartDateTime;

                            productionOperationDTOs.Add(productionOperationDTO);
                            productionOperationDTOs.Add(productionOperationDTO2);
                            productionOperationDTOs.Add(productionOperationDTO3);
                        }
                        else if (product.StartDateTime.TimeOfDay == standart.StartTime && product.EndDateTime.TimeOfDay > standart.StartTime)
                        {
                            ProductionOperationDTO productionOperationDTO = new ProductionOperationDTO();
                            productionOperationDTO.No = product.No;
                            productionOperationDTO.StartDateTime = product.StartDateTime.Date + standart.StartTime;
                            productionOperationDTO.EndDateTime = product.StartDateTime.Date + standart.EndTime;
                            productionOperationDTO.Status =false;
                            productionOperationDTO.StoppingReason = standart.StoppingReason;
                            productionOperationDTO.TotalTime = productionOperationDTO.EndDateTime-productionOperationDTO.StartDateTime;

                            ProductionOperationDTO productionOperationDTO2 = new ProductionOperationDTO();
                            productionOperationDTO2.No = product.No;
                            productionOperationDTO2.StartDateTime = product.StartDateTime.Date + standart.EndTime;
                            productionOperationDTO2.EndDateTime = product.EndDateTime;
                            productionOperationDTO2.Status = product.Status;
                            productionOperationDTO2.StoppingReason = product.StoppingReason;
                            productionOperationDTO2.TotalTime = productionOperationDTO2.EndDateTime-productionOperationDTO2.StartDateTime;

                            productionOperationDTOs.Add(productionOperationDTO);
                            productionOperationDTOs.Add(productionOperationDTO2);
                        }
                    }
                    if(productionSize == productionOperationDTOs.Count)
                    {
                        productionOperationDTOs.Add(product);
                    }
                }
            }

            return productionOperationDTOs;
        }
    }
}
