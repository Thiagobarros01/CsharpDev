using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ExDicionary {
     class Program {
        static void Main(string[] args) {

            //Ler o path
            Console.WriteLine("Enter file path");
            string path = Console.ReadLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            




            try {

                using(StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] vect = sr.ReadLine().Split(',');
                        string name = vect[0];
                        int value = int.Parse(vect[1]);
                        if (dict.ContainsKey(name)) {

                            dict[name] += value;
                        }
                        else { 
                        dict.Add(name, value);
                        }
                    }

                }
                foreach (var dic in dict ) {
                    Console.WriteLine("key:" + dic.Key + " valor:" + dic.Value+"\n");
                }

            }
            catch (Exception e) { 
            Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        
        }
    }
}
