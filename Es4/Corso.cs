using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es4
{
    class Corso
    {
        public string Nome { get; }
        public int CFU { get; }

        public Corso(string nome, int cfu)
        {
            Nome = nome;
            CFU = cfu;
        }
    }
}
