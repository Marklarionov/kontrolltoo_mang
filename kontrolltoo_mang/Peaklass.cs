using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace kontrolltoo_mang
{
    internal static class Peaklass
    {
        public static Random rnd = new Random();

        public static List<Ese> LoeEsemed()
        {
            List<Ese> esed = new List<Ese>();
            using (StreamReader sr = new StreamReader(@"../../../Andmed.txt"))
            {
                while(!sr.EndOfStream)
                {
                    string[] rida = sr.ReadLine().Split(";");
                    //Ese ese = new Ese(rida[0].ToString(), Int32.Parse(rida[1]));
                    //esed.Add(ese);
                }
            }
            return esed;
        }

        static string rndName()
        {
            string[] nimed = { "Anton", "Sasha", "Vlad", "Nastja", "Artem" }; 
            return nimed[rnd.Next(nimed.Length)];
        }

        public static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        static Tegelane[] AddEse(Tegelane[] characters)                                       
        {
            List<Ese> itemList = LoeEsemed();
            if (itemList.Count <= 0) throw new ArgumentOutOfRangeException();
            foreach (Tegelane x in characters)
            {
                Shuffle(itemList);
                int amount = rnd.Next(2, 10);
                for (int i = 0; i < amount; i++)
                {
                    x.add(itemList[i]);
                }
            }
            return characters;
        }
        static Tegelane[] bestPlayers(int bstCount)
        {
            if (bstCount < 4) throw new Exception();
            Tegelane[] mängijad = new Tegelane[bstCount];
            for (int i = 0; i < bstCount; i++)
            {
                Tegelane mängija = new Tegelane(rndName());
                mängijad[i] = mängija;
            }
            return (mängijad);
        }
    }
}