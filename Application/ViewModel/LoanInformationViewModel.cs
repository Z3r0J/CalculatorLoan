using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class LoanInformationViewModel
    {
        public double Amount { get; set; }
        public int Type { get; set; }
        public double RateInterest { get; set; }
        public int MonthlyPay { get; set; }
    }
}
