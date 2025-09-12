using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using webgis.Models;

namespace webgis.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Axe> Axes { get; set; }

    public virtual DbSet<DecoupageAdministratif> DecoupageAdministratifs { get; set; }

    public virtual DbSet<Emprise> Emprises { get; set; }

    public virtual DbSet<Equipement> Equipements { get; set; }

    public virtual DbSet<FrontBati> FrontBatis { get; set; }

    public virtual DbSet<SDAU> SDAUs { get; set; }

    public virtual DbSet<Secteur> Secteurs { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<Voirie> Voiries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresExtension("postgis")
            .HasPostgresExtension("topology", "postgis_topology");

        modelBuilder.Entity<Axe>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Axe_pkey");

            entity.HasIndex(e => e.geom, "sidx_Axe_geom").HasMethod("gist");
        });

        modelBuilder.Entity<DecoupageAdministratif>(entity =>
        {
            entity.HasKey(e => e.id).HasName("DecoupageAdministratif_pkey");

            entity.HasIndex(e => e.geom, "sidx_DecoupageAdministratif_geom").HasMethod("gist");
        });

        modelBuilder.Entity<Emprise>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Emprise_pkey");

            entity.HasIndex(e => e.geom, "sidx_Emprise_geom").HasMethod("gist");
        });

        modelBuilder.Entity<Equipement>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Equipements_pkey");

            entity.HasIndex(e => e.geom, "sidx_Equipements_geom").HasMethod("gist");
        });

        modelBuilder.Entity<FrontBati>(entity =>
        {
            entity.HasKey(e => e.id).HasName("FrontBati_pkey");

            entity.HasIndex(e => e.geom, "sidx_FrontBati_geom").HasMethod("gist");
        });

        modelBuilder.Entity<SDAU>(entity =>
        {
            entity.HasKey(e => e.id).HasName("SDAU_pkey");

            entity.HasIndex(e => e.geom, "sidx_SDAU_geom").HasMethod("gist");
        });

        modelBuilder.Entity<Secteur>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Secteur_pkey");

            entity.HasIndex(e => e.geom, "sidx_Secteur_geom").HasMethod("gist");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Sites_pkey");

            entity.HasIndex(e => e.geom, "sidx_Sites_geom").HasMethod("gist");
        });

        modelBuilder.Entity<Voirie>(entity =>
        {
            entity.HasKey(e => e.id).HasName("Voirie_pkey");

            entity.HasIndex(e => e.geom, "sidx_Voirie_geom").HasMethod("gist");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
