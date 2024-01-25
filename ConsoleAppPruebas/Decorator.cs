using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPruebas
{
    public class Decorator : IReproductorMultimedia
    {
        private readonly IReproductorMultimedia reproductorMultimedia;

        public Decorator(IReproductorMultimedia reproductorMultimedia) 
        {
            this.reproductorMultimedia = reproductorMultimedia;
        }

        public void Avanzar(int segundos)
        {
            Console.WriteLine("decorador Avanzar");
            reproductorMultimedia.Avanzar(segundos);
        }

        public void Detener()
        {
            Console.WriteLine("decorador Detener");
            reproductorMultimedia.Detener();
        }

        public void Pausar()
        {
            Console.WriteLine("decorador Pausar");
            reproductorMultimedia.Pausar();
        }

        public void Reproducir()
        {
            Console.WriteLine("decorador Reproducir");
            reproductorMultimedia.Reproducir();
        }
    }
}
