using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;


public class PeliculaConfiguration : IEntityTypeConfiguration<Pelicula>
{
    public void Configure(EntityTypeBuilder<Pelicula> builder)
    {
        builder.ToTable("Pelicula");
        
        builder.HasMany(p =>p.Actores)
        .WithMany(a =>  a.Peliculas)
        .UsingEntity<PeliculaActor>();
        
    }
}