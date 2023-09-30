﻿using System;
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

    public virtual DbSet<Elecciones2019> Elecciones2019s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CC5-14\\SQLEXPRESS; Database=FG100220_FA100620;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Elecciones2019>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__eleccion__3213E83F6CF45B34");

            entity.ToTable("elecciones_2019");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Candidato)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("candidato");
            entity.Property(e => e.Departamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("departamento");
            entity.Property(e => e.Votos).HasColumnName("votos");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
