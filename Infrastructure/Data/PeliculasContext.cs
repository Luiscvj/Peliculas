using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucre.Data;


public class PeliculasContext : DbContext
{
    public PeliculasContext(DbContextOptions<PeliculasContext> options) : base(options)
    {

    }

    public DbSet<Actor> Actores {get;set;}
    public DbSet<Comentario> Comentarios{get;set;}
    public DbSet<Genero> Generos {get;set;}
    public DbSet<Pelicula> Peliculas {get;set;}

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().HaveMaxLength(150);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
          base.OnModelCreating(modelBuilder);
          modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}