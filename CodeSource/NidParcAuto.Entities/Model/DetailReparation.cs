using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Detail_reparation")]
public partial class DetailReparation
{
    [Key]
    [Column("id_detail_reparation")]
    public int IdDetailReparation { get; set; }

    [Column("libDetailReparation")]
    [StringLength(250)]
    [Unicode(false)]
    public string? LibDetailReparation { get; set; }

    [InverseProperty("IddetailReparationNavigation")]
    public virtual ICollection<Repare> Repares { get; set; } = new List<Repare>();
}
