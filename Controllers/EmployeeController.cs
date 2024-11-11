using Microsoft.AspNetCore.Mvc;
using EmployeeRegistrationApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeRegistrationApp.Controllers
{
    public class EmployeeController : Controller
    {
 
        public IActionResult Register()
        {   
            var employee = new Employee();
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Employee employee)
        {
            if (ModelState.IsValid) 
            {
                //Save employee data to database
                return View("Acknowledgement", employee);
            }
            return View(employee); //Return the model in case of errors or Data Validation fails
        }          
    }
}