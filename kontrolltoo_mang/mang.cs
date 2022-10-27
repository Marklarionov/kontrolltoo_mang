using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolltoo_mang
{
    //4. Klassis Mäng peab olema privaatne isendiväli fikseeritud pikkusega tegelaste nimekirja
    //(Tegelane[]) jaoks.Klassis peab olema ühe parameetriga konstruktor, mille abil saab määrata tegelaste
    //nimekirja.
    internal class Mang
    {
        private Tegelane[] character;
        public Mang(Tegelane[] character)
        {
            this.character = character;
        }
        //4.1 Klassis on Tegelane-tüüpi parameetriteta meetod suurimaEsemeteArvuga, mis tagastab
        //suurima esemete arvuga tegelase.Meetodis tegelased sorteeritakse vastavalt meetodis compareTo
        //kirjeldatud järjekorrale ja sorteeritud massiivist võetakse suurima esemete arvuga tegelast.
        public List<Tegelane> SuurimaEsemeteArvuga()
        {
            List<Tegelane> voitjad = new List<Tegelane>();
            Tegelane sorted = character[0];
            foreach(Tegelane t in character)
            {
                int num = sorted.CompareTo(t);
                if (num < 0)
                {
                    sorted = t;
                    voitjad.Clear();
                }
                if (num == 0)
                {
                    voitjad.Add(t);
                }
                    
            }
            voitjad.Add(sorted);
            return voitjad;
        }
        //4.2 Klassis on Tegelane-tüüpi parameetriteta meetod suurimaPunktideArvuga, mis tagastab
        //suurima punktide arvuga tegelase.
        public Tegelane suurimaPunktideArvuga()
        {
            int parim = 0;
            Tegelane voitja = character[0];
            foreach(var t in character)
            {
                int arv = t.PunktideArv();
                if (arv > parim)
                {
                    parim = arv;
                    voitja = t;
                }
            }
            return voitja;
        }
    }
}
