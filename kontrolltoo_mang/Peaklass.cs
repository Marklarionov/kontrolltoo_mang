using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                    Ese ese = new Ese(StrToInt(rida[1]), rida[0]);
                    esed.Add(ese);
                }
            }
            return esed;
        }
        static int StrToInt(string a)
        {
            int total = 0;
            int b = 0;
            for (int i = 0; i < a.Length; i++)
                b = b * 10 + (a[i] - '0');
            total += b;
            return total;
        }
        public static void Shuffle<T>(this IList<T> list)
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
        static string rndName()
        {
            string[] nimed = { "" }; 
            return nimed[rnd.Next(nimed.Length)];
        }

        static Tegelane[] bestPlayers(int bstCount)
        {
            if (bstCount < 4) throw new Exception();
            Tegelane[] plrs = new Tegelane[bstCount];
            for (int i = 0; i < bstCount; i++)
            {
                Tegelane plr = new Tegelane(rndName());
                plrs[i] = plr;
            }
            return giveOutItems(plrs);
        }
    }
}
