namespace Core.Entities;

public class Comentario
{
    public int ComentarioId { get; set; }   
    public string Opinion { get; set; }
    public int PeliculaId { get; set; }
    public Pelicula Pelicula { get; set; }
}