using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es4
{
    class Immatricolazione
    {
        private static int _matricola;
        public int Matricola { get; }
        public DateTime DataInizio { get; }
        public CorsoDiLaurea CorsoDiLaurea { get; }
        public bool FuoriCorso { get; }
        public int CFUAccumulati { get; set; }

        public Immatricolazione(DateTime dataInizio, CorsoDiLaurea corsoDiLaurea)
        {
            Matricola = ++_matricola;
            DataInizio = dataInizio;
            CorsoDiLaurea = corsoDiLaurea;
        }

        public Corso RecuperaCorso(string esame)
        {
            return CorsoDiLaurea.RecuperaCorso(esame);
        }   
    }
}
