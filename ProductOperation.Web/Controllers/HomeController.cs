using Microsoft.AspNetCore.Mvc;
using ProductOperation.Core.DTOs;
using ProductOperation.Core.Services;
using ProductOperation.Web.Models;
using System.Diagnostics;

namespace ProductOperation.Web.Controllers
{
    public class HomeController : Controller
    {
        IProductionOperationService productionService;

        public HomeController(IProductionOperationService productionService)
        {
            this.productionService=productionService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(DateTime dateTime)
        {
            ViewBag.Message = dateTime.ToString("dd/MM/yyyy");
            List<ProductionOperationDTO> products = productionService.Reorganize(dateTime);
            return View(products);
        }
       
    }
}