using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Classe_contravention")]
public partial class ClasseContravention
{
    [Key]
    [Column("id_classe_contravention")]
    public int IdClasseContravention { get; set; }

    [Column("libClasseContravention")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LibClasseContravention { get; set; }

    [InverseProperty("IdclasseContraventionNavigation")]
    public virtual ICollection<Contravention> Contraventions { get; set; } = new List<Contravention>();
}
