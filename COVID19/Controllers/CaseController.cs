using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COVID19.Data.Entities;
using COVID19.Models;
using COVID19.Services.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace COVID19.Controllers
{
    public class CaseController : Controller
    {
        private readonly ICaseService _caseService;

        public CaseController(ICaseService caseService)
        {
            _caseService = caseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //GET:Case/Add

        public IActionResult Add()
        {
            var Cases = _caseService.GetAllCases();

           CaseViewModel caseViewModel = new CaseViewModel();
         

            return View(caseViewModel);
        }


        [HttpPost]
        public IActionResult Add(CaseViewModel caseViewModel)
        {
            var newcase = new Cases ();

            if (ModelState.IsValid)
            {
               newcase.NameSurname = caseViewModel.NameSurname;
               newcase.Age = caseViewModel.Age;
               newcase.Sex = caseViewModel.Sex;
               newcase.City = caseViewModel.City;
               newcase.FirstSymptoms =  caseViewModel.FirstSymptoms;
               newcase.FirstSyptomsDate = caseViewModel.FirstSyptomsDate;
               newcase.FirstTestDate=caseViewModel.FirstTestDate;
               newcase.ResultFirstTest=caseViewModel.ResultFirstTest;
               newcase.Condition=caseViewModel.Condition;
               newcase.Recover=caseViewModel.Recover;
               newcase.Death=caseViewModel.Death;

                _caseService.Add(newcase);
                return RedirectToAction(nameof(Index));
            }

            return View(newcase);
        }
    }
}