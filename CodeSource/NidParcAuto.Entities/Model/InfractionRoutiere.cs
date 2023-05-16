using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Infraction_routiere")]
public partial class InfractionRoutiere
{
    [Key]
    [Column("id_infraction_routiere")]
    public int IdInfractionRoutiere { get; set; }

    [Column("dateInfraction", TypeName = "datetime")]
    public DateTime? DateInfraction { get; set; }

    [Column("montant", TypeName = "money")]
    public decimal? Montant { get; set; }

    [Column("lieuExact")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LieuExact { get; set; }

    [Column("IDContravention")]
    public int? Idcontravention { get; set; }

    [Column("IDVehicule")]
    public int? Idvehicule { get; set; }

    [Column("IDCommune")]
    public int? Idcommune { get; set; }

    [ForeignKey("Idcommune")]
    [InverseProperty("InfractionRoutieres")]
    public virtual Commune? IdcommuneNavigation { get; set; }

    [ForeignKey("Idcontravention")]
    [InverseProperty("InfractionRoutieres")]
    public virtual Contravention? IdcontraventionNavigation { get; set; }

    [ForeignKey("Idvehicule")]
    [InverseProperty("InfractionRoutieres")]
    public virtual Vehicule? IdvehiculeNavigation { get; set; }
}
