using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Reparateur")]
public partial class Reparateur
{
    [Key]
    [Column("id_reparateur")]
    public int IdReparateur { get; set; }

    [Column("libReparateur")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LibReparateur { get; set; }

    [Column("contact", TypeName = "numeric(18, 0)")]
    public decimal? Contact { get; set; }

    [InverseProperty("IdreparateurNavigation")]
    public virtual ICollection<Repare> Repares { get; set; } = new List<Repare>();
}
