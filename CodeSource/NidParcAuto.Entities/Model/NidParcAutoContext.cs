using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

public partial class NidParcAutoContext : DbContext
{
    public NidParcAutoContext()
    {
    }

    public NidParcAutoContext(DbContextOptions<NidParcAutoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<CategoriePermi> CategoriePermis { get; set; }

    public virtual DbSet<ClasseContravention> ClasseContraventions { get; set; }

    public virtual DbSet<Commune> Communes { get; set; }

    public virtual DbSet<Contravention> Contraventions { get; set; }

    public virtual DbSet<DetailReparation> DetailReparations { get; set; }

    public virtual DbSet<Detient> Detients { get; set; }

    public virtual DbSet<DocumentVehicule> DocumentVehicules { get; set; }

    public virtual DbSet<DotationCarburant> DotationCarburants { get; set; }

    public virtual DbSet<Energie> Energies { get; set; }

    public virtual DbSet<Etat> Etats { get; set; }

    public virtual DbSet<EtatVehicule> EtatVehicules { get; set; }

    public virtual DbSet<Fonction> Fonctions { get; set; }

    public virtual DbSet<InfractionRoutiere> InfractionRoutieres { get; set; }

    public virtual DbSet<Marque> Marques { get; set; }

    public virtual DbSet<ModeAcquisition> ModeAcquisitions { get; set; }

    public virtual DbSet<Modele> Modeles { get; set; }

    public virtual DbSet<PieceTouchee> PieceTouchees { get; set; }

    public virtual DbSet<PointsDeChoc> PointsDeChocs { get; set; }

    public virtual DbSet<Reparateur> Reparateurs { get; set; }

    public virtual DbSet<Repare> Repares { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Sinistre> Sinistres { get; set; }

    public virtual DbSet<TypePiece> TypePieces { get; set; }

    public virtual DbSet<TypeVehicule> TypeVehicules { get; set; }

    public virtual DbSet<Vehicule> Vehicules { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\;Database=FLOTTE_AUTO_CABINETNID;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasOne(d => d.IdcategoriePermisNavigation).WithMany(p => p.Agents).HasConstraintName("FK_Agent_Categorie_permis");

            entity.HasOne(d => d.IddotationCarburantNavigation).WithMany(p => p.Agents).HasConstraintName("FK_Agent_Dotation_carburant");

            entity.HasOne(d => d.IdfonctionNavigation).WithMany(p => p.Agents).HasConstraintName("FK_Agent_Fonction");
        });

        modelBuilder.Entity<Contravention>(entity =>
        {
            entity.HasOne(d => d.IdclasseContraventionNavigation).WithMany(p => p.Contraventions).HasConstraintName("FK_Contravention_Classe_contravention");
        });

        modelBuilder.Entity<Detient>(entity =>
        {
            entity.HasOne(d => d.IdagentNavigation).WithMany(p => p.Detients).HasConstraintName("FK_Detient_Agent");

            entity.HasOne(d => d.IdvehiculeNavigation).WithMany(p => p.Detients).HasConstraintName("FK_Detient_Vehicule");
        });

        modelBuilder.Entity<DocumentVehicule>(entity =>
        {
            entity.HasOne(d => d.IdtypePieceNavigation).WithMany(p => p.DocumentVehicules).HasConstraintName("FK_Document_Vehicule_Type_piece");

            entity.HasOne(d => d.IdvehiculeNavigation).WithMany(p => p.DocumentVehicules).HasConstraintName("FK_Document_Vehicule_Vehicule");
        });

        modelBuilder.Entity<DotationCarburant>(entity =>
        {
            entity.HasKey(e => e.IdDotationCarburant).HasName("PK_Dotattion_carburant");
        });

        modelBuilder.Entity<EtatVehicule>(entity =>
        {
            entity.HasOne(d => d.IdetatNavigation).WithMany(p => p.EtatVehicules).HasConstraintName("FK_ETAT_VEHICULE_Etat");

            entity.HasOne(d => d.IdvehiculeNavigation).WithMany(p => p.EtatVehicules).HasConstraintName("FK_ETAT_VEHICULE_Vehicule");
        });

        modelBuilder.Entity<Fonction>(entity =>
        {
            entity.HasOne(d => d.IdserviceNavigation).WithMany(p => p.Fonctions).HasConstraintName("FK_Fonction_Service");
        });

        modelBuilder.Entity<InfractionRoutiere>(entity =>
        {
            entity.HasOne(d => d.IdcommuneNavigation).WithMany(p => p.InfractionRoutieres).HasConstraintName("FK_Infraction_routiere_Commune");

            entity.HasOne(d => d.IdcontraventionNavigation).WithMany(p => p.InfractionRoutieres).HasConstraintName("FK_Infraction_routiere_Contravention");

            entity.HasOne(d => d.IdvehiculeNavigation).WithMany(p => p.InfractionRoutieres).HasConstraintName("FK_Infraction_routiere_Vehicule");
        });

        modelBuilder.Entity<Marque>(entity =>
        {
            entity.HasOne(d => d.IdmodeleNavigation).WithMany(p => p.Marques).HasConstraintName("FK_Marque_Modele");
        });

        modelBuilder.Entity<Modele>(entity =>
        {
            entity.HasOne(d => d.IdtypeVehiculeNavigation).WithMany(p => p.Modeles).HasConstraintName("FK_Modele_Type_vehicule");
        });

        modelBuilder.Entity<Repare>(entity =>
        {
            entity.HasOne(d => d.IddetailReparationNavigation).WithMany(p => p.Repares).HasConstraintName("FK_Repare_Detail_reparation");

            entity.HasOne(d => d.IdreparateurNavigation).WithMany(p => p.Repares).HasConstraintName("FK_Repare_Reparateur");

            entity.HasOne(d => d.IdvehiculeNavigation).WithMany(p => p.Repares).HasConstraintName("FK_Repare_Vehicule");
        });

        modelBuilder.Entity<Sinistre>(entity =>
        {
            entity.HasOne(d => d.IdpointChocsNavigation).WithMany(p => p.Sinistres).HasConstraintName("FK_Sinistre_Points_de_chocs");
        });

        modelBuilder.Entity<Vehicule>(entity =>
        {
            entity.HasOne(d => d.IdenergieNavigation).WithMany(p => p.Vehicules).HasConstraintName("FK_Vehicule_Energie");

            entity.HasOne(d => d.IdmarqueNavigation).WithMany(p => p.Vehicules).HasConstraintName("FK_Vehicule_Marque");

            entity.HasOne(d => d.IdmodeAquisitionNavigation).WithMany(p => p.Vehicules).HasConstraintName("FK_Vehicule_Mode_Acquisition");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
