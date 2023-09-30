using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ParcialBackend.Models;

public partial class Fg100220Fa100620Context : DbContext
{
    public Fg100220Fa100620Context()
    {
    }

    public Fg100220Fa100620Context(DbContextOptions<Fg100220Fa100620Context> options)
        : base(options)
    {
    }

    public virtual DbSet<VistaElecciones2019> VistaElecciones2019s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=OG-TUF; Database=FG100220_FA100620;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configura el mapeo de la vista
        modelBuilder.Entity<VistaElecciones2019>(entity =>
        {
            entity.HasKey(e => e.Candidato);

            // Indica que esta entidad está mapeada a una vista en lugar de una tabla
            entity.ToView("VistaElecciones2019");

            // Mapea las propiedades de la vista a las propiedades de la entidad
            entity.Property(e => e.Candidato).HasColumnName("Candidato");
            entity.Property(e => e.CantidadDeVotos).HasColumnName("CantidadDeVotos");
            entity.Property(e => e.Porcentaje).HasColumnName("Porcentaje");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
