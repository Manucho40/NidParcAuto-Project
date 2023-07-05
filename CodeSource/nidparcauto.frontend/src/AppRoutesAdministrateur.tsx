import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import AdDashboard from './pages/administrateur/AdDashboard';
import AttributionVehicule from './pages/administrateur/gestion/AttributionVehicule';
import ReparationVehicule from './pages/administrateur/gestion/ReparationVehicule';
import Documents from './pages/administrateur/gestion/Documents';
import DotationCarburant from './pages/administrateur/gestion/DotationCarburant';
import EntretienVehicule from './pages/administrateur/gestion/EntretienVehicule';
import EtatVehicules from './pages/administrateur/etats/EtatVehicules';
import MatriceCouts from './pages/administrateur/etats/MatriceCouts';
import EtatCarburant from './pages/administrateur/etats/EtatCarburant';
import EtatPannes from './pages/administrateur/etats/EtatPannes';
import EtatSinistres from './pages/administrateur/etats/EtatSinistres';
import EtatContraventions from './pages/administrateur/etats/EtatContraventions';
import ParamEnergie from './pages/administrateur/param/ParamEnergie';
import ParamMarque from './pages/administrateur/param/ParamMarque';
import ParamModele from './pages/administrateur/param/ParamModele';
import ParamTypeVehicule from './pages/administrateur/param/ParamTypeVehicule';
import ParamFonction from './pages/administrateur/param/ParamFonction';
import ParamService from './pages/administrateur/param/ParamService';
import ParamPointsChocs from './pages/administrateur/param/ParamPointsChocs';
import ParamTypePiece from './pages/administrateur/param/ParamTypePiece';










const AppRoutesAdministrateur = [
    {
        index: true,
        element: <AdDashboard />
    },
    {
        path: '/attribution-vehicule',
        element: <AttributionVehicule />
    },
    {
        path: '/reparation-vehicule',
        element: <ReparationVehicule />
    },
    {
        path: '/documents',
        element: <Documents />
    },
    {
        path: '/dotation-carburant',
        element: <DotationCarburant />
    },
    {
        path: '/entretien-vehicule',
        element: <EntretienVehicule />
    },
    {
        path: '/etat-vehicules',
        element: <EtatVehicules />
    },
    {
        path: '/matrice-des-couts',
        element: <MatriceCouts />
    },
    {
        path: '/etat-carubrant',
        element: <EtatCarburant />
    },
    {
        path: '/etat-pannes',
        element: <EtatPannes />
    },
    {
        path: '/etat-sinistres',
        element: <EtatSinistres />
    },
    {
        path: '/etat-contraventions',
        element: <EtatContraventions />
    },
    {
        path: '/param-energie',
        element: <ParamEnergie />
    },
    {
        path: '/param-marque',
        element: <ParamMarque />
    },
    {
        path: '/param-modele',
        element: <ParamModele />
    },
    {
        path: '/param-type-vehicule',
        element: <ParamTypeVehicule />
    },
    {
        path: '/param-fonction',
        element: <ParamFonction />
    },
    {
        path: '/param-service',
        element: <ParamService />
    },
    {
        path: '/param-points-chocs',
        element: <ParamPointsChocs />
    },
    {
        path: '/param-type-piece',
        element: <ParamTypePiece />
    },
    //{
    //  index: true,
    //  element: <Home />
    //},
    //{
    //  path: '/counter',
    //  element: <Counter />
    //},
    //{
    //  path: '/fetch-data',
    //  requireAuth: true,
    //  element: <FetchData />
    //},
    ...ApiAuthorzationRoutes
];

export default AppRoutesAdministrateur;
