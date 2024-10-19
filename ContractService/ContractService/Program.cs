using ContractService.entities;
using ContractService.services;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractService {
    internal class Program {
        static void Main(string[] args) {


            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contracts myContract = new Contracts(contractNumber, contractDate, contractValue);

            ProcessPagaments contractService = new ProcessPagaments(new Paypal());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments) {
                Console.WriteLine(installment);
            }
            Console.ReadLine();
        }


        
    }
}

