namespace Core.Interfaces;

public interface IUnitOfWork
{
    IPelicula Peliculas {get;}
    IActor Actores {get;}

    Task<int> SaveAsync();
}