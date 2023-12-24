using AutoMapper;
using FirstAppEf.Models;
using FirstAppEf.Repository.Entities;
using Humanizer.Bytes;

namespace FirstAppEf.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PersonaDto, Persona>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<Persona, PersonaDto>();

            CreateMap<PeliculaDto, Pelicula>()
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => this.GetBytes(src.Image)))
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<Pelicula, PeliculaDto>()
                .ForMember(dest => dest.ImageBytes, opt => opt.MapFrom(src => src.Image))
                .ForMember(dest => dest.Genero, opt => opt.MapFrom(src =>src.Genero.Nombre))
                .ForMember(dest => dest.Image, opt => opt.Ignore());

            CreateMap<Genero, GeneroDto>();

            CreateMap<AlquilerDto, Alquiler>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<Alquiler, AlquilerDto>();

        }

        private byte[] GetBytes(IFormFile file) 
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Lee el contenido del archivo y lo copia en memoryStream.
                file.CopyTo(memoryStream);

                // Convierte el contenido a un arreglo de bytes.
                byte[] bytes = memoryStream.ToArray();

                return bytes;

                
            }

        }

        public byte[] ConvertirABytes(IFormFile file)
        {
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }
    }
}
