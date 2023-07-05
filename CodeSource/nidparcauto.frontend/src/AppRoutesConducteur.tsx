import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import ConDashboard from './pages/Conducteur/ConDashoard';
import InfoVehicule from './pages/Conducteur/InfoVehicule';
import SuiviKilometrage from './pages/Conducteur/SuiviKilometrage';
import SuiviCarburant from './pages/Conducteur/SuiviCarburant';
import AlerteSinistre from './pages/Conducteur/AlerteSinistre';
import AlertePanne from './pages/Conducteur/AlertePanne';
import AlerteContravention from './pages/Conducteur/AlerteContravention';




const AppRoutesConducteur = [
    {
        index: true,
        element: <ConDashboard />
    },
    {
        path: '/info-vehicule',
        element: <InfoVehicule />
    },
    {
        path: '/suivi-kilometrage',
        element: <SuiviKilometrage />
    },
    {
        path: '/suivi-carburant',
        element: <SuiviCarburant />
    },
    {
        path: '/alerte-sinistre',
        element: <AlerteSinistre />
    },
    {
        path: '/alerte-panne',
        element: <AlertePanne />
    },
    {
        path: '/alerte-contravention',
        element: <AlerteContravention />
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

export default AppRoutesConducteur;
