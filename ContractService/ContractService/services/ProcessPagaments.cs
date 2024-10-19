using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContractService.entities;

namespace ContractService.services {
    class ProcessPagaments {

        private IPagamentService _pagamentService;

        public ProcessPagaments(IPagamentService pagamentService) {
        
            _pagamentService = pagamentService;

        
        }

        public void ProcessContract(Contracts contract, int months) {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++) {
            
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _pagamentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _pagamentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));

            }
        }

    }
}
