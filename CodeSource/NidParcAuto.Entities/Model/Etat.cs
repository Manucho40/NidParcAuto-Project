using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Etat")]
public partial class Etat
{
    [Key]
    [Column("id_etat")]
    public int IdEtat { get; set; }

    [Column("libEtat")]
    [MaxLength(50)]
    public byte[]? LibEtat { get; set; }

    [InverseProperty("IdetatNavigation")]
    public virtual ICollection<EtatVehicule> EtatVehicules { get; set; } = new List<EtatVehicule>();
}
