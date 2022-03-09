using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.Models.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC.Controllers
{
    public class FamilleController : Controller
    {
        //Injction du repository
        public IRepository<Famille> Repository { get; }

        public FamilleController(IRepository<Famille> repository)
        {
            Repository = repository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            
            IList<Famille> familles = Repository.Lister();

            return View(familles);
        }

        public IActionResult Details(int id)
        {
            Famille famille = Repository.ListerSelonId(id);
            return View(famille);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Famille famille)
        {
            try
            {
                Repository.Ajouter(famille);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }
        }

        public IActionResult Edit( int id)
        {       
            var family = Repository.ListerSelonId(id);
            return View(family);
        }
        [HttpPost]
        public IActionResult Edit(int id, Famille famille)
        {
            try 
            {
                Repository.Modifier(id, famille);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            var famille = Repository.ListerSelonId(id);
            return View(famille);
        }
        [HttpPost]
        public IActionResult Delete(int id, Famille famille)
        {
            try
            {
                Repository.Supprimer(id);
                return RedirectToAction(nameof(Index));
            }
            catch (System.Exception)
            {
              return View();
            }
            
        }
    }
}
