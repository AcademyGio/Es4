using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es4
{
    enum NomeCorsiDiLaurea
    {
        Matematica,
        Fisica, 
        Informatica,
        Ingegneria,
        Lettere
    }

    class CorsoDiLaurea
    {
        public NomeCorsiDiLaurea Nome { get; }
        public int AnniDiCorso { get; }
        public int CFURichiesti { get; }
        public List<Corso> Corsi { get; }
        public Corso RecuperaCorso(string esame)
        {
            foreach (Corso c in Corsi)
                if (c.Nome == esame)
                    return c;
            return null;
        }
        public CorsoDiLaurea(NomeCorsiDiLaurea nome, int anniDiCorso, int cfuRichiesti, List<Corso> corsi)
        {
            Nome = nome;
            AnniDiCorso = anniDiCorso;
            CFURichiesti = cfuRichiesti;
            Corsi = corsi;
        }
    }
}
