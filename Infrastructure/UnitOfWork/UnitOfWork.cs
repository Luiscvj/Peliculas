using Core.Entities;
using Core.Interfaces;
using Infrastrucre.Data;
using Infrastrucre.Data.Repositories;
using Infrastructure.Repository;

namespace Infrastrucre.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{

    private readonly PeliculasContext _context;

    public UnitOfWork(PeliculasContext context)
    {
        _context = context;
    }


    private PeliculaRepository _pelicula;
    private ActorRepository _actor;
    







    public IPelicula Peliculas
    {
        get
        {

            if( _pelicula == null)
            {
                
            
                    _pelicula = new PeliculaRepository(_context);
                
            }
            return _pelicula;
        }
    } 

   public IActor Actores
   {
    get
    {
        if(_actor == null)
        {
            _actor = new ActorRepository(_context);
        }
        return _actor;
    }
   }


    public Task<int> SaveAsync()
    {
        throw new NotImplementedException();
    }
}