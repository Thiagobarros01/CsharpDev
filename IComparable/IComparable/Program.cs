﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comparable.entities;

namespace Comparable {
    internal class Program {
        static void Main(string[] args) {

            string path = @"C:\Users\Thiago\Documents\in.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();
                    foreach(Employee emp in list) {
                        Console.WriteLine(emp);
                    }
                }
                
            }
            catch (IOException e) {

                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);


            }




            Console.ReadLine();
        }
    }
}
