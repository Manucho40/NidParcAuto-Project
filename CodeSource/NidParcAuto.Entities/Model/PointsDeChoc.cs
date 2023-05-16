using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Points_de_chocs")]
public partial class PointsDeChoc
{
    [Key]
    [Column("id_points_de_chocs")]
    public int IdPointsDeChocs { get; set; }

    [Column("libPointsDeChocs")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LibPointsDeChocs { get; set; }

    [InverseProperty("IdpointChocsNavigation")]
    public virtual ICollection<Sinistre> Sinistres { get; set; } = new List<Sinistre>();
}
