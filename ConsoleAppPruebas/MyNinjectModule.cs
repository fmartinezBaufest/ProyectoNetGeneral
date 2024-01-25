using MyApp;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPruebas
{
    public class MyNinjectModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<IReproductorMultimedia>().To<ReproductorDeMusica>();
            Bind<IReproductorMultimedia>().To<ReproductorDeVideo>().WhenInjectedInto<Decorator>();
            Bind<IReproductorMultimedia>().To<Decorator>().WhenInjectedInto<Procces>();

        }
    }
}
