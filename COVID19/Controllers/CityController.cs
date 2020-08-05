using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19.Data.Entities;
using COVID19.Services.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace COVID19.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {

            _cityService = cityService;

        }
        public IActionResult Index()
        {
            var cityList = _cityService.GetAllCities();
            return View(cityList);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]

        public IActionResult Create(Cities cities)
        {
            if (ModelState.IsValid)
            {
                _cityService.Add(cities);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            var city = _cityService.GetCitiesById(id);
            if (city == null)
            {
                return NotFound();
            }
            return View(city);
        }

        [HttpPost]

        public IActionResult Edit(int id, Cities cities)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _cityService.Edit(cities);

                }
                catch (Exception ex)
                {
                    throw;
                }
                RedirectToAction(nameof(Index));
            }
            return View(cities);
        }

        public IActionResult Details(int id)
        {
            var cities = _cityService.GetCitiesById(id);

            if (cities == null)
            {
                return NotFound();
            }

            return View(cities);
        }

        public IActionResult Delete(int id)
        {
            var cities = _cityService.GetCitiesById(id);

            if (cities == null)
            {
                return NotFound();
            }

            return View(cities);
        }


    }
}