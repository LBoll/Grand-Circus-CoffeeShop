using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ListCustomers()
        {
            // 1. Creating an object for the ORM 
            CoffeeAppDBEnt ORM = new CoffeeAppDBEnt();

            // 2. Load the data from the DbSet into a data structure 
            List<Product> CustomerList = ORM.Products.ToList();

            // 3. Filter the data (Optional)

            ViewBag.CustomerList = CustomerList;

            //ViewBag.CountryList = ORM.Customers.Select(x => x.Country).Distinct().ToList();

            return View("ProductView");
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult SaveUser(User NewUserRecord)
        {
            // 1. validation 

            if (ModelState.IsValid)
            {
                // 2. add the new record to the ORM, save changes to db
                CoffeeAppDBEnt ORM = new CoffeeAppDBEnt();

                ORM.Users.Add(NewUserRecord);
                ORM.SaveChanges();

                // 3. showing the list of all customers
                return RedirectToAction("ListCustomers");

            }
            else
            {    // If validation fails 
                // go back to the form and show the list of errors!
                return View("AddUser");
            }
        }
        /*
        public ActionResult UserLogin(User Login)
        {
            CoffeeAppDBEnt ORM = new CoffeeAppDBEnt();
            if ()

            return RedirectToAction("ListCustomers");
        }
        */
    }
}