using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPruebas
{
    public interface IReproductorMultimedia
    {
        void Reproducir();
        void Pausar();
        void Detener();
        void Avanzar(int segundos);
    }
}
