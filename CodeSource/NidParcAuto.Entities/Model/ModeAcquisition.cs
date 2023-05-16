using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Mode_Acquisition")]
public partial class ModeAcquisition
{
    [Key]
    [Column("id_mode_acquisition")]
    public int IdModeAcquisition { get; set; }

    [Column("libModeAcquisition")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LibModeAcquisition { get; set; }

    [InverseProperty("IdmodeAquisitionNavigation")]
    public virtual ICollection<Vehicule> Vehicules { get; set; } = new List<Vehicule>();
}
