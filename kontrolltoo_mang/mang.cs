using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolltoo_mang
{
    internal class Mang
    {
        Tegelane[] character;
        public Mang(Tegelane[] character)
        {
            this.character = character;
        }

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
                if (num == 0) voitjad.Add(t);
            }
            voitjad.Add(sorted);
            return voitjad;
        }
        public Tegelane suurimaPunktideArvuga()
        {
            int parim = 0;
            Tegelane voitja = character[0];
            foreach(var t in character)
            {
                int arv = t.punktideArv();
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
