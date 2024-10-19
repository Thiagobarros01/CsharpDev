using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsRestrict {
    class Produto : IComparable {
        string Name { get; set; }
        double Price { get; set; }


        public Produto(string name, double price) {
            this.Name = name;
            this.Price = price;

        }

        public int CompareTo(object obj) {
            if (!(obj is Produto)) {
                throw new ArgumentException("No compar");
            }
            Produto other = obj as Produto;

            return Price.CompareTo(other.Price);


          

        }
        public override string ToString() {
            return Name
                + " - " +
                Price.ToString("F2",CultureInfo.InvariantCulture);

        }
    }
}
