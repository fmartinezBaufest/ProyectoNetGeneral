using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class EjercicioInyeccionDependencia
    {
        public void executed()
        {
            var servicioEmail = new NotificacionEmailService();
            var servicioSMS = new NotificacionSMSService();

            // Utilizar inyección de dependencia al crear instancias de Notificador
            var notificadorEmail = new Notificador(servicioEmail);
            var notificadorSMS = new Notificador(servicioSMS);

            // Ejemplos de notificación
            notificadorEmail.NotificarUsuario("¡Hola! Este es un correo electrónico importante.");
            notificadorSMS.NotificarUsuario("¡Hola! Has recibido un nuevo mensaje de texto.");

            // Puedes cambiar fácilmente la implementación del servicio sin modificar Notificador
            // por ejemplo, puedes agregar un nuevo servicio de notificación sin cambiar el código principal.

            Console.ReadLine();
        }
    }

    public interface INotificacionService
    {
        void EnviarNotificacion(string mensaje);
    }

    public class NotificacionEmailService : INotificacionService
    {
        public void EnviarNotificacion(string mensaje)
        {
            Console.WriteLine($"Enviando notificación por correo electrónico: {mensaje}");
        }
    }

    public class NotificacionSMSService : INotificacionService
    {
        public void EnviarNotificacion(string mensaje)
        {
            Console.WriteLine($"Enviando notificación por SMS: {mensaje}");
        }
    }

    public class Notificador
    {
        private readonly INotificacionService _notificacionService;

        // Constructor que recibe una implementación de INotificacionService
        public Notificador(INotificacionService notificacionService)
        {
            _notificacionService = notificacionService;
        }

        // Método que utiliza el servicio de notificación
        public void NotificarUsuario(string mensaje)
        {
            // Lógica adicional si es necesario

            // Utiliza el servicio de notificación
            _notificacionService.EnviarNotificacion(mensaje);

            // Más lógica si es necesario
        }
    }
}
