using System;
using System.Collections.Generic;

namespace NidParcAuto.API.Models;

public partial class Agent
{
    public int IdAgent { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public decimal? Contact { get; set; }

    public string? Mdp { get; set; }

    public DateTime? HeureConnexion { get; set; }

    public DateTime? HeureDeconnexion { get; set; }

    public int? Idfonction { get; set; }

    public int? IdcategoriePermis { get; set; }

    public int? IddotationCarburant { get; set; }

    public decimal IdUser { get; set; }

    public DateTime DateCreation { get; set; }

    public DateTime? ModifieLe { get; set; }

    public decimal? ModifiePar { get; set; }

    public int StateCode { get; set; }

    public int StatusCode { get; set; }

    public virtual ICollection<Detient> Detients { get; set; } = new List<Detient>();

    public virtual CategoriePermi? IdcategoriePermisNavigation { get; set; }

    public virtual DotationCarburant? IddotationCarburantNavigation { get; set; }

    public virtual Fonction? IdfonctionNavigation { get; set; }
}
