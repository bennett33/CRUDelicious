using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        // NOTE DB function
        private CRUDeliciousContext db;
        public HomeController(CRUDeliciousContext context)
        {
            db = context;
        }


        // NOTE Routes
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = db.Dishes.OrderByDescending (d => d.CreatedAt).ToList();
            return View("Index", AllDishes);
        }

        [HttpGet("new")]
        public IActionResult NewDish()
        {
            return View("Newdish");
        }

        [HttpPost("create")]
        public IActionResult Create(Dish createDish)
        {   
            if (ModelState.IsValid)
            {
                db.Add(createDish);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Newdish");
        }

        [HttpGet("{DishId}")]
        public IActionResult ViewDish(int DishId)
        {
            Dish toView = db.Dishes.FirstOrDefault( d => d.DishId == DishId);
            return View("Viewdish", toView);
        }

        [HttpGet("delete/{DishId}")]
        public IActionResult Delete(int DishId)
        {
            Dish toDelete = db.Dishes.FirstOrDefault( d => d.DishId == DishId);
            db.Dishes.Remove(toDelete);
            db.SaveChanges();
            return RedirectToAction("Index", toDelete);
        }

        [HttpGet("edit/{DishId}")]
        public IActionResult Edit(int DishId)
        {
            Dish editDish = db.Dishes.FirstOrDefault( d => d.DishId == DishId);
            return View("Editdish", editDish);
        }

        [HttpPost("update/{selectId}")]
        public IActionResult Update(Dish formDish, int selectId)
        {
            if (ModelState.IsValid == false)
            {
                formDish.DishId = selectId;
                return View("Editdish", formDish);
            }
            Dish updateDish = db.Dishes.FirstOrDefault( d =>d.DishId == selectId);
            updateDish.DishName = formDish.DishName;
            updateDish.ChefName = formDish.ChefName;
            updateDish.Description = formDish.Description;
            updateDish.Calories = formDish.Calories;
            updateDish.Tastiness = formDish.Tastiness;
            updateDish.UpdatedAt = DateTime.Now;
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        // NOTE Pre installed Things
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
