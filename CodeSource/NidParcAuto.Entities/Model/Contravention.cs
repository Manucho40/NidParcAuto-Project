using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Contravention")]
public partial class Contravention
{
    [Key]
    [Column("id_contravention")]
    public int IdContravention { get; set; }

    [Column("libContravention")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LibContravention { get; set; }

    [Column("IDClasseContravention")]
    public int? IdclasseContravention { get; set; }

    [ForeignKey("IdclasseContravention")]
    [InverseProperty("Contraventions")]
    public virtual ClasseContravention? IdclasseContraventionNavigation { get; set; }

    [InverseProperty("IdcontraventionNavigation")]
    public virtual ICollection<InfractionRoutiere> InfractionRoutieres { get; set; } = new List<InfractionRoutiere>();
}
