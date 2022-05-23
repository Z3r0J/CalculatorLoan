using Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorLoan.Controllers
{
    public class LoanCalculatorController : Controller
    {
        private readonly LoanTypeViewModel loanType;
        private readonly LoanInformationViewModel loanInformation;
        public LoanCalculatorController()
        {
            loanType = new();

            loanInformation = new();
        }
        public IActionResult Index()
        {
            return View(loanInformation);
        }

        [HttpGet]
        public IActionResult GetInterestRate(int id) {

            return Json(loanType.GetLoanType().Where(x => x.Id == id).ToList());
        }

        public IActionResult TotalToPay() {
            return View();
        }

        [HttpPost]
        public IActionResult TotalToPay(LoanInformationViewModel vm) {
            Console.WriteLine(vm.RateInterest);
            return View();
        }
    }
}
