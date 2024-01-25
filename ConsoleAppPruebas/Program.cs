﻿using ConsoleAppPruebas;
using MongoDB.Driver;
using Ninject;
using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        

        public Program()
        {
            
        }

        static void Main(string[] args)
        {            
            Console.WriteLine("Hello World!"); 
            IKernel kernel = new StandardKernel(new MyNinjectModule());
            var p = kernel.Get<Procces>();

            p.Ejecutar();

            List<MensajeCartelLed> l = new List<MensajeCartelLed>()
            {
                new MensajeCartelLed()
                {
                    Orden = 1,
                    Codigo = "LlamadoCallePreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "01",
                    HistorialMensajeCartelLed = new HistorialMensajeCartelLed
                    {
                        Mensaje = "AGR326",
                        FechaUltimaModificacion = new DateTime(2024, 01, 05),
                        Calle = new Calle
                        {
                            Id = 1,
                            
                        }
                        
                        
                    },
                    
                },
                new MensajeCartelLed()
                {
                    Orden = 2,
                    Codigo = "LlamadoCallePreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "03",
                    HistorialMensajeCartelLed = new HistorialMensajeCartelLed
                    {
                        Mensaje = "fila2",
                        FechaUltimaModificacion = new DateTime(2024, 01, 06),
                        Calle = new Calle
                        {
                            Id = 2,

                        }


                    },

                },
                new MensajeCartelLed()
                {
                    Orden = 3,
                    Codigo = "LlamadoCallePreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "05",
                    HistorialMensajeCartelLed = new HistorialMensajeCartelLed
                    {
                        Mensaje = null,
                        FechaUltimaModificacion = null,
                        Calle = null


                    },

                },
                new MensajeCartelLed()
                {
                    Orden = 4,
                    Codigo = "LlamadoCallePreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "07",
                    
                },
                new MensajeCartelLed()
                {
                    Orden = 1,
                    Codigo = "LlamadoCamionPreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "02",
                    HistorialMensajeCartelLed = new HistorialMensajeCartelLed
                    {
                        Mensaje = "AGR327",
                        FechaUltimaModificacion = new DateTime(2024, 01, 05, 14,0,0),
                        Calle = new Calle
                        {
                            Id = 1,

                        }


                    },

                },
                new MensajeCartelLed()
                {
                    Orden = 1,
                    Codigo = "LlamadoCamionPreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "04",

                },
                new MensajeCartelLed()
                {
                    Orden = 1,
                    Codigo = "LlamadoCamionPreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "06",

                },
                new MensajeCartelLed()
                {
                    Orden = 1,
                    Codigo = "LlamadoCamionPreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "08",

                },
            };
            List<MensajeCartelLed> l2 = new List<MensajeCartelLed>()
            {
                new MensajeCartelLed()
                {
                    Orden = 1,
                    Codigo = "LlamadoCallePreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "01",
                    HistorialMensajeCartelLed = new HistorialMensajeCartelLed
                    {
                        Mensaje = "AGR326",
                        FechaUltimaModificacion = new DateTime(2024, 01, 05),
                        Calle = new Calle
                        {
                            Id = 1,

                        }


                    },

                },
                new MensajeCartelLed()
                {
                    Orden = 2,
                    Codigo = "LlamadoCallePreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "03",
                    

                },
                new MensajeCartelLed()
                {
                    Orden = 3,
                    Codigo = "LlamadoCallePreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "05",
                    HistorialMensajeCartelLed = new HistorialMensajeCartelLed
                    {
                        Mensaje = null,
                        FechaUltimaModificacion = null,
                        Calle = null


                    },

                },
            };

            List<MensajeCartelLed> l3 = new List<MensajeCartelLed>()
            {
                new MensajeCartelLed()
                {
                    Orden = 1,
                    Codigo = "LlamadoCallePreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "01",
                    HistorialMensajeCartelLed = new HistorialMensajeCartelLed
                    {
                        Mensaje = "AGR326",
                        FechaUltimaModificacion = new DateTime(2024, 01, 05),
                        Calle = new Calle
                        {
                            Id = 1,

                        }


                    },

                },
                new MensajeCartelLed()
                {
                    Orden = 2,
                    Codigo = "LlamadoCallePreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "03",

                },
                new MensajeCartelLed()
                {
                    Orden = 3,
                    Codigo = "LlamadoCallePreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "05",

                },
                new MensajeCartelLed()
                {
                    Orden = 4,
                    Codigo = "LlamadoCallePreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "07",

                },
                new MensajeCartelLed()
                {
                    Orden = 1,
                    Codigo = "LlamadoCamionPreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "02",

                },
                new MensajeCartelLed()
                {
                    Orden = 1,
                    Codigo = "LlamadoCamionPreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "04",

                },
                new MensajeCartelLed()
                {
                    Orden = 1,
                    Codigo = "LlamadoCamionPreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "06",

                },
                new MensajeCartelLed()
                {
                    Orden = 1,
                    Codigo = "LlamadoCamionPreBalanza",
                    Programa = "01",
                    Trama = "01",
                    Variable = "08",

                    HistorialMensajeCartelLed = new HistorialMensajeCartelLed
                    {
                        Mensaje = "AGR327",
                        FechaUltimaModificacion = new DateTime(2024, 01, 05, 14,0,0),
                        Calle = new Calle
                        {
                            Id = 1,

                        }


                    },

                },
            };

            l = l.Where(x => x.Codigo == "LlamadoCallePreBalanza").ToList();

            //p.ReordenarMensajes(l);
            p.VerCarteleriaNoGranos();

            p.Burbuja(l2);

            p.SaveMongoDb2();

        }

        
    }
    public class Procces
    {
        private readonly IReproductorMultimedia reproductorMultimedia;

        public Procces(IReproductorMultimedia reproductorMultimedia)
        {
            this.reproductorMultimedia = reproductorMultimedia;
        }

        public void Ejecutar()
        {
            this.reproductorMultimedia.Avanzar(10);

            this.reproductorMultimedia.Pausar();

            this.reproductorMultimedia.Reproducir();

            this.reproductorMultimedia.Detener();
        }

        public void ReordenarMensajes(List<MensajeCartelLed> listaMensajes, int? slotCircular = null)
        {
            var historial = listaMensajes
                .Where(x => x.HistorialMensajeCartelLed != null)
                .Where(x => x.HistorialMensajeCartelLed?.FechaUltimaModificacion != null)
                .Where(x => slotCircular == null || x.Orden != slotCircular)
                .Select(x => x.HistorialMensajeCartelLed)
                .OrderBy(x => x.FechaUltimaModificacion).ToList();

            var listMensajesCant = (slotCircular == null) ? listaMensajes.Count() : listaMensajes.Count() - 1;

            for (int i = 0; i < listMensajesCant; i++)
            {
                var tieneDatos = (i < historial.Count());

                if (listaMensajes[i].HistorialMensajeCartelLed == null)
                    continue;

                listaMensajes[i].HistorialMensajeCartelLed.Calle = (tieneDatos) ? historial[i].Calle : null;
                listaMensajes[i].HistorialMensajeCartelLed.Mensaje = (tieneDatos) ? historial[i].Mensaje : null;
                listaMensajes[i].HistorialMensajeCartelLed.FechaUltimaModificacion = (tieneDatos) ? historial[i].FechaUltimaModificacion : null;

                Console.WriteLine(listaMensajes[i].HistorialMensajeCartelLed.Mensaje, listaMensajes[i].Variable);
            }

            
            
        }

        public void VerCarteleriaNoGranos()
        {
            var recorridosEnCartel = new List<Recorrido>()
            {
                new Recorrido() 
                {
                    Id = 1,

                },
                new Recorrido()
                {
                    Id = 2,

                },
                new Recorrido()
                {
                    Id = 3,

                }
            };

            var contCamionesEnCartel = 0;

            var asignacionNoGran = new List<AsignacionNoGranoEnRecorrido>()
            {
                new AsignacionNoGranoEnRecorrido
                {
                    CallePlantaId = 2551,
                    RecorridoId = 1,
                },
                new AsignacionNoGranoEnRecorrido
                {
                    CallePlantaId = 2525,
                    RecorridoId = 2,
                },
                new AsignacionNoGranoEnRecorrido
                {
                    CallePlantaId = 22,
                    RecorridoId = 3,
                }
            };

            foreach (var item in recorridosEnCartel)
            {
                var r = asignacionNoGran.Where(x => x.RecorridoId == item.Id && x.CallePlantaId == 255).FirstOrDefault();

                if (r != null)
                {
                    contCamionesEnCartel++;
                }
            }

        }

        public void Burbuja(List<MensajeCartelLed> listaMensajes)
        {
            int n = listaMensajes.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Si el elemento actual tiene HistorialMensajeCartelLed nulo y el siguiente no, intercambiarlos
                    if (listaMensajes[j].HistorialMensajeCartelLed == null && listaMensajes[j + 1].HistorialMensajeCartelLed != null)
                    {
                        MensajeCartelLed temp = listaMensajes[j];
                        listaMensajes[j] = listaMensajes[j + 1];
                        listaMensajes[j + 1] = temp;
                    }
                }
            }
        }

        public void SaveMongoDb()
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var dataBase = client.GetDatabase("personas");

            var personasDb = dataBase.GetCollection<Persona>("personas");

            var p = new Persona { Id = 2, Nombre = "jose" };

            personasDb.InsertOne(p);
        }

        public void SaveMongoDb2()
        {
            var client = new MongoClient("mongodb://localhost:27017");

            var dataBase = client.GetDatabase("personas");

            var personasDb = dataBase.GetCollection<Persona>("personas");

            var p = new Persona { Id = 2, Nombre = "jose" };

            var client2 = new MongoClient("mongodb://localhost:27017");
            var database2 = client.GetDatabase("OrquestadorPersistencia");
            var dispositivosDb = database2.GetCollection<DatosDispositivoDto>("Dispositivos");

            List<DatosDispositivoDto> listaDatos = new List<DatosDispositivoDto>
            {
                new DatosDispositivoDto
                {
                    Id = 1,
                    Fecha = DateTime.Now,
                    Evento = Evento.Envio,
                    Mensaje = "Mensaje de ejemplo 1",
                    CodigoDispositivo = "Codigo1",
                    DescripcionDispositivo = "Descripción 1"
                },
                new DatosDispositivoDto
                {
                    Id = 2,
                    Fecha = DateTime.Now.AddDays(1),
                    Evento = Evento.Envio,
                    Mensaje = "Mensaje de ejemplo 2",
                    CodigoDispositivo = "Codigo2",
                    DescripcionDispositivo = "Descripción 2"
                },
                new DatosDispositivoDto
                {
                    Id = 3,
                    Fecha = DateTime.Now.AddDays(2),
                    Evento = Evento.Envio,
                    Mensaje = "Mensaje de ejemplo 3",
                    CodigoDispositivo = "Codigo3",
                    DescripcionDispositivo = "Descripción 3"
                },
            };

            dispositivosDb.InsertMany(listaDatos);

        }
     }

}