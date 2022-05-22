using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorLoan.Controllers
{
    public class LoanCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
