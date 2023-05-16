using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Piece_touchee")]
public partial class PieceTouchee
{
    [Key]
    [Column("id_piece_touchee")]
    public int IdPieceTouchee { get; set; }

    [Column("libPieceTouchee")]
    [MaxLength(300)]
    public byte[]? LibPieceTouchee { get; set; }
}
