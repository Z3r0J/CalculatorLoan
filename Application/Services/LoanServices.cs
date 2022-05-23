using Application.Enums;
using Application.ViewModel;
using System.Linq;

namespace Application.Services
{
    public class LoanServices
    {
        private LoanTypeViewModel loanType = new();
        private double percent;
        public LoanResultViewModel GetLoanResult(LoanInformationViewModel vm)
        {
            switch (vm.Type)
            {
                case (int)EnumLoanType.LoanType.PERSONAL:
                    percent = (vm.Amount * vm.RateInterest) / 100;
                    return new()
                    {
                        Amount = vm.Amount,
                        Name = loanType.GetLoanType().Where(x => x.Id == vm.Type).Select(x => x.Name).FirstOrDefault().ToString(),
                        InterestRate = vm.RateInterest,
                        Month =vm.MonthlyPay,
                        Total = (percent + vm.Amount) / vm.MonthlyPay
                    };
                case (int)EnumLoanType.LoanType.CAR:
                    percent = (vm.Amount * vm.RateInterest) / 100;
                    return new()
                    {
                        Amount = vm.Amount,
                        Name = loanType.GetLoanType().Where(x => x.Id == vm.Type).Select(x => x.Name).FirstOrDefault().ToString(),
                        InterestRate = vm.RateInterest,
                        Month=vm.MonthlyPay,
                        Total = (percent + vm.Amount) / vm.MonthlyPay
                    };
                case (int)EnumLoanType.LoanType.MORTGAGE:
                    percent = (vm.Amount * vm.RateInterest) / 100;
                    return new()
                    {
                        Amount = vm.Amount,
                        Name = loanType.GetLoanType().Where(x => x.Id == vm.Type).Select(x => x.Name).FirstOrDefault().ToString(),
                        InterestRate = vm.RateInterest,
                        Month=vm.MonthlyPay,
                        Total = (percent + vm.Amount) / vm.MonthlyPay
                    };
                default:
                    return new();
            }

        }
    }
}
