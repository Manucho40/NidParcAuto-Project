using System;
using System.Collections.Generic;

namespace NidParcAuto.API.Models;

public partial class Marque
{
    public int IdMarque { get; set; }

    public string? LibMarque { get; set; }

    public int? Idmodele { get; set; }

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

    public virtual Modele? IdmodeleNavigation { get; set; }

    public virtual ICollection<Vehicule> Vehicules { get; set; } = new List<Vehicule>();
}
