using CustomerApplication.Models;
using CustomerApplication.Repository;
using CustomerApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomerApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomer customer;

        public HomeController(ICustomer customer)
        {
            this.customer = customer;
        }

        public IActionResult Index()
        {
            try
            {
                var Getcustresult = customer.GetCustomer().Result;
                ViewBag.Customer = Getcustresult;
                return View();
            }
            catch (Exception)
            {
                throw;
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer custmodel)
        {
            if (ModelState.IsValid)
            {
                customer.CreateCustomer(custmodel);
            }
            ViewBag.message = "Data Saved Successfully..";
            
            ModelState.Clear();
            //return View();
            return Redirect("/");
        }

        public IActionResult Edit(int id)
        {
            Customer custmodel = new Customer();
            // {
            custmodel = customer.GetCustomerById(id);
           // };
            return View(custmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CustomerViewmodel viewCustomer)
        {
            Customer custmodel = new Customer()
            {
                id = viewCustomer.id,
                FirstName = viewCustomer.FirstName,
                LastName = viewCustomer.LastName,
                Mobile = viewCustomer.Mobile,
                Email = viewCustomer.Email,
                Gender = viewCustomer.Gender,

                Address1 = viewCustomer.Address1,
                Street1 = viewCustomer.Street1,
                City1 = viewCustomer.City1,
                State1 = viewCustomer.State1,
                Pincode1 = viewCustomer.Pincode1,
                Flag1 = viewCustomer.Flag1,

                Address2 = viewCustomer.Address2,
                Street2 = viewCustomer.Street2,
                City2 = viewCustomer.City2,
                State2 = viewCustomer.State2,
                Pincode2 = viewCustomer.Pincode2,
                Flag2 = viewCustomer.Flag2,
                Status = viewCustomer.Status
            };
            var result = customer.UpdateCustomer(custmodel);
            ModelState.Clear();
            return Redirect("/");
        }


        public IActionResult Delete(int id)
        {
            Customer custview = new Customer();
            //{
            custview = customer.GetCustomerById(id);
            //};
            var result = customer.DeleteCustomer(custview.id);
            return Redirect("/");


            //Customer custmodel = new Customer();
            //// {
            //viewCustomer = customer.GetCustomerById(id);
            //// };
            //return View(custmodel);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Delete(CustomerViewmodel viewmodel)
        {
            var result = customer.DeleteCustomer(viewmodel.id);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //public IActionResult MyAction()
        //{
        //    CustomerViewmodel viewModel = CustomerViewmodel(); // Retrieve or create a CustomerViewModel object
        //    Customer customer = MapViewModelToCustomer(viewModel); // Map the ViewModel to a Customer object
        //    return View(customer);
        //}
    }
}