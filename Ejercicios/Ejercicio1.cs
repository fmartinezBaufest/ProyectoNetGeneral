using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ejercicio1
    {
        public void Execute()
        {
        }
    }

    public abstract class Figura
    {
        public abstract void CalcularArea();
    }

    public class Circulo : Figura
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Calculo el area del circulo");
        }
    }
}
