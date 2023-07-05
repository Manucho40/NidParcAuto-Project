import { NavLink } from "react-router-dom";

const NavBarAdministrateur = () => {
    return ( 
        <>
                 <nav className="sb-sidenav accordion sb-sidenav-dark" id="sidenavAccordion">
                    <div className="sb-sidenav-menu">
                        <div className="nav">
                        <NavLink className="nav-link" to='/'>
                                <div className="sb-nav-link-icon"><i className="fas fa-tachometer-alt"></i></div>
                                Tableau De Bord
                        </NavLink>
                            <hr />
                            {/* dffkjffff */}
                            <a className="nav-link collapsed" href="zezeez" data-bs-toggle="collapse" data-bs-target="#collapseLayouts" aria-expanded="false" aria-controls="collapseLayouts">
                                <div className="sb-nav-link-icon"><i className="fas fa-columns"></i></div>
                                Gestion
                                <div className="sb-sidenav-collapse-arrow"><i className="fas fa-angle-down"></i></div>
                            </a>
                            <div className="collapse" id="collapseLayouts" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordion">
                                <nav className="sb-sidenav-menu-nested nav">
                                    <NavLink className="nav-link" to='/attribution-vehicule'>Attribution de véhicules</NavLink>
                                    <NavLink className="nav-link" to='/reparation-vehicule'>Réparation</NavLink>
                                    <NavLink className="nav-link" to='/documents'>Documents</NavLink>
                                    <NavLink className="nav-link" to='/dotation-carburant'>Dotation de carburant</NavLink>
                                    <NavLink className="nav-link" to='/entretien-vehicule'>Entretien du véhicule</NavLink>
                                </nav>
                            </div>
                            <hr />
                            <a className="nav-link collapsed" href="zezeez" data-bs-toggle="collapse" data-bs-target="#collapseLayou" aria-expanded="false" aria-controls="collapseLayouts">
                                <div className="sb-nav-link-icon"><i className="fas fa-columns"></i></div>
                                Etats
                                <div className="sb-sidenav-collapse-arrow"><i className="fas fa-angle-down"></i></div>
                            </a>
                            <div className="collapse" id="collapseLayou" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordion">
                                <nav className="sb-sidenav-menu-nested nav">
                                    <NavLink className="nav-link" to='/etat-vehicules'>Véhicules</NavLink>
                                    <NavLink className="nav-link" to='/matrice-des-couts'>Matrices des coûts</NavLink>
                                    <NavLink className="nav-link" to='/etat-carubrant'>Carburant</NavLink>
                                    <NavLink className="nav-link" to='/etat-pannes'>Pannes</NavLink>
                                    <NavLink className="nav-link" to='/etat-sinistres'>Sinistres</NavLink>
                                    <NavLink className="nav-link" to='/etat-contraventions'>Contraventions</NavLink>
                                </nav>
                            </div>
                            <hr />
                            <a className="nav-link collapsed" href="zezeez" data-bs-toggle="collapse" data-bs-target="#collapseLayo" aria-expanded="false" aria-controls="collapseLayouts">
                                <div className="sb-nav-link-icon"><i className="fas fa-columns"></i></div>
                                Paramètres
                                <div className="sb-sidenav-collapse-arrow"><i className="fas fa-angle-down"></i></div>
                            </a>
                            <div className="collapse" id="collapseLayo" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordion">
                                <nav className="sb-sidenav-menu-nested nav">
                                <NavLink className="nav-link" to='/param-energie'>Energie</NavLink>
                                <NavLink className="nav-link" to='/param-marque'>Marque</NavLink>
                                <NavLink className="nav-link" to='/param-modele'>Modele</NavLink>
                                <NavLink className="nav-link" to='/param-type-vehicule'>Type du Véhicules</NavLink>
                                <NavLink className="nav-link" to='/param-fonction'>Fonction</NavLink>
                                <NavLink className="nav-link" to='/param-service'>Service</NavLink>
                                <NavLink className="nav-link" to='/param-points-chocs'>Points de chocs</NavLink>
                                <NavLink className="nav-link" to='/param-type-piece'>Types de pièces</NavLink>
                                </nav>
                            </div>
                            <hr />
                            <a className="nav-link collapsed" href="dd" data-bs-toggle="collapse" data-bs-target="#collapsePages" aria-expanded="false" aria-controls="collapsePages">
                                <div className="sb-nav-link-icon"><i className="fas fa-book-open"></i></div>
                                Plus
                                <div className="sb-sidenav-collapse-arrow"><i className="fas fa-angle-down"></i></div>
                            </a>
                            <div className="collapse" id="collapsePages" aria-labelledby="headingTwo" data-bs-parent="#sidenavAccordion">
                                <nav className="sb-sidenav-menu-nested nav accordion" id="sidenavAccordionPages">
                                    <a className="nav-link collapsed" href="yjdkj" data-bs-toggle="collapse" data-bs-target="#pagesCollapseAuth" aria-expanded="false" aria-controls="pagesCollapseAuth">
                                        Authentication
                                        <div className="sb-sidenav-collapse-arrow"><i className="fas fa-angle-down"></i></div>
                                    </a>
                                    <div className="collapse" id="pagesCollapseAuth" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordionPages">
                                        <nav className="sb-sidenav-menu-nested nav">
                                            <a className="nav-link" href="login.html">Login</a>
                                            <a className="nav-link" href="register.html">Register</a>
                                            <a className="nav-link" href="password.html">Forgot Password</a>
                                        </nav>
                                    </div>
                                    <a className="nav-link collapsed" href="yjdkj" data-bs-toggle="collapse" data-bs-target="#pagesCollapseError" aria-expanded="false" aria-controls="pagesCollapseError">
                                        Error
                                        <div className="sb-sidenav-collapse-arrow"><i className="fas fa-angle-down"></i></div>
                                    </a>
                                    <div className="collapse" id="pagesCollapseError" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordionPages">
                                        <nav className="sb-sidenav-menu-nested nav">
                                            <a className="nav-link" href="401.html">401 Page</a>
                                            <a className="nav-link" href="404.html">404 Page</a>
                                            <a className="nav-link" href="500.html">500 Page</a>
                                        </nav>
                                    </div>
                                </nav>
                            </div>
                            <hr />
                        </div>
                    </div>
                    <div className="sb-sidenav-footer">
                        <div className="small">Logged in as:</div>
                        Start Bootstrap
                    </div>
                </nav>
        
        
        </>
     );
}
 
export default NavBarAdministrateur;