using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Fonction")]
public partial class Fonction
{
    [Key]
    [Column("id_fonction")]
    public int IdFonction { get; set; }

    [Column("libFonction")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LibFonction { get; set; }

    [Column("IDService")]
    public int? Idservice { get; set; }

    [InverseProperty("IdfonctionNavigation")]
    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();

    [ForeignKey("Idservice")]
    [InverseProperty("Fonctions")]
    public virtual Service? IdserviceNavigation { get; set; }
}
