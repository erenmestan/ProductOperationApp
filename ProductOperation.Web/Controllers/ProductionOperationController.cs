using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductOperation.Core.DTOs;
using ProductOperation.Core.Models;
using ProductOperation.Core.Services;
using ProductOperation.Service.Services;

namespace ProductOperation.Web.Controllers
{
    public class ProductionOperationController : Controller
    {
        private readonly IProductionOperationService _service;

        private readonly IMapper _mapper;

        public ProductionOperationController(IProductionOperationService productOperationService, IMapper mapper)
        {
            this._service=productOperationService;
            _mapper=mapper;
        }

        public async Task<IActionResult> Index()
        {
            List<ProductionOperation> pos = _service.GetAll().Where(p => p.StartDateTime.Date == new DateTime(2020,05,23).Date).ToList();
            List<ProductionOperationDTO> productOperationDTOs = _mapper.Map<List<ProductionOperationDTO>>(pos);
            foreach (ProductionOperationDTO productOperationDTO in productOperationDTOs)
            {
                TimeSpan dateTime = productOperationDTO.EndDateTime-(productOperationDTO.StartDateTime);
                productOperationDTO.TotalTime = dateTime;
            }
            return View(productOperationDTOs);
        }
        [HttpPost]
        public IActionResult Index(DateTime dateTime)
        {
            List<ProductionOperation> pos = _service.GetAll().Where(p=>p.StartDateTime.Date == dateTime.Date).ToList();
            List<ProductionOperationDTO> productOperationDTOs = _mapper.Map<List<ProductionOperationDTO>>(pos);
            foreach (ProductionOperationDTO productOperationDTO in productOperationDTOs)
            {
                TimeSpan tdaTime = productOperationDTO.EndDateTime-(productOperationDTO.StartDateTime);
                productOperationDTO.TotalTime = tdaTime;
            }
            return View(productOperationDTOs);
        }
        public IActionResult Save()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductionOperationDTO operationDTO)
        {
            if (ModelState.IsValid)
            {
                ProductionOperation production = _mapper.Map<ProductionOperation>(operationDTO);
                await _service.AddAsync(production);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(int id)
        {
            ProductionOperation productionOperation = await _service.GetByIdAsync(id);
            ProductionOperationDTO productionOperationDTO = _mapper.Map<ProductionOperationDTO>(productionOperation);
            return View(productionOperationDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductionOperationDTO operationDTO)
        {
            if (ModelState.IsValid)
            {

                ProductionOperation productionOperation = _mapper.Map<ProductionOperation>(operationDTO);
                await _service.UpdateAsync(productionOperation);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Remove(int id)
        {
            ProductionOperation productionOperation = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(productionOperation);

            return RedirectToAction(nameof(Index));
        }
    }
}
