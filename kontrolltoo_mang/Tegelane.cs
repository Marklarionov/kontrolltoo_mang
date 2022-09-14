using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolltoo_mang
{
    internal class Tegelane : IUksus , IComparable<Tegelane>
    {
        private string nimi;
        List<Ese> esed;

        public Tegelane(string nimi)
        {
            //esed = new List<Ese>();
            this.nimi = nimi;
        } 
        public void add (Ese asi) 
        {
            esed.Add(asi); 
        }
        public int EsedCount() 
        { 
            return esed.Count; 
        }
        public int punktideArv()
        {
            int sum = 0;
            foreach(Ese asi in esed)
            {
                sum += asi.PunktideArv();
            }
            return sum;
        }
        public string info()
        {
            return $"Nimi: {nimi}" +
            $"Esemetu arv: {esed.Count()}" +
            $"Punktide arv: {punktideArv()}";
        }
        public void valjastaEsemed()
        {
            foreach(Ese asi in esed)
            {
                Console.WriteLine(asi.Info() + " " + asi.PunktideArv());
            }
        }

        public int CompareTo(Tegelane? other)
        {
            if (other == null) return 1;
            return this.esed.Count - other.EsesKogus();
        }
        private int EsesKogus() { return this.esed.Count; }
    }
}
