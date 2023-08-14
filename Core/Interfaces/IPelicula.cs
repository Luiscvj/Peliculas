using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IPelicula 
{
    Task<Pelicula> GetById(int id);
    Task<IEnumerable<Pelicula>> GetAll();
    IEnumerable<Pelicula> Find(Expression<Func<Pelicula, bool>> expression);
    void Add(Pelicula entity);
    void AddRange(IEnumerable<Pelicula> entities);
    void Remove(Pelicula entity);
    void RemoveAll(IEnumerable<Pelicula> entities);
    void Update(Pelicula entity);
}