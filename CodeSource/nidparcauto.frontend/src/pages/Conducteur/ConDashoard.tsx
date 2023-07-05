import React from "react";
import "./ConDashboard.css";

const ConDashboard = () => {

    return (
        <>
            <div className="row bg-light">
                <h1 className="mt-4">Dashboard Conduteur</h1>
                <div className="col-md-4 py-5">
                    <div className="kiloSemaine">
                        <div className="carteCircle">
                            <h3>426272</h3>
                            <span className="lead">Km / Semaine</span>
                        </div>
                        <div className="">
                            <h5 className="">Kilométrage moyen</h5>
                        </div>
                    </div>
                </div>
                <div className="col-md-4 py-5">
                    <div className="kiloSemaine">
                        <div className="carteCircle">
                            <h3>426272</h3>
                            <span className="lead">Km / Semaine</span>
                        </div>
                        <div className="">
                            <h5 className="">Consommation moyenne</h5>
                        </div>
                    </div>
                </div>
                <div className="col-md-4 py-5">
                    <div className="kiloSemaine">
                        <div className="carteCircle">
                            <h3>426272</h3>
                            <span className="lead">Le.....</span>
                        </div>
                        <div className="">
                            <h5 className="">Dernier relevé kilométrique</h5>
                        </div>
                    </div>
                </div>
            </div>
            <div className="row py-5">
                <div className="col-md-4 offset-md-2 text-center">
                    <i className="fa-solid fa-user fa-10x"></i>
                </div>
                <div className="col-md-4 ">
                    <h3 className="">Des conseils de conduite</h3>
                    <ul>
                        <li className="lead">Lorem ipsum dolor sit amet</li>
                        <li className="lead">Lorem ipsum dolor sit amet</li>
                        <li className="lead">Lorem ipsum dolor sit amet</li>
                        <li className="lead">Lorem ipsum dolor sit amet</li>
                        <li className="lead">Lorem ipsum dolor sit amet</li>
                    </ul>
                </div>
            </div>


    

                 

            
        </>
    )
}


export default ConDashboard;