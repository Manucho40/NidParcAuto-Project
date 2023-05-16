using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Detient")]
public partial class Detient
{
    [Key]
    [Column("id_detient")]
    public int IdDetient { get; set; }

    [Column("dateDebut", TypeName = "date")]
    public DateTime? DateDebut { get; set; }

    [Column("dateFin", TypeName = "date")]
    public DateTime? DateFin { get; set; }

    [Column("IDVehicule")]
    public int? Idvehicule { get; set; }

    [Column("IDAgent")]
    public int? Idagent { get; set; }

    [ForeignKey("Idagent")]
    [InverseProperty("Detients")]
    public virtual Agent? IdagentNavigation { get; set; }

    [ForeignKey("Idvehicule")]
    [InverseProperty("Detients")]
    public virtual Vehicule? IdvehiculeNavigation { get; set; }
}
