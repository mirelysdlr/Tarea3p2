using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using organizadordeventos.Infrastructure.Models;

namespace organizadordeventos.Infrastructure.Context;

public partial class OrgDbContext : DbContext
{
    public OrgDbContext(DbContextOptions<OrgDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Evento> Eventos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Evento__3214EC0711A9ABD7");

            entity.ToTable("Evento");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Lugar).HasMaxLength(150);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
