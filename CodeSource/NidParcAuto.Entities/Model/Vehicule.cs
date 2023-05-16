using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Vehicule")]
public partial class Vehicule
{
    [Key]
    [Column("id_vehicule")]
    public int IdVehicule { get; set; }

    [Column("immatriculation")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Immatriculation { get; set; }

    [Column("numeroSerie")]
    [StringLength(17)]
    [Unicode(false)]
    public string? NumeroSerie { get; set; }

    [Column("puissanceFiscale")]
    [StringLength(10)]
    [Unicode(false)]
    public string? PuissanceFiscale { get; set; }

    [Column("dateMiseEnCirculation", TypeName = "date")]
    public DateTime? DateMiseEnCirculation { get; set; }

    [Column("dateAcquisition", TypeName = "date")]
    public DateTime? DateAcquisition { get; set; }

    [Column("IDEnergie")]
    public int? Idenergie { get; set; }

    [Column("IDMarque")]
    public int? Idmarque { get; set; }

    [Column("IDModeAquisition")]
    public int? IdmodeAquisition { get; set; }

    [InverseProperty("IdvehiculeNavigation")]
    public virtual ICollection<Detient> Detients { get; set; } = new List<Detient>();

    [InverseProperty("IdvehiculeNavigation")]
    public virtual ICollection<DocumentVehicule> DocumentVehicules { get; set; } = new List<DocumentVehicule>();

    [InverseProperty("IdvehiculeNavigation")]
    public virtual ICollection<EtatVehicule> EtatVehicules { get; set; } = new List<EtatVehicule>();

    [ForeignKey("Idenergie")]
    [InverseProperty("Vehicules")]
    public virtual Energie? IdenergieNavigation { get; set; }

    [ForeignKey("Idmarque")]
    [InverseProperty("Vehicules")]
    public virtual Marque? IdmarqueNavigation { get; set; }

    [ForeignKey("IdmodeAquisition")]
    [InverseProperty("Vehicules")]
    public virtual ModeAcquisition? IdmodeAquisitionNavigation { get; set; }

    [InverseProperty("IdvehiculeNavigation")]
    public virtual ICollection<InfractionRoutiere> InfractionRoutieres { get; set; } = new List<InfractionRoutiere>();

    [InverseProperty("IdvehiculeNavigation")]
    public virtual ICollection<Repare> Repares { get; set; } = new List<Repare>();
}
