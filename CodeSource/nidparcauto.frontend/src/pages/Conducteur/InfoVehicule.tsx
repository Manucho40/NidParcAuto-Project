import React from "react";

const InfoVehicule = () => {

    const sizeBox = {
        height: "290px"
    };
    return (
        <div className="bg-light p-2">
            <div className="row">
                <h1 className="mt-4">INFO SUR VEHICULE</h1>
                <div className="col-md-4 offset-md-2">
                    <div className="card" style={sizeBox}>
                        <div className="card-body p-0">
                            <h3 className="card-title bg-dark text-light p-2 border-bottom"><i className="fa-solid fa-car-side"></i><span className="mx-2">Mon Véhicule</span></h3>
                            <h4 className="card-subtitle  border-bottom p-2 text-muted">Audi</h4>
                            <ul className="list-group mt-0">
                                <li className="list-group-item fw-bold lead">Energie: <span className="lead">Lorem</span> </li>
                                <li className="list-group-item fw-bold lead">Immatriculation: <span className="lead">Lorem</span></li>
                                <li className="list-group-item fw-bold lead">Puissance Fiscal: <span className="lead">Lorem</span></li>
                                <li className="list-group-item fw-bold lead">Garantie: <span className="lead">Lorem</span></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div className="col-md-4">
                    <div className="card" style={sizeBox}>
                        <div className="card-body p-0">
                            <h3 className="card-title p-2 bg-dark text-light border-bottom"><i className="fa-solid fa-user"></i><span className="mx-2">Moi</span></h3>
                            <h4 className="card-subtitle  border-bottom p-2 text-muted">Fonction</h4>
                            <ul className="list-group mt-0">
                                <li className="list-group-item fw-bold lead">Nom: <span className="lead">Lorem</span> </li>
                                <li className="list-group-item fw-bold lead">Prenom: <span className="lead">Lorem</span></li>
                                <li className="list-group-item fw-bold lead">Contact: <span className="lead">Lorem</span></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div className="row mt-4">
                <div className="col-md-4 offset-md-2">
                    <div className="card" style={sizeBox}>
                        <div className="card-body p-0">
                            <h3 className="card-title p-2 bg-dark text-light border-bottom"><i className="fa-solid fa-file-contract"></i><span className="mx-2">Info sur Détention</span></h3>
                            <ul className="list-group mt-0">
                                <li className="list-group-item fw-bold lead">Durée de la détention: <span className="lead">Lorem</span> </li>
                                <li className="list-group-item fw-bold lead">Début de la détention: <span className="lead">Lorem</span></li>
                                <li className="list-group-item fw-bold lead">Fin de la détention: <span className="lead">Lorem</span></li>
                                <li className="list-group-item fw-bold lead">Maintenance influse ou non: <span className="lead">Lorem</span></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div className="col-md-4">
                    <div className="card" style={sizeBox}>
                        <div className="card-body p-0">
                            <h3 className="card-title p-2 bg-dark text-light border-bottom"><i className="fa-solid fa-gas-pump"></i><span className="mx-2">Info sur carburant</span></h3>
                            <ul className="list-group mt-0">
                                <li className="list-group-item fw-bold lead">Type: <span className="lead">Lorem</span> </li>
                                <li className="list-group-item fw-bold lead">Début chargement: <span className="lead">Lorem</span></li>
                                <li className="list-group-item fw-bold lead">Fin chargement: <span className="lead">Lorem</span></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}


export default InfoVehicule;