using System.Linq.Expressions;
using Core.Interfaces;
using Infrastrucre.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucute.Data.Repositories;


public class BaseRepository<T> : IRepository<T> where T : class
{


    private readonly PeliculasContext _context;

    public BaseRepository(PeliculasContext context)
    {
        _context = context;
    }
    public virtual void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public  virtual void AddRange(T entities)
    {
        _context.Set<T>().AddRange(entities);
    }

    public void AddRange(IEnumerable<T> entities)
    {
        throw new NotImplementedException();
    }

    public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return   _context.Set<T>().Where(expression);
    }

    public virtual async Task<IEnumerable<T>> GetAll()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetById(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public  void Remove(T entity)
    {
          _context.Set<T>().Remove(entity);
    }

    public void RemoveAll(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
}