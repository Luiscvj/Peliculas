using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastrucre.Data;
using Infrastrucute.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class PeliculaRepository : IPelicula
{
  private readonly PeliculasContext _context;

    public PeliculaRepository(PeliculasContext context)
    {
        _context = context;
    }
    public virtual void Add(Pelicula entity)
    {
        _context.Set<Pelicula>().Add(entity);
    }

  

    public void AddRange(IEnumerable<Pelicula> entities)
    {
        _context.Set<Pelicula>().AddRange(entities);
    }

    public virtual IEnumerable<Pelicula> Find(Expression<Func<Pelicula, bool>> expression)
    {
        return   _context.Set<Pelicula>().Where(expression);
    }

    public virtual async Task<IEnumerable<Pelicula>> GetAll()
    {
        return await _context.Set<Pelicula>().ToListAsync();
    }

    public async Task<Pelicula> GetById(int id)
    {
        return await _context.Set<Pelicula>().FindAsync(id);
    }

    public  void Remove(Pelicula entity)
    {
          _context.Set<Pelicula>().Remove(entity);
    }

    public void RemoveAll(IEnumerable<Pelicula> entities)
    {
        _context.Set<Pelicula>().RemoveRange(entities);
    }

    public void Update(Pelicula entity)
    {
        _context.Set<Pelicula>().Update(entity);
    }
}