using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Categorie_permis")]
public partial class CategoriePermi
{
    [Key]
    [Column("id_categorie_permis")]
    public int IdCategoriePermis { get; set; }

    [Column("libCategoriePermis")]
    [StringLength(11)]
    [Unicode(false)]
    public string? LibCategoriePermis { get; set; }

    [InverseProperty("IdcategoriePermisNavigation")]
    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();
}
