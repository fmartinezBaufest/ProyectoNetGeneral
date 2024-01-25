using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPruebas
{
    internal class ReproductorDeMusica: IReproductorMultimedia
    {
        public void Reproducir()
        {
            Console.WriteLine("Reproduciendo música");
        }

        public void Pausar()
        {
            Console.WriteLine("Pausando música");
        }

        public void Detener()
        {
            Console.WriteLine("Deteniendo música");
        }

        public void Avanzar(int segundos)
        {
            Console.WriteLine($"Avanzando {segundos} segundos");
        }
    }
}
