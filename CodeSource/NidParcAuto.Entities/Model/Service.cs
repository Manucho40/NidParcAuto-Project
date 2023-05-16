using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Service")]
public partial class Service
{
    [Key]
    [Column("idservice")]
    public int Idservice { get; set; }

    [Column("libService")]
    [MaxLength(150)]
    public byte[]? LibService { get; set; }

    [InverseProperty("IdserviceNavigation")]
    public virtual ICollection<Fonction> Fonctions { get; set; } = new List<Fonction>();
}
