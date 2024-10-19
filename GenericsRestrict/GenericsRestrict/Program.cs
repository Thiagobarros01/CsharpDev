using GenericsRestrict.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRestrict {
    internal class Program {
        static void Main(string[] args) {

        List<Produto> produtos = new List<Produto>();


            Console.WriteLine("Quantos? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Nome do produto? ");
                string name = Console.ReadLine();
                Console.WriteLine("Preco ");
                double preco = double.Parse(Console.ReadLine());
                produtos.Add( new Produto(name, preco));
                
            }
            
      

    
            CalculationService calculationService = new CalculationService();
            Produto max = calculationService.Max(produtos);

            Console.WriteLine("max");
            Console.WriteLine(max);
            Console.ReadLine();
        }
    } 
}
