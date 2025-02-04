using Microsoft.AspNetCore.Mvc;
using BasicMVCApp.Models;

namespace BasicMVCApp.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customerOne = new Customer
            {
                Id = 1,
                FirstName = "Lumi",
                LastName = "Parlayan",
                Email = "lumi.parlayan@example.com"
            };

            var customerOneOrders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Turnuva Satranç Takımı", Price = 750.00m, Quantity = 1 },
                new Order { Id = 2, ProductName = "Satranç Açılış Kitabı", Price = 220.00m, Quantity = 1 },
                new Order { Id = 3, ProductName = "Dijital Satranç Saati", Price = 2350.00m, Quantity = 1 }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customerOne,
                Orders = customerOneOrders
            };

            return View(viewModel);
        }
    }
}