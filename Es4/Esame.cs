using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es4
{
    class Esame
    {
        public Corso Corso { get; }
        public bool Passato { get; set; }

        public Esame(Corso corso)
        {
            Corso = corso;
        }
    }
}
