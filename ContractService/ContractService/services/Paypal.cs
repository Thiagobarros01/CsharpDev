using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractService.services {
    class Paypal : IPagamentService {

        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;
        public double Interest(double amount, int months) {
            return MonthlyInterest * amount * months;
        }

       public double PaymentFee(double amount) {
            return amount * FeePercentage;
        }
    }
}
