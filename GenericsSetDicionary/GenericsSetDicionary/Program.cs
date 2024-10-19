using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSetDicionary {
    internal class Program {
        static void Main(string[] args) {

            PrintService<String> service = new PrintService<String>();

            Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string value = Console.ReadLine();
                service.AddValue(value);
            }

            service.Print();
            Console.WriteLine(service.firs());

            


            Console.ReadLine();


        }
    }
}
