using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class EjercicioTasks
    {
        public async Task<string> MiMetodo1()
        {         
            // Llamada a un método asíncrono
            await Task.Delay(5000);

            Console.WriteLine("terino metodo 1 espera 5 seg");

            return "termino metodo 1";
        }

        public async Task<string> MiMetodo2()
        {
            // Llamada a un método asíncrono
            await Task.Delay(1000);
            Console.WriteLine("terino metodo 2 espera 1 seg");

            return "termino metodo 2";
        }

        public string MiMetodo1Sincronico()
        {
            // Llamada a un método asíncrono
            Thread.Sleep(10000);

            Console.WriteLine("terino metodo 1 sincronico espera 10 seg");

            return "termino metodo 1";
        }

        public string MiMetodo2Sincronico()
        {
            Thread.Sleep(1);

            Console.WriteLine("terino metodo 2 sincronico esper 1 miliseg");

            return "termino metodo 2";
        }
    }
}
