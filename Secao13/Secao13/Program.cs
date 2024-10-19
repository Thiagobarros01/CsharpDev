using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secao13.Entities;

namespace Secao13 {
    internal class Program {
        static void Main(string[] args) {

            Client a = new Client( "Maria", "Maria@gmail.com" );
            Client b = new Client("Joao", "Joao@gmail.com");
            Client c = new Client("Maria", "Maria@gmail.com");
            Console.WriteLine( a.Equals( c ));

            Console.ReadLine();
        }
    }
}
