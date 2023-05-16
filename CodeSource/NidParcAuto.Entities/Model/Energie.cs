using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Energie")]
public partial class Energie
{
    [Key]
    [Column("id_energie")]
    public int IdEnergie { get; set; }

    [Column("libEnergie")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LibEnergie { get; set; }

    [InverseProperty("IdenergieNavigation")]
    public virtual ICollection<Vehicule> Vehicules { get; set; } = new List<Vehicule>();
}
