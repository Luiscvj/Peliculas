namespace Core.Entities;
public class Actor
{

    public int ActorId { get; set; }
    public string Nombre { get; set; }
    public decimal Sueldo { get; set; } 
    public List<PeliculaActor> peliculaActores { get; set; }
    public List<Pelicula> Peliculas { get; set; }

}