using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolltoo_mang
{
    class Ese : IUksus
    {
        //2.1 Klassis on privaatsed isendiväljad järgmise info jaoks: nimetus(String) ja punktide arv(int).
        private int punktideArv; 
        private string nimi;
        
        //2.2 Klassis peab olema kahe parameetriga konstruktor,mille abil saab määrata nimetuse ja punktide
        public Ese(int punktideArv, string nimetus) 
        {
            this.punktideArv = punktideArv;
            this.nimi = nimetus;
        }
        //2.3 Meetod punktideArv tagastab punktide arvu.
        public string info()
        {
            Console.WriteLine(nimi);
            return nimi;
        }
        //2.4 Meetod info tagastab selle eseme nimetuse.
        public int PunktideArv() 
        { 
            return punktideArv; 
        } 
    }
}
