namespace FirstAppEf.Repository.Entities
{
    public class Alquiler
    {
        public int Id { get; set; }

        public virtual Pelicula Pelicula { get; set; }

        public int PeliculaId { get; set; }

        public Persona Persona { get; set; }

        public int PersonaId { get; set; }

        public DateTime Fecha { get; set; }
    }
}
