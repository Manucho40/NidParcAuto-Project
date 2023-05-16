using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("ETAT_VEHICULE")]
public partial class EtatVehicule
{
    [Key]
    [Column("_ID")]
    public int Id { get; set; }

    [Column("description")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("date", TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("IDVehicule")]
    public int? Idvehicule { get; set; }

    [Column("IDEtat")]
    public int? Idetat { get; set; }

    [ForeignKey("Idetat")]
    [InverseProperty("EtatVehicules")]
    public virtual Etat? IdetatNavigation { get; set; }

    [ForeignKey("Idvehicule")]
    [InverseProperty("EtatVehicules")]
    public virtual Vehicule? IdvehiculeNavigation { get; set; }
}
