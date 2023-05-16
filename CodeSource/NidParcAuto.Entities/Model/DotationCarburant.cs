using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Dotation_carburant")]
public partial class DotationCarburant
{
    [Key]
    [Column("id_dotation_carburant")]
    public int IdDotationCarburant { get; set; }

    [Column("debutRechargement", TypeName = "datetime")]
    public DateTime? DebutRechargement { get; set; }

    [Column("finRechargement", TypeName = "datetime")]
    public DateTime? FinRechargement { get; set; }

    [Column("montant", TypeName = "money")]
    public decimal? Montant { get; set; }

    [Column("IDAgent")]
    public int? Idagent { get; set; }

    [InverseProperty("IddotationCarburantNavigation")]
    public virtual ICollection<Agent> Agents { get; set; } = new List<Agent>();
}
