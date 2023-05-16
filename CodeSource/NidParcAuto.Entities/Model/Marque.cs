using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Marque")]
public partial class Marque
{
    [Key]
    [Column("id_marque")]
    public int IdMarque { get; set; }

    [Column("libMarque")]
    [StringLength(150)]
    [Unicode(false)]
    public string? LibMarque { get; set; }

    [Column("IDModele")]
    public int? Idmodele { get; set; }

    [ForeignKey("Idmodele")]
    [InverseProperty("Marques")]
    public virtual Modele? IdmodeleNavigation { get; set; }

    [InverseProperty("IdmarqueNavigation")]
    public virtual ICollection<Vehicule> Vehicules { get; set; } = new List<Vehicule>();
}
