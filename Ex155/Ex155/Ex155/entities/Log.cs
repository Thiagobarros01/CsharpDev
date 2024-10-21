using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex155.entities {
    class Log {

        public string Nome { get; set; }
        public DateTime Instante { get; set; }

        public Log(string nome, DateTime instante) {
            this.Nome = nome;
            this.Instante = instante;
        }

        public override string ToString() {
            return "Nome:" + Nome + " Instante:" + Instante;
        }

        public override int GetHashCode() {
            return Nome.GetHashCode();
        }
        public override bool Equals(object obj) {
            if (!(obj is Log)) {
                return false;
            }
            Log other = obj as Log;

            return Nome.Equals(other.Nome);
            
        }

    }
}
