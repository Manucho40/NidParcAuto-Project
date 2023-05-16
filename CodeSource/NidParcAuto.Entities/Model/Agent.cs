using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Agent")]
public partial class Agent
{
    [Key]
    [Column("id_agent")]
    public int IdAgent { get; set; }

    [Column("nom")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nom { get; set; }

    [Column("prenom")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Prenom { get; set; }

    [Column("contact", TypeName = "numeric(18, 0)")]
    public decimal? Contact { get; set; }

    [Column("mdp")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Mdp { get; set; }

    [Column("heureConnexion", TypeName = "datetime")]
    public DateTime? HeureConnexion { get; set; }

    [Column("heureDeconnexion", TypeName = "datetime")]
    public DateTime? HeureDeconnexion { get; set; }

    [Column("IDFonction")]
    public int? Idfonction { get; set; }

    [Column("IDCategoriePermis")]
    public int? IdcategoriePermis { get; set; }

    [Column("IDDotationCarburant")]
    public int? IddotationCarburant { get; set; }

    [InverseProperty("IdagentNavigation")]
    public virtual ICollection<Detient> Detients { get; set; } = new List<Detient>();

    [ForeignKey("IdcategoriePermis")]
    [InverseProperty("Agents")]
    public virtual CategoriePermi? IdcategoriePermisNavigation { get; set; }

    [ForeignKey("IddotationCarburant")]
    [InverseProperty("Agents")]
    public virtual DotationCarburant? IddotationCarburantNavigation { get; set; }

    [ForeignKey("Idfonction")]
    [InverseProperty("Agents")]
    public virtual Fonction? IdfonctionNavigation { get; set; }
}
