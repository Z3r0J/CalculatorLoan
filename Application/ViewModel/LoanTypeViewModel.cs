using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class LoanTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double InterestRate { get; set; }

        public List<LoanTypeViewModel> LoanTypes { get; set; } = new();
        public List<LoanTypeViewModel> GetLoanType()
        {
            LoanTypes.Clear();

            LoanTypes.Add(new() { 
            Id=1,
            Name="Personal",
            InterestRate=22
            });

            LoanTypes.Add(new()
            {
                Id = 2,
                Name = "Car",
                InterestRate = 12
            });

            LoanTypes.Add(new()
            {
                Id = 3,
                Name = "Mortgage",
                InterestRate = 8
            });

            return LoanTypes;
        }
    }

}
