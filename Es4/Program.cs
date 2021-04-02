using System;
using System.Collections.Generic;

namespace Es4
{
    class Program
    {
        static void Main(string[] args)
        {
            // creo alcuni corsi
            Corso analisi1 = new Corso("Analisi1", 12);
            Corso geometria = new Corso("Geometria", 12);
            Corso algebra = new Corso("Algebra", 8);
            Corso analisi2 = new Corso("Analisi2", 12);
            Corso fisica1 = new Corso("Fisica1", 12);
            Corso fisica2 = new Corso("Fisica2", 12);

            // creo alcuni corsi di laurea



            CorsoDiLaurea informatica = new CorsoDiLaurea(NomeCorsiDiLaurea.Informatica, 4, 32, new List<Corso> { analisi1, geometria, algebra, analisi2 });
            CorsoDiLaurea fisica = new CorsoDiLaurea(NomeCorsiDiLaurea.Fisica, 4, 36, new List<Corso> { analisi1, geometria, algebra, analisi2 });
            CorsoDiLaurea ingegneria = new CorsoDiLaurea(NomeCorsiDiLaurea.Ingegneria, 4, 36, new List<Corso> { analisi1, geometria, algebra, analisi2 });

            // creo alcune immatricolazioni

            Immatricolazione imm1 = new Immatricolazione(DateTime.Today, informatica);
            Immatricolazione imm2 = new Immatricolazione(DateTime.Today, fisica);
            Immatricolazione imm3 = new Immatricolazione(DateTime.Today, ingegneria);

            // creo alcuni studenti

            Studente gino = new Studente("Gino", "Gini", 2000, imm1);
            Studente pino = new Studente("Pino", "Pini", 2000, imm2);
            Studente tino = new Studente("Tino", "Tini", 2000, imm3);

            Esame e1 = gino.RichiestaEsame("Analisi1"); // e1 != null
            gino.EsamePassato(e1);

            Esame e2 = gino.RichiestaEsame("Geometria"); // e2 != null
            gino.EsamePassato(e2);

            Esame e3 = gino.RichiestaEsame("Fisica1");     // non fa parte del suo piano di studi   // e3 == null
            Esame e4 = gino.RichiestaEsame("Analisi2");    // con questo supererebbe il punteggio   // e4 == null

            Esame e5 = gino.RichiestaEsame("Algebra");     // con questo raggiunge il punteggio giusto per la laurea
            gino.EsamePassato(e5);
        }
    }
}
