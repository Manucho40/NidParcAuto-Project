using System;
using System.Collections.Generic;

namespace NidParcAuto.API.Models;

public partial class Vehicule
{
    public int IdVehicule { get; set; }

    public string? Immatriculation { get; set; }

    public string? NumeroSerie { get; set; }

    public string? PuissanceFiscale { get; set; }

    public DateTime? DateMiseEnCirculation { get; set; }

    public DateTime? DateAcquisition { get; set; }

    public int? Idenergie { get; set; }

    public int? Idmarque { get; set; }

    public int? IdmodeAquisition { get; set; }

    public decimal IdUser { get; set; }

    public DateTime DateCreation { get; set; }

    public DateTime? ModifieLe { get; set; }

    public decimal? ModifiePar { get; set; }

    /// <summary>
    /// Actif = 1,
    /// Propect = 2,
    ///             Suppression_En_Cour = 3,
    ///             Supprimer = -1,
    ///             Inactif = 0
    /// </summary>
    public int StateCode { get; set; }

    /// <summary>
    /// Ouverture = 1,
    ///             Expertise = 2,
    ///             Imprimer = 3,
    ///             Composer = 4,
    ///             Quittance = 5,
    ///             Regler = 6,
    ///             Sorti = 7,
    ///             Cloturer = 8,
    ///             ReSorti = 9
    /// </summary>
    public int StatusCode { get; set; }

    public virtual ICollection<Detient> Detients { get; set; } = new List<Detient>();

    public virtual ICollection<DocumentVehicule> DocumentVehicules { get; set; } = new List<DocumentVehicule>();

    public virtual ICollection<EtatVehicule> EtatVehicules { get; set; } = new List<EtatVehicule>();

    public virtual Energie? IdenergieNavigation { get; set; }

    public virtual Marque? IdmarqueNavigation { get; set; }

    public virtual ModeAcquisition? IdmodeAquisitionNavigation { get; set; }

    public virtual ICollection<InfractionRoutiere> InfractionRoutieres { get; set; } = new List<InfractionRoutiere>();

    public virtual ICollection<Repare> Repares { get; set; } = new List<Repare>();
}
