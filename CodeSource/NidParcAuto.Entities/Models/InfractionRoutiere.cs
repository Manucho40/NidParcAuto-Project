using System;
using System.Collections.Generic;

namespace NidParcAuto.API.Models;

public partial class InfractionRoutiere
{
    public int IdInfractionRoutiere { get; set; }

    public DateTime? DateInfraction { get; set; }

    public decimal? Montant { get; set; }

    public string? LieuExact { get; set; }

    public int? Idcontravention { get; set; }

    public int? Idvehicule { get; set; }

    public int? Idcommune { get; set; }

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

    public virtual Commune? IdcommuneNavigation { get; set; }

    public virtual Contravention? IdcontraventionNavigation { get; set; }

    public virtual Vehicule? IdvehiculeNavigation { get; set; }
}
