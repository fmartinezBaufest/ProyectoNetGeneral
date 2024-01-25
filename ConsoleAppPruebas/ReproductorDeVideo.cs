using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPruebas
{
    internal class ReproductorDeVideo: IReproductorMultimedia
    {
        public void Reproducir()
        {
            Console.WriteLine("Reproduciendo video");
        }

        public void Pausar()
        {
            Console.WriteLine("Pausando video");
        }

        public void Detener()
        {
            Console.WriteLine("Deteniendo video");
        }

        public void Avanzar(int segundos)
        {
            Console.WriteLine($"Avanzando {segundos} segundos en el video");
        }
    }
}
