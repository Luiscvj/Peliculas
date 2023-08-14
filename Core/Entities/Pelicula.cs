namespace Core.Entities;

public class Pelicula
{
    public int PeliculaId { get; set; }
    public string ?  NombrePelicula { get; set; }
    public int Calificacion { get; set; }
    public List<Genero> Generos { get; set; }
    public List<Comentario> Comentarios { get; set; }
    public List<PeliculaActor> peliculaActores { get; set; }
    public List<Actor> Actores { get; set; }

}