using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractService.entities {
    internal class Installment {

        private DateTime DueDate { get; set; }

        private Double Amount { get; set; }

        public Installment(DateTime dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString() {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);



        }
    }
}
