import React from "react";

const AdDashboard = () => {

    return (
        <>
            <h1 className="mt-4">Dashboard Administrateur</h1>
            <div className="card mb-4 p-2">
                <div className="row">
                    <div className="col-md-4">
                        <div className="card bg-dark text-white mb-4">
                                <div className="card-body fs-1 text-center">2569<br/>KM/M</div>
                                <div className="card-footer text-center">
                                    <p className="small text-white fs-4 text-center stretched-link" >KILOMETRAGE MENSUEL DU PARC</p>
                                </div>
                        </div>
                    </div>
                    <div className="col-md-4">
                        <div className="card bg-dark text-white mb-4">
                                <div className="card-body fs-1 text-center">2569<br/>L/M</div>
                                <div className="card-footer text-center">
                                    <p className="small text-white fs-4  stretched-link" >CONSOMMATION CARBURANT</p>
                                </div>
                        </div>
                    </div>
                    <div className="col-md-4">
                        <div className="card bg-dark text-white mb-4">
                                <div className="card-body fs-1 text-center">25<br/>MOIS</div>
                                <div className="card-footer text-center">
                                    <p className="small text-white fs-4 text-center stretched-link" >MOYENNE D'AGE DU PARC</p>
                                </div>
                        </div>
                    </div>
                </div>
                <div className="row">
                    <div className="col-md-12">
                    <div className="card bg-dark text-white mb-4">
                                <div className="card-body fs-1 text-center">08<br/>Véhicules dans le parc</div>
                                <div className="card-footer text-center d-flex justify-content-between">
                                    <div className="d-flex w-50 justify-content-center border-end">
                                        <p>06</p>&nbsp;
                                        <p>VP</p>
                                    </div>
                                    <div className="d-flex w-50 justify-content-center">
                                        <p>02</p>&nbsp;
                                        <p>Camionnettes</p>
                                    </div>
                                </div>
                        </div>
                    </div>
                </div>
                <div className="row">
                    <div className="col-md-6">

                    </div>
                    <div className="col-md-6">
                        
                    </div>
                </div>
            </div>

        </>
     )
}


export default AdDashboard;