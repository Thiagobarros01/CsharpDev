using System;
using System.Collections.Generic;
using System.IO;
using Ex155.entities;

namespace Ex155 {
    internal class Program {
        static void Main(string[] args) {

            HashSet<Log> logs = new HashSet<Log>();

            string path = @"C:\Users\Thiago\Documents\DocumentsCsharp\logs.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] vect = sr.ReadLine().Split(' ');
                        string Nome = vect[0];
                        DateTime Data = DateTime.Parse(vect[1]);
                        logs.Add(new Log(Nome, Data));
                        
                    }
                    
                }
                Console.WriteLine("Total users: " + logs.Count);

            }
            catch(IOException e) {
                Console.WriteLine(e.Message);
            }
                Console.ReadLine();
            }
        }
    }

