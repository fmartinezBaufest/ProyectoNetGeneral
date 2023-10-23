using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shared
    {
        public int[] Numeros;
        public Shared()
        {
            this.Numeros = new int[6];
            this.Numeros[0] = 1;
            this.Numeros[1] = 2;
            this.Numeros[2] = 3;
            this.Numeros[3] = 4;
        }

       
        public int DevolverNum()
        {
            return this.Numeros.Where(x => x == 5).FirstOrDefault();
        }
    }
}
