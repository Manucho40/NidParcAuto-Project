using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Commune")]
public partial class Commune
{
    [Key]
    [Column("id_commune")]
    public int IdCommune { get; set; }

    [Column("libCommune")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LibCommune { get; set; }

    [InverseProperty("IdcommuneNavigation")]
    public virtual ICollection<InfractionRoutiere> InfractionRoutieres { get; set; } = new List<InfractionRoutiere>();
}
