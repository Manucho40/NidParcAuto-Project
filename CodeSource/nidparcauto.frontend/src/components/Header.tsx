import { useContext } from "react";
import { ToggleContext } from "../context/ToggleContext";

const Header = () => {
    const toggleValue: any = useContext(ToggleContext);

    return ( 
        <>
                <nav className="sb-topnav navbar navbar-expand navbar-dark bg-dark">
                    <a className="navbar-brand ps-3" href="index.html">NID_FLOTTE</a>
                    <button
                        className="btn btn-link btn-sm order-1 order-lg-0 me-4 me-lg-0"
                        id="sidebarToggle"
                        onClick={() => toggleValue.setToggle((!toggleValue.toggle))}
                    >
                        <i className="fas fa-bars"></i>
                    </button>
                    {/*
                    <!-- Navbar Search-->
                    */}
                    <form
                        className="d-none d-md-inline-block form-inline ms-auto me-0 me-md-3 my-2 my-md-0">
           
                    </form>
                    {/*
                    <!-- Navbar-->
                    */}
                    <ul className="navbar-nav ms-auto ms-md-0 me-3 me-lg-4">
                        <li className="nav-item dropdown">
                            <a
                                className="nav-link dropdown-toggle"
                                id="navbarDropdown"
                                href="dssds"
                                role="button"
                                data-bs-toggle="dropdown"
                                aria-expanded="false">
                                <i className="fas fa-user fa-fw"></i>
                            </a>
                            <ul className="dropdown-menu dropdown-menu-end" aria-labelledby="navbarDropdown">
                                <li>
                                    <a className="dropdown-item" href="sssd">Settings</a>
                                </li>
                                <li>
                                    <a className="dropdown-item" href="dssd">Activity Log</a>
                                </li>
                                <li><hr className="dropdown-divider"/></li>
                                <li>
                                    <a className="dropdown-item" href="sdsd">Logout</a>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </nav>
                
        
        </>
     );
}
 
export default Header;