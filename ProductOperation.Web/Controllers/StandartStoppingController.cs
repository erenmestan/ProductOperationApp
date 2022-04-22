using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductOperation.Core.DTOs;
using ProductOperation.Core.Models;
using ProductOperation.Core.Services;

namespace ProductOperation.Web.Controllers
{
    public class StandartStoppingController : Controller
    {
        private readonly IStandartStoppingService _service;
        private readonly IMapper _mapper;

        public StandartStoppingController(IStandartStoppingService service, IMapper mapper)
        {
            _service=service;
            _mapper=mapper;
        }

        public IActionResult Index()
        {
            List<StandartStopping> ss = _service.GetAll().ToList();
            List<StandartStoppingDto> standartStoppingDtos = _mapper.Map<List<StandartStoppingDto>>(ss);
            foreach (StandartStoppingDto standartStoppingDto in standartStoppingDtos)
            {
                TimeSpan dateTime = standartStoppingDto.EndDateTime-(standartStoppingDto.StartDateTime);
                standartStoppingDto.TotalTime = dateTime;
            }
            return View(standartStoppingDtos);
        }
        public IActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Save(StandartStoppingDto standartStoppingDto)
        {
            if (ModelState.IsValid)
            {
                StandartStopping standart = _mapper.Map<StandartStopping>(standartStoppingDto);
                await _service.AddAsync(standart);

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
