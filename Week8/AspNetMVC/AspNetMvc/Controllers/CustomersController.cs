using Microsoft.AspNetCore.Mvc;
using AspNetMvc.Models;

namespace AspNeteMvc.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Lumi",
                LastName = "Parlayan",
                Email = "lumi.parlayan@gmail.com"
            };

            var viewModel = new CustomerViewModel
            {
                Customer = customer,
                WelcomeMessage = "Welcome to our customer portal!"
            };

            return View(viewModel);
        }
    }
}
