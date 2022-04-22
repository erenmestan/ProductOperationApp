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
            List<ProductionOperation> pos = _service.GetAll().ToList();
            List<ProductionOperationDTO> productOperationDTOs = _mapper.Map<List<ProductionOperationDTO>>(pos);
            foreach (ProductionOperationDTO productOperationDTO in productOperationDTOs)
            {
                TimeSpan dateTime = productOperationDTO.EndDateTime-(productOperationDTO.StartDateTime);
                productOperationDTO.TotalTime = dateTime;
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
        public IActionResult Update()
        {
            return View();
        }
        public ActionResult Remove()
        {
            return View();
        }
    }
}
