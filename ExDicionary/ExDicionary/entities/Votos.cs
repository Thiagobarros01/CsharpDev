using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDicionary.entities {
      class Votos {

        public string Name { get; set; }
        public int Value { get; set; }


         public Votos(string name, int value) {
            this.Name = name;
            this.Value = value;
        }


    }
}
