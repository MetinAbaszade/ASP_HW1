using HW1.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection;

namespace HW1.Controllers
{
    public class HomeController : Controller
    {

        List<Meal> drinks = new List<Meal>() {
                new Drink(1, "Cola", 2, "500ml"),
                new Drink(2, "Fanta", 2, "500ml"),
                new Drink(3, "Sprite", 2, "500ml"),
                new Drink(4, "Jack Daniel",12, "375ml"),
        };

        List<Meal> hotMeals = new List<Meal>() {
                new HotMeal(1, "Buğlama", 7),
                new HotMeal(2, "Xaş", 6),
                new HotMeal(3, "Plov", 12),
                new HotMeal(4, "Dolma",10),
        };

        List<Meal> fastFoods = new List<Meal>() {
                new FastFood(1, "Burger", 8, "600gr"),
                new FastFood(2, "Free", 3, "400gr"),
                new FastFood(3, "Nugget", 5, "500gr"),
                new FastFood(4, "Pizza", 15, "800gr"),
        };

        public ViewResult Index()
        {
           List<List<Meal>> meals = new List<List<Meal>>()
           {
               drinks, hotMeals, fastFoods
           };
            return View(meals);
        }

        public ViewResult Drink()
        {
            return View(drinks);
        }

        public ViewResult HotMeal()
        {
            return View(hotMeals);
        }

        public ViewResult FastFood()
        {
            return View(fastFoods);
        }

    }
}
