using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {

            HashSet<string> set = new HashSet<String>();

            set.Add("a");
            set.Add("b");
            set.Add("c");

            Console.WriteLine(set.Contains("1"));
            

            Console.ReadLine();
        }
    }
}
