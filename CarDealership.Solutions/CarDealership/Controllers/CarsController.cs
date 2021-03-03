using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet("/cars")]
        public ActionResult Index()
        {
            List<Car> allCars = Car.GetAll();
            return View(allCars);
        }

        [HttpGet("/cars/newcar")]
        public ActionResult CarForm()
        {
            return View();
        }

        [HttpPost("/cars")]
        public ActionResult Create(string make, string model, string type, int price, string year, int mpg, string condition)
        {
            Car myCar = new Car();
            myCar.make = make;
            myCar.model = model;
            myCar.type = type;
            myCar.price = price;
            myCar.year = year;
            myCar.mpg = mpg;
            myCar.condition = condition;
            return RedirectToAction("Index");
        }
    }
}

//Make
//Model
//Type
//Price
//Year
//MPG
//Condition