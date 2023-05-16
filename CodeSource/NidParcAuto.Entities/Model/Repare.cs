using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Repare")]
public partial class Repare
{
    [Key]
    [Column("id_repare")]
    public int IdRepare { get; set; }

    [Column("dateEntree", TypeName = "datetime")]
    public DateTime? DateEntree { get; set; }

    [Column("dateSortie", TypeName = "datetime")]
    public DateTime? DateSortie { get; set; }

    [Column("coutReparation", TypeName = "money")]
    public decimal? CoutReparation { get; set; }

    [Column("IDVehicule")]
    public int? Idvehicule { get; set; }

    [Column("IDDetailReparation")]
    public int? IddetailReparation { get; set; }

    [Column("IDReparateur")]
    public int? Idreparateur { get; set; }

    [ForeignKey("IddetailReparation")]
    [InverseProperty("Repares")]
    public virtual DetailReparation? IddetailReparationNavigation { get; set; }

    [ForeignKey("Idreparateur")]
    [InverseProperty("Repares")]
    public virtual Reparateur? IdreparateurNavigation { get; set; }

    [ForeignKey("Idvehicule")]
    [InverseProperty("Repares")]
    public virtual Vehicule? IdvehiculeNavigation { get; set; }
}
