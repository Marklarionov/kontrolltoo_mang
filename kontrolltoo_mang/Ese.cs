using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolltoo_mang
{
    internal class Ese : IUksus
    {
        private int punktideArv;
        private string nimetus;

        public Ese(int punktideArv, string nimetus)
        {
            this.punktideArv = punktideArv;
            this.nimetus = nimetus;
        }
        public int PunktideArv() 
        { 
            return punktideArv; 
        }
        public string Info()
        {
            Console.WriteLine(nimetus);
            return nimetus; 
        }
        int IUksus.punktideArv()
        {
            throw new NotImplementedException();
        }

        public string info()
        {
            throw new NotImplementedException();
        }
    }
}
