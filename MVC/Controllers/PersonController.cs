using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Data.Context;
using MVC.Models;
using MVC.Repository;

namespace MVC.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonRepository personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public IActionResult Index()
        {
            List<Person> people = this.personRepository.FindAll();
            return View(people);
        }

        [HttpGet("/create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/create")]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                this.personRepository.Create(person);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, $"Modelo Invalido");
            return View(person);
        }

        [HttpGet("/edit")]
        public IActionResult Edit(long id)
        {
            var person = this.personRepository.FindById(id);
            return View(person);
        }

        [HttpPost("/edit")]
        public IActionResult Edit(Person person)
        {
            if (ModelState.IsValid)
            {
                this.personRepository.Update(person);
                return RedirectToAction("Index");
            }
            return View(person);
        }

        [HttpGet("/delete")]
        public IActionResult Delete(long id)
        {
            var person = this.personRepository.FindById(id);
            this.personRepository.Delete(id);
            return View(person);
        }

        [HttpPost("/delete")]
        public IActionResult Delete(Person person)
        {
            this.personRepository.Delete(person.Id);
            return RedirectToAction("Index");
        }

    }
}