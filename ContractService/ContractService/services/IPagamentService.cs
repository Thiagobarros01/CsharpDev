using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractService.services {
     interface IPagamentService {

        double PaymentFee(double amount);
        double Interest(double amount, int months);


    }
}
