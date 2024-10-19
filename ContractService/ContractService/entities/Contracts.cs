using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractService.entities {
     class Contracts {

        public int Number { get; set; }

        public DateTime Date { get; set; }

        public Double TotalValue { get; set; }

        public List<Installment> Installments { get; }

        public Contracts(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }


        public void AddInstallment(Installment installment) {
            Installments.Add(installment);
        }


    }
}
