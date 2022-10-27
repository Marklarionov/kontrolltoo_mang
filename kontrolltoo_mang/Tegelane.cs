using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolltoo_mang
{
    internal class Tegelane : IUksus , IComparable<Tegelane>
    {
        //3.1 Klassis on privaatsed isendiväljad järgmise info jaoks: nimi(String) ja esemete nimekiri
        private string nimi;
        private List<Ese> List;
        //3.2 Klassis peab olema ühe parameetriga konstruktor, mille abil saab määrata nime.
        public Tegelane(string nimi)
        {
            this.nimi = nimi;
            List = new List<Ese>();
        }
        //3.3 Äsjaloodud tegelasel ei ole ühtegi eset. Eseme lisamiseks peab olema meetod lisaEse, mis jätab argumendiks antud eseme meelde.
        public void add (Ese asi) 
        {
            List.Add(asi); 
        }
        //3.4 Meetod punktideArv tagastab punktide arvu.
        public int PunktideArv()
        {
            int sum = 0;
            foreach(Ese asi in List)
            {
                sum += asi.PunktideArv();
            }
            return sum;
        }
        //3.5 Meetod info tagastab selle eseme nimetuse.
        public string info()
        {
            string print_info = $"Nimi: {nimi}, " +
            $"Esemetu arv: {List.Count}, " +
            $"Punktide arv: {PunktideArv()} ";
            return print_info;
        }
        //3.6 Klassis peab olema ka meetod väljastaEsemed, kus väljastatakse ekraanile tegelase esemed nii, et iga ese on eraldi real.
        public void valjastaEsemed()
        {
            foreach(Ese asi in List)
            {
                Console.WriteLine(asi.info());
            }
        }
        //3.7 Klass Tegelane realiseerib liidese Comparable<Tegelane>, kusjuures compareTo meetod
        //realiseeritakse nii, et võrdlemine toimub esemete arvu alusel.
        public int CompareTo(Tegelane? other)             
        {
            if (other == null)
            {
                return 1;
            }
            return this.List.Count - other.andmeKogus();
        }
        private int andmeKogus()
        {
            return this.List.Count;
        }
    }
}
