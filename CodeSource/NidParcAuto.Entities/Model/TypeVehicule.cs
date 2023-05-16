using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Type_vehicule")]
public partial class TypeVehicule
{
    [Key]
    [Column("id_type_vehicule")]
    public int IdTypeVehicule { get; set; }

    [Column("libTypeVehicule")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LibTypeVehicule { get; set; }

    [InverseProperty("IdtypeVehiculeNavigation")]
    public virtual ICollection<Modele> Modeles { get; set; } = new List<Modele>();
}
