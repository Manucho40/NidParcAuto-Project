using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NidParcAuto.API.Model;

[Table("Document_Vehicule")]
public partial class DocumentVehicule
{
    [Key]
    [Column("id_document_vehicule")]
    public int IdDocumentVehicule { get; set; }

    [Column("numeroDocument")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NumeroDocument { get; set; }

    [Column("dateEdition", TypeName = "date")]
    public DateTime? DateEdition { get; set; }

    [Column("dateExpiration", TypeName = "date")]
    public DateTime? DateExpiration { get; set; }

    [Column("coutDocument", TypeName = "money")]
    public decimal? CoutDocument { get; set; }

    [Column("IDVehicule")]
    public int? Idvehicule { get; set; }

    [Column("IDTypePiece")]
    public int? IdtypePiece { get; set; }

    [ForeignKey("IdtypePiece")]
    [InverseProperty("DocumentVehicules")]
    public virtual TypePiece? IdtypePieceNavigation { get; set; }

    [ForeignKey("Idvehicule")]
    [InverseProperty("DocumentVehicules")]
    public virtual Vehicule? IdvehiculeNavigation { get; set; }
}
