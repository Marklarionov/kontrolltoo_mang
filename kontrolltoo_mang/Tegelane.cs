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
        private List<Ese> Andmed;

        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        } 

        public void add (Ese asi) 
        {
            Andmed.Add(asi); 
        }

        public int EsedCount() 
        { 
            return Andmed.Count; 
        }

        public int punktideArv()
        {
            int sum = 0;
            foreach(Ese asi in Andmed)
            {
                //sum += asi.punktideArv();
            }
            Console.WriteLine(sum + " punktid");
            return sum;
        }

        public string info()
        {
            return $"Nimi: {nimi}" +
            $"Esemetu arv: {Andmed.Count()}" +
            $"Punktide arv: {punktideArv()}";
        }

        public void valjastaEsemed()
        {
            foreach(Ese asi in Andmed)
            {
                //Console.WriteLine(asi.Info() + " " + asi.punktideArv());
            }
        }

        public int CompareTo(Tegelane other)             
        {
            if (this.Andmed.Count > other.Andmed.Count) 
            {
                return 1;                                 
            }
            else                                         
            {
                return -1;                               
            }
        }
    }
}
