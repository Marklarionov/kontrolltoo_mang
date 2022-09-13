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

        public void add (Ese asi) { eses.Add(asi); }

    }
}
