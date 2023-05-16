using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Modele")]
public partial class Modele
{
    [Key]
    [Column("id_modele")]
    public int IdModele { get; set; }

    [Column("libModele")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LibModele { get; set; }

    [Column("IDTypeVehicule")]
    public int? IdtypeVehicule { get; set; }

    [ForeignKey("IdtypeVehicule")]
    [InverseProperty("Modeles")]
    public virtual TypeVehicule? IdtypeVehiculeNavigation { get; set; }

    [InverseProperty("IdmodeleNavigation")]
    public virtual ICollection<Marque> Marques { get; set; } = new List<Marque>();
}
