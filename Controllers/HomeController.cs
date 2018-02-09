using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
using System.Collections.Generic;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet("/Form")]
        public ActionResult GetForm()
        {
            List<Address> allAddress = Address.GetAll();
            return View("Form", allAddress);
        }
        [HttpPost("/Form")]
        public ActionResult Form()
        {
            string nameIn = Request.Form["name"];
            string phoneNumberIn = Request.Form["phonenumber"];
            string addressIn = Request.Form["address"];
            Address New = new Address(nameIn, phoneNumberIn, addressIn);
            List<Address> allAddress = Address.GetAll();
            return View(allAddress);
        }
    }
}
