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
            Figura circulo = new Circulo();

            Figura rectangulo = new Rectangulo();
            circulo.CalcularArea();
            rectangulo.CalcularArea();
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

    public class Rectangulo : Figura
    {
        public override void CalcularArea()
        {
            Console.WriteLine("Calculo el area del rectangulo");
        }
    }
}
