using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Models;

public partial class DbNidParcAutoContext : DbContext
{
    public DbNidParcAutoContext()
    {
    }

    public DbNidParcAutoContext(DbContextOptions<DbNidParcAutoContext> options)
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
        => optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER2022;Database=DbNidParcAuto;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<Agent>(entity =>
        {
            entity.HasKey(e => e.IdAgent);

            entity.ToTable("Agent");

            entity.Property(e => e.IdAgent).HasColumnName("id_agent");
            entity.Property(e => e.Contact)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("contact");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.HeureConnexion)
                .HasColumnType("datetime")
                .HasColumnName("heureConnexion");
            entity.Property(e => e.HeureDeconnexion)
                .HasColumnType("datetime")
                .HasColumnName("heureDeconnexion");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdcategoriePermis).HasColumnName("IDCategoriePermis");
            entity.Property(e => e.IddotationCarburant).HasColumnName("IDDotationCarburant");
            entity.Property(e => e.Idfonction).HasColumnName("IDFonction");
            entity.Property(e => e.Mdp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mdp");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prenom");

            entity.HasOne(d => d.IdcategoriePermisNavigation).WithMany(p => p.Agents)
                .HasForeignKey(d => d.IdcategoriePermis)
                .HasConstraintName("FK_Agent_Categorie_permis");

            entity.HasOne(d => d.IddotationCarburantNavigation).WithMany(p => p.Agents)
                .HasForeignKey(d => d.IddotationCarburant)
                .HasConstraintName("FK_Agent_Dotation_carburant");

            entity.HasOne(d => d.IdfonctionNavigation).WithMany(p => p.Agents)
                .HasForeignKey(d => d.Idfonction)
                .HasConstraintName("FK_Agent_Fonction");
        });

        modelBuilder.Entity<CategoriePermi>(entity =>
        {
            entity.HasKey(e => e.IdCategoriePermis);

            entity.ToTable("Categorie_permis");

            entity.Property(e => e.IdCategoriePermis).HasColumnName("id_categorie_permis");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibCategoriePermis)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("libCategoriePermis");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<ClasseContravention>(entity =>
        {
            entity.HasKey(e => e.IdClasseContravention);

            entity.ToTable("Classe_contravention");

            entity.Property(e => e.IdClasseContravention).HasColumnName("id_classe_contravention");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibClasseContravention)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("libClasseContravention");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<Commune>(entity =>
        {
            entity.HasKey(e => e.IdCommune);

            entity.ToTable("Commune");

            entity.Property(e => e.IdCommune).HasColumnName("id_commune");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibCommune)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("libCommune");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<Contravention>(entity =>
        {
            entity.HasKey(e => e.IdContravention);

            entity.ToTable("Contravention");

            entity.Property(e => e.IdContravention).HasColumnName("id_contravention");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdclasseContravention).HasColumnName("IDClasseContravention");
            entity.Property(e => e.LibContravention)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("libContravention");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");

            entity.HasOne(d => d.IdclasseContraventionNavigation).WithMany(p => p.Contraventions)
                .HasForeignKey(d => d.IdclasseContravention)
                .HasConstraintName("FK_Contravention_Classe_contravention");
        });

        modelBuilder.Entity<DetailReparation>(entity =>
        {
            entity.HasKey(e => e.IdDetailReparation);

            entity.ToTable("Detail_reparation");

            entity.Property(e => e.IdDetailReparation).HasColumnName("id_detail_reparation");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibDetailReparation)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("libDetailReparation");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<Detient>(entity =>
        {
            entity.HasKey(e => e.IdDetient);

            entity.ToTable("Detient");

            entity.Property(e => e.IdDetient).HasColumnName("id_detient");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateDebut)
                .HasColumnType("date")
                .HasColumnName("dateDebut");
            entity.Property(e => e.DateFin)
                .HasColumnType("date")
                .HasColumnName("dateFin");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Idagent).HasColumnName("IDAgent");
            entity.Property(e => e.Idvehicule).HasColumnName("IDVehicule");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");

            entity.HasOne(d => d.IdagentNavigation).WithMany(p => p.Detients)
                .HasForeignKey(d => d.Idagent)
                .HasConstraintName("FK_Detient_Agent");

            entity.HasOne(d => d.IdvehiculeNavigation).WithMany(p => p.Detients)
                .HasForeignKey(d => d.Idvehicule)
                .HasConstraintName("FK_Detient_Vehicule");
        });

        modelBuilder.Entity<DocumentVehicule>(entity =>
        {
            entity.HasKey(e => e.IdDocumentVehicule);

            entity.ToTable("Document_Vehicule");

            entity.Property(e => e.IdDocumentVehicule).HasColumnName("id_document_vehicule");
            entity.Property(e => e.CoutDocument)
                .HasColumnType("money")
                .HasColumnName("coutDocument");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateEdition)
                .HasColumnType("date")
                .HasColumnName("dateEdition");
            entity.Property(e => e.DateExpiration)
                .HasColumnType("date")
                .HasColumnName("dateExpiration");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdtypePiece).HasColumnName("IDTypePiece");
            entity.Property(e => e.Idvehicule).HasColumnName("IDVehicule");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NumeroDocument)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numeroDocument");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");

            entity.HasOne(d => d.IdtypePieceNavigation).WithMany(p => p.DocumentVehicules)
                .HasForeignKey(d => d.IdtypePiece)
                .HasConstraintName("FK_Document_Vehicule_Type_piece");

            entity.HasOne(d => d.IdvehiculeNavigation).WithMany(p => p.DocumentVehicules)
                .HasForeignKey(d => d.Idvehicule)
                .HasConstraintName("FK_Document_Vehicule_Vehicule");
        });

        modelBuilder.Entity<DotationCarburant>(entity =>
        {
            entity.HasKey(e => e.IdDotationCarburant).HasName("PK_Dotattion_carburant");

            entity.ToTable("Dotation_carburant");

            entity.Property(e => e.IdDotationCarburant).HasColumnName("id_dotation_carburant");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DebutRechargement)
                .HasColumnType("datetime")
                .HasColumnName("debutRechargement");
            entity.Property(e => e.FinRechargement)
                .HasColumnType("datetime")
                .HasColumnName("finRechargement");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Idagent).HasColumnName("IDAgent");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Montant)
                .HasColumnType("money")
                .HasColumnName("montant");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<Energie>(entity =>
        {
            entity.HasKey(e => e.IdEnergie);

            entity.ToTable("Energie");

            entity.Property(e => e.IdEnergie).HasColumnName("id_energie");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibEnergie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("libEnergie");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<Etat>(entity =>
        {
            entity.HasKey(e => e.IdEtat);

            entity.ToTable("Etat");

            entity.Property(e => e.IdEtat).HasColumnName("id_etat");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibEtat)
                .HasMaxLength(50)
                .HasColumnName("libEtat");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<EtatVehicule>(entity =>
        {
            entity.ToTable("ETAT_VEHICULE");

            entity.Property(e => e.Id).HasColumnName("_ID");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Idetat).HasColumnName("IDEtat");
            entity.Property(e => e.Idvehicule).HasColumnName("IDVehicule");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");

            entity.HasOne(d => d.IdetatNavigation).WithMany(p => p.EtatVehicules)
                .HasForeignKey(d => d.Idetat)
                .HasConstraintName("FK_ETAT_VEHICULE_Etat");

            entity.HasOne(d => d.IdvehiculeNavigation).WithMany(p => p.EtatVehicules)
                .HasForeignKey(d => d.Idvehicule)
                .HasConstraintName("FK_ETAT_VEHICULE_Vehicule");
        });

        modelBuilder.Entity<Fonction>(entity =>
        {
            entity.HasKey(e => e.IdFonction);

            entity.ToTable("Fonction");

            entity.Property(e => e.IdFonction).HasColumnName("id_fonction");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Idservice).HasColumnName("IDService");
            entity.Property(e => e.LibFonction)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("libFonction");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");

            entity.HasOne(d => d.IdserviceNavigation).WithMany(p => p.Fonctions)
                .HasForeignKey(d => d.Idservice)
                .HasConstraintName("FK_Fonction_Service");
        });

        modelBuilder.Entity<InfractionRoutiere>(entity =>
        {
            entity.HasKey(e => e.IdInfractionRoutiere);

            entity.ToTable("Infraction_routiere");

            entity.Property(e => e.IdInfractionRoutiere).HasColumnName("id_infraction_routiere");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateInfraction)
                .HasColumnType("datetime")
                .HasColumnName("dateInfraction");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Idcommune).HasColumnName("IDCommune");
            entity.Property(e => e.Idcontravention).HasColumnName("IDContravention");
            entity.Property(e => e.Idvehicule).HasColumnName("IDVehicule");
            entity.Property(e => e.LieuExact)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lieuExact");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Montant)
                .HasColumnType("money")
                .HasColumnName("montant");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");

            entity.HasOne(d => d.IdcommuneNavigation).WithMany(p => p.InfractionRoutieres)
                .HasForeignKey(d => d.Idcommune)
                .HasConstraintName("FK_Infraction_routiere_Commune");

            entity.HasOne(d => d.IdcontraventionNavigation).WithMany(p => p.InfractionRoutieres)
                .HasForeignKey(d => d.Idcontravention)
                .HasConstraintName("FK_Infraction_routiere_Contravention");

            entity.HasOne(d => d.IdvehiculeNavigation).WithMany(p => p.InfractionRoutieres)
                .HasForeignKey(d => d.Idvehicule)
                .HasConstraintName("FK_Infraction_routiere_Vehicule");
        });

        modelBuilder.Entity<Marque>(entity =>
        {
            entity.HasKey(e => e.IdMarque);

            entity.ToTable("Marque");

            entity.Property(e => e.IdMarque).HasColumnName("id_marque");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Idmodele).HasColumnName("IDModele");
            entity.Property(e => e.LibMarque)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("libMarque");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");

            entity.HasOne(d => d.IdmodeleNavigation).WithMany(p => p.Marques)
                .HasForeignKey(d => d.Idmodele)
                .HasConstraintName("FK_Marque_Modele");
        });

        modelBuilder.Entity<ModeAcquisition>(entity =>
        {
            entity.HasKey(e => e.IdModeAcquisition);

            entity.ToTable("Mode_Acquisition");

            entity.Property(e => e.IdModeAcquisition).HasColumnName("id_mode_acquisition");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibModeAcquisition)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("libModeAcquisition");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<Modele>(entity =>
        {
            entity.HasKey(e => e.IdModele);

            entity.ToTable("Modele");

            entity.Property(e => e.IdModele).HasColumnName("id_modele");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdtypeVehicule).HasColumnName("IDTypeVehicule");
            entity.Property(e => e.LibModele)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("libModele");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");

            entity.HasOne(d => d.IdtypeVehiculeNavigation).WithMany(p => p.Modeles)
                .HasForeignKey(d => d.IdtypeVehicule)
                .HasConstraintName("FK_Modele_Type_vehicule");
        });

        modelBuilder.Entity<PieceTouchee>(entity =>
        {
            entity.HasKey(e => e.IdPieceTouchee);

            entity.ToTable("Piece_touchee");

            entity.Property(e => e.IdPieceTouchee).HasColumnName("id_piece_touchee");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibPieceTouchee)
                .HasMaxLength(300)
                .HasColumnName("libPieceTouchee");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<PointsDeChoc>(entity =>
        {
            entity.HasKey(e => e.IdPointsDeChocs);

            entity.ToTable("Points_de_chocs");

            entity.Property(e => e.IdPointsDeChocs).HasColumnName("id_points_de_chocs");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibPointsDeChocs)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("libPointsDeChocs");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<Reparateur>(entity =>
        {
            entity.HasKey(e => e.IdReparateur);

            entity.ToTable("Reparateur");

            entity.Property(e => e.IdReparateur).HasColumnName("id_reparateur");
            entity.Property(e => e.Contact)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("contact");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibReparateur)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("libReparateur");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<Repare>(entity =>
        {
            entity.HasKey(e => e.IdRepare);

            entity.ToTable("Repare");

            entity.Property(e => e.IdRepare).HasColumnName("id_repare");
            entity.Property(e => e.CoutReparation)
                .HasColumnType("money")
                .HasColumnName("coutReparation");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateEntree)
                .HasColumnType("datetime")
                .HasColumnName("dateEntree");
            entity.Property(e => e.DateSortie)
                .HasColumnType("datetime")
                .HasColumnName("dateSortie");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IddetailReparation).HasColumnName("IDDetailReparation");
            entity.Property(e => e.Idreparateur).HasColumnName("IDReparateur");
            entity.Property(e => e.Idvehicule).HasColumnName("IDVehicule");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");

            entity.HasOne(d => d.IddetailReparationNavigation).WithMany(p => p.Repares)
                .HasForeignKey(d => d.IddetailReparation)
                .HasConstraintName("FK_Repare_Detail_reparation");

            entity.HasOne(d => d.IdreparateurNavigation).WithMany(p => p.Repares)
                .HasForeignKey(d => d.Idreparateur)
                .HasConstraintName("FK_Repare_Reparateur");

            entity.HasOne(d => d.IdvehiculeNavigation).WithMany(p => p.Repares)
                .HasForeignKey(d => d.Idvehicule)
                .HasConstraintName("FK_Repare_Vehicule");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Idservice);

            entity.ToTable("Service");

            entity.Property(e => e.Idservice).HasColumnName("idservice");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibService)
                .HasMaxLength(150)
                .HasColumnName("libService");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<Sinistre>(entity =>
        {
            entity.HasKey(e => e.IdSinisre);

            entity.ToTable("Sinistre");

            entity.Property(e => e.IdSinisre).HasColumnName("id_sinisre");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateHeure)
                .HasColumnType("datetime")
                .HasColumnName("dateHeure");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdpieceTouche).HasColumnName("IDPieceTouche");
            entity.Property(e => e.IdpointChocs).HasColumnName("IDPointChocs");
            entity.Property(e => e.Idvehicule).HasColumnName("IDVehicule");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");

            entity.HasOne(d => d.IdpointChocsNavigation).WithMany(p => p.Sinistres)
                .HasForeignKey(d => d.IdpointChocs)
                .HasConstraintName("FK_Sinistre_Points_de_chocs");
        });

        modelBuilder.Entity<TypePiece>(entity =>
        {
            entity.HasKey(e => e.IdTypePiece);

            entity.ToTable("Type_piece");

            entity.Property(e => e.IdTypePiece).HasColumnName("id_type_piece");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibTypePiece)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lib_type_piece");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<TypeVehicule>(entity =>
        {
            entity.HasKey(e => e.IdTypeVehicule);

            entity.ToTable("Type_vehicule");

            entity.Property(e => e.IdTypeVehicule).HasColumnName("id_type_vehicule");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.LibTypeVehicule)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("libTypeVehicule");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");
        });

        modelBuilder.Entity<Vehicule>(entity =>
        {
            entity.HasKey(e => e.IdVehicule);

            entity.ToTable("Vehicule");

            entity.Property(e => e.IdVehicule).HasColumnName("id_vehicule");
            entity.Property(e => e.DateAcquisition)
                .HasColumnType("date")
                .HasColumnName("dateAcquisition");
            entity.Property(e => e.DateCreation).HasColumnType("datetime");
            entity.Property(e => e.DateMiseEnCirculation)
                .HasColumnType("date")
                .HasColumnName("dateMiseEnCirculation");
            entity.Property(e => e.IdUser).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Idenergie).HasColumnName("IDEnergie");
            entity.Property(e => e.Idmarque).HasColumnName("IDMarque");
            entity.Property(e => e.IdmodeAquisition).HasColumnName("IDModeAquisition");
            entity.Property(e => e.Immatriculation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("immatriculation");
            entity.Property(e => e.ModifieLe).HasColumnType("datetime");
            entity.Property(e => e.ModifiePar).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.NumeroSerie)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("numeroSerie");
            entity.Property(e => e.PuissanceFiscale)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("puissanceFiscale");
            entity.Property(e => e.StateCode).HasComment("Actif = 1,\r\nPropect = 2,\r\n            Suppression_En_Cour = 3,\r\n            Supprimer = -1,\r\n            Inactif = 0");
            entity.Property(e => e.StatusCode).HasComment("Ouverture = 1,\r\n            Expertise = 2,\r\n            Imprimer = 3,\r\n            Composer = 4,\r\n            Quittance = 5,\r\n            Regler = 6,\r\n            Sorti = 7,\r\n            Cloturer = 8,\r\n            ReSorti = 9");

            entity.HasOne(d => d.IdenergieNavigation).WithMany(p => p.Vehicules)
                .HasForeignKey(d => d.Idenergie)
                .HasConstraintName("FK_Vehicule_Energie");

            entity.HasOne(d => d.IdmarqueNavigation).WithMany(p => p.Vehicules)
                .HasForeignKey(d => d.Idmarque)
                .HasConstraintName("FK_Vehicule_Marque");

            entity.HasOne(d => d.IdmodeAquisitionNavigation).WithMany(p => p.Vehicules)
                .HasForeignKey(d => d.IdmodeAquisition)
                .HasConstraintName("FK_Vehicule_Mode_Acquisition");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
