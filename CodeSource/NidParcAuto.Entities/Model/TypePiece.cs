using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Type_piece")]
public partial class TypePiece
{
    [Key]
    [Column("id_type_piece")]
    public int IdTypePiece { get; set; }

    [Column("lib_type_piece")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LibTypePiece { get; set; }

    [InverseProperty("IdtypePieceNavigation")]
    public virtual ICollection<DocumentVehicule> DocumentVehicules { get; set; } = new List<DocumentVehicule>();
}
