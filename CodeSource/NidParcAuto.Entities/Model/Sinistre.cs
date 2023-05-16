using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Sinistre")]
public partial class Sinistre
{
    [Key]
    [Column("id_sinisre")]
    public int IdSinisre { get; set; }

    [Column("dateHeure", TypeName = "datetime")]
    public DateTime? DateHeure { get; set; }

    [Column("IDPointChocs")]
    public int? IdpointChocs { get; set; }

    [Column("IDVehicule")]
    public int? Idvehicule { get; set; }

    [Column("IDPieceTouche")]
    public int? IdpieceTouche { get; set; }

    [ForeignKey("IdpointChocs")]
    [InverseProperty("Sinistres")]
    public virtual PointsDeChoc? IdpointChocsNavigation { get; set; }
}
