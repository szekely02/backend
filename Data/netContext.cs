using GameStore.Entities;
using Microsoft.EntityFrameworkCore;
using MinimalApis.Extensions.Results;

namespace GameStore.Data;

public class netContext : DbContext
{
    public netContext(DbContextOptions<netContext> options) : base(options)
    {
    }

    public DbSet<Termekek> termekek => Set<Termekek>();
    public DbSet<Vasarlok> vasarlok => Set<Vasarlok>();
    public DbSet<Rendelesek> rendelesek => Set<Rendelesek>();

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Termekek>().HasKey(termek => termek.Jatek_ID);
        modelBuilder.Entity<Vasarlok>().HasKey(vasarlo => vasarlo.Vasarlo_ID);
        modelBuilder.Entity<Rendelesek>().HasKey(rendeles => rendeles.Rendelesek_ID);
    }
}

