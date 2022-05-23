using Application.Services;
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
        private readonly LoanServices services;
        public LoanCalculatorController()
        {
            loanType = new();

            loanInformation = new();
            services = new();
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
            if (vm.Type < 0 || vm.MonthlyPay<0)
            {
                ViewBag.ErrorMessage = "Complete the 2 Select";
                return View("Index");
            }
            else
            {
                var response = services.GetLoanResult(vm);
                return View(response);
            }
        }
    }
}
