namespace Core.Entities;

public class Genero
{
    public int GeneroId { get; set; }   
    public string Categoria { get; set; }
    public List<Pelicula> Peliculas{ get; set; }
    
} 