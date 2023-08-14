using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;

public interface IActor 
{
    Task<Actor> GetById(int id);
    Task<IEnumerable<Actor>> GetAll();
    IEnumerable<Actor> Find(Expression<Func<Actor, bool>>expression);
    void Remove(Actor entity);
    void RemoveAll(IEnumerable<Actor> entities);
    void Add(Actor entity);
    void AddRange(IEnumerable<Actor> entities);
    void Update(Actor entity);
}