using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class LoanResultViewModel
    {
        public double Amount { get; set; }
        public string Name { get; set; }
        public double InterestRate { get; set; }
        public int Month { get; set; }
        public double Total { get; set; }
    }
}
