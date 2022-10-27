using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace kontrolltoo_mang
{
    //  5. Peaklass peab olema nimega Peaklass.
    internal static class Peaklass
    {
        public static Random rnd = new Random();
        //5.1 Rakendatakse vastavat staatilist meetodit, et lugeda failist esemed.txt esemete andmed.
        public static List<Ese> LoeEsemed()
        {
            List<Ese> esed = new List<Ese>();
            StreamReader sr = new StreamReader(@"..\..\..\Andmed.txt");
            while (!sr.EndOfStream)
            {
                    string[] rida = sr.ReadLine().Split(";");
                Ese ese = new Ese(stringToInt(rida[1]), rida[0]);
                    esed.Add(ese);
            }
            return esed;
        }

        static int stringToInt(string a)
        {
            int i = 0;
            int total = 0;
            for (int j = 0; i < a.Length; j++)
            {
                i = i * 10 + (a[i] - '0');
            }
            total += i;
            return total;
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
        //5.2 Luuakse vähemalt 5 tegelast(nimed mõelge ise välja).
        static string rndName()
        {
            string[] nimed = { "Anton", "Sasha", "Vlad", "Nastja", "Artem" }; 
            return nimed[rnd.Next(nimed.Length)];
        }       
        //5.3 Kõikidest tegelastest tehakse Tegelane[]-tüüpi massiiv. 
        //(Massiivi võib ka enne tegelaste tegemist luua ja järjest täita.)
        static Tegelane[] bestPlayers(int bstCount)
        {
            if (bstCount < 4) throw new Exception();
            Tegelane[] players = new Tegelane[bstCount];
            for (int i = 0; i < bstCount; i++)
            {
                Tegelane player = new Tegelane(rndName());
                players[i] = player;
            }
            return AddEse(players);
        }
        //4. Iga tegelase jaoks genereeritakse juhuslik arv n vahemikust[2, 10], mis näitab selle tegelase esemete
        //arvu.Iga tegelase jaoks valitakse juhuslikult n eset.
        static Tegelane[] AddEse(Tegelane[] characters)                                       
        {
            List<Ese> itemList = LoeEsemed();
            if (itemList.Count <= 0) throw new ArgumentOutOfRangeException();
            foreach (Tegelane player in characters)
            {
                Shuffle(itemList);
                int amount = rnd.Next(2, 10);
                for (int i = 0; i < amount; i++)
                {
                    player.add(itemList[i]);
                }
            }
            return characters;
        }
        static public void Play(int bstCount)
        {
            Tegelane[] players = bestPlayers(bstCount);
            Mang mang = new Mang(players);
            foreach (Tegelane winner in mang.SuurimaEsemeteArvuga())
            {
                Console.WriteLine(winner.info);
            }
            Tegelane win = mang.suurimaPunktideArvuga();
            Console.WriteLine(win.info());
            Console.WriteLine("Tegelasel on need esemed:");
            Console.WriteLine();
            win.valjastaEsemed();
        }
    }
}