using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es4
{
    class Studente
    {
        public string Nome { get; }
        public string Cognome { get; }
        public int AnnoDiNascita { get; }
        public Immatricolazione Immatricolazione;
        public List<Esame> Esami { get; } = new List<Esame>();
        public bool RichiestaLaurea { get; private set; }

        public Studente(string nome, string cognome, int annoDiNascita, Immatricolazione immatricolazione)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoDiNascita;
            Immatricolazione = immatricolazione;
        }

        public Esame RichiestaEsame(string nomeEsame)
        {
            Corso c = Immatricolazione.RecuperaCorso(nomeEsame);

            if (c != null && c.CFU + Immatricolazione.CFUAccumulati <= Immatricolazione.CorsoDiLaurea.CFURichiesti && RichiestaLaurea == false)
            {
                Esame e = new Esame(c);

                Esami.Add(e);

                return e;
            }

            return null;
        }

        internal void EsamePassato(Esame e)
        {
            Immatricolazione.CFUAccumulati += e.Corso.CFU;
            e.Passato = true;
            if (Immatricolazione.CFUAccumulati >= Immatricolazione.CorsoDiLaurea.CFURichiesti)
                RichiestaLaurea = true;
        }
    }
}
