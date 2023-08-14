using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucre.Data.Repositories;

public class ActorRepository : IActor
{
    protected readonly PeliculasContext _context;

    public ActorRepository (PeliculasContext context)
    {
        _context = context;
    }
  public virtual void Add(Actor entity)
    {
        _context.Set<Actor>().Add(entity);
    }

  

    public void AddRange(IEnumerable<Actor> entities)
    {
        _context.Set<Actor>().AddRange(entities);
    }

    public virtual IEnumerable<Actor> Find(Expression<Func<Actor, bool>> expression)
    {
        return   _context.Set<Actor>().Where(expression);
    }

    public virtual async Task<IEnumerable<Actor>> GetAll()
    {
        return await _context.Set<Actor>().ToListAsync();
    }

    public async Task<Actor> GetById(int id)
    {
        return await _context.Set<Actor>().FindAsync(id);
    }

   

    public  void Remove(Actor entity)
    {
          _context.Set<Actor>().Remove(entity);
    }

    public void RemoveAll(IEnumerable<Actor> entities)
    {
        _context.Set<Actor>().RemoveRange(entities);
    }

    public void Update(Actor entity)
    {
        _context.Set<Actor>().Update(entity);
    }
}