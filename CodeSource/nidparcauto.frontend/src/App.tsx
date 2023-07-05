import React, { useState, useEffect } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutesConducteur from './AppRoutesConducteur';
import AppRoutesAdministrateur from './AppRoutesAdministrateur';
import './assets/css/styles.css'
import Header from "./components/Header"
import NavBarConducteur from "./components/Conducteur/NavBarConducteur"
import NavBarAdministrateur from "./components/Administrateur/NavBarAdministrateur"
import AuthorizeRoute from './components/api-authorization/AuthorizeRoute';
import { ToggleContext, toggleType } from './context/ToggleContext';


export default function App () {
    const [roleUser, setRoleUser] = useState(true);
    const appRoutes = roleUser ? AppRoutesAdministrateur : AppRoutesConducteur;
    const [toggle, setToggle] = useState<boolean>(true)




    const contextToggle: toggleType = {
        toggle,
        setToggle: setToggle
    }

    useEffect(() => {
        if(toggle === false){
            document.body.classList.add("sb-sidenav-toggled")
        }else  document.body.classList.remove("sb-sidenav-toggled")


    }, [toggle])
    return (
        <ToggleContext.Provider value={contextToggle}>
            <div className="sb-nav-fixed">
                <button>CALL API</button>
                     <div id="layoutSidenav">
                    {
                        toggle ? (
                            <div id="layoutSidenav_nav">
                            {
                                roleUser ? (<NavBarAdministrateur />) : (<NavBarConducteur />)
                            }
                        </div>
                        ) : <></>
                    }
                    <div id="layoutSidenav_content">
                        <main>
                            <div className="container-fluid px-4">
                                    <Header />
                                    <Routes>
                                        {appRoutes.map((route, index) => {
                                            const { element, requireAuth, ...rest }: any = route;
                                            return <Route key={index} {...rest} element={requireAuth ? <AuthorizeRoute {...rest} element={element} /> : element} />;
                                        })}
                                    </Routes>
                            </div>
                        </main>
                    </div>
                </div> 
                        
            </div>
        </ToggleContext.Provider>
    );
 
}
