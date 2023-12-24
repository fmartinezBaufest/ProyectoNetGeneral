using FirstAppEf.Business.ExceptionDni;
using FirstAppEf.Business.Interfaces;
using FirstAppEf.Models;
using FirstAppEf.Repository.InterfacesDao;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace FirstAppEf.Business
{
    public class AlquilerBusiness: IAlquilerBusiness
    {
        public IAlquilerDao AlquilerDao { get; }

        public AlquilerBusiness(IAlquilerDao alquilerDao)
        {
            AlquilerDao = alquilerDao;
        }

        public AlquilerDto CrearAlquiler(AlquilerDto alquiler)
        {

           return  this.AlquilerDao.Add(alquiler);
        }
    }
}
