using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolltoo_mang
{
    internal class Tegelane : Uksus
    {
        private string nimi;
        private List<Ese> eses;

        public Tegelane(string nimi)
        {
            eses = new List<Ese>();
            this.nimi = nimi;
        } 
        public void add (Ese asi) 
        {
            eses.Add(asi); 
        }
        public int punktideArv()
        {
            int sum = 0;
            foreach(Ese asi in eses)
            {
                sum += asi.PunktideArv();
            }
            return sum;
        }
        public string info()
        {
            Console.WriteLine($"Nimi: {nimi}");
            Console.WriteLine($"Esemetu arv: {eses.Count}");
            Console.WriteLine($"Punktide arv: {punktideArv()}");
            return nimi;
        }
        public void valjastaEsemed()
        {
            foreach(Ese asi in eses)
            {
                Console.WriteLine(asi.Info() + " " + asi.PunktideArv());
            }
        }

        /*public int CompareTo(Tegelane other)
        {
            if (other == null) return 1;

        }*/
    }
}
