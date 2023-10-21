namespace FirstAppEf.Repository.Entities
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }
        public byte[] Image { get; set;}
        public virtual Genero Genero { get; set; }
        public int GeneroId { get; set; }
    }
}
