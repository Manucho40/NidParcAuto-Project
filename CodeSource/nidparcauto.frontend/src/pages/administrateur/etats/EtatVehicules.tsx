import React from "react";
import DataTable, { TableColumn } from "react-data-table-component";


export interface DataRow {
    immatriculation: string;
    agent: string;
    dateDebutUtilisation: string;
    dateFinUtilisation: string;
    marque: string;
    energie: string;
    dateDeMiseEnCirculation: string;
    dateAcquisition: string;
    statut: string;

}


const EtatVehicules = () => {
    const columns: TableColumn<DataRow>[] = [
        {
            name: 'Immatriculation',
            selector: row => row.immatriculation,
            sortable: true,
        },
        {
            name: 'Agent',
            selector: row => row.agent,
            sortable: true,
        },
        {
            name: "Date début d'utilisation",
            selector: row => row.dateDebutUtilisation,
            sortable: true,
        },
        {
            name: "Date fin d'utilisation",
            selector: row => row.dateFinUtilisation,
            sortable: true,
        },
        {
            name: 'Marque',
            selector: row => row.marque,
            sortable: true,
        },
        {
            name: "Energie",
            selector: row => row.energie,
            sortable: true,
        },
        {
            name: 'Date de Mise en circulation',
            selector: row => row.dateDeMiseEnCirculation,
            sortable: true,
        },
        {
            name: "Date d'acquisition",
            selector: row => row.dateAcquisition,
            sortable: true,
        },
        {
            name: "Statut",
            selector: row => row.statut,
            sortable: true,
        },




    ];
    
    const data = [
        {
            id: 1,
            immatriculation: '88 JN 01',
            agent: "Mr N'GUESSAN",
            dateDebutUtilisation: "15/02/23",
            dateFinUtilisation: "15/05/23",
            marque: 'Toyota',
            energie: "Essence",
            dateDeMiseEnCirculation: "20/12/1994",
            dateAcquisition: "04/05/2022",
            statut: "Occupé",
        },
        {
            id: 2,
            immatriculation: '88 JE 01',
            agent: "Abraham DEDJENE",
            dateDebutUtilisation: "1/01/23",
            dateFinUtilisation: "15/05/23",
            marque: 'Suzuki',
            energie: "Gasoil",
            dateDeMiseEnCirculation: "20/12/1994",
            dateAcquisition: "04/05/2022",
            statut: "Occupé",
        },

    ]

    return (
        <>
            <h1 className="mt-4">Etat Vehicules</h1>
            <div className="card mb-4 ">
                <div className="card-header bg-dark text-light tabb">
                    <div>
                        <i className="fas fa-chart-area me-1"></i>
                        <span className="titleTab"> Liste des Agents</span>
                    </div>
                    <form className="d-none d-md-inline-block form-inline ms-auto me-0 me-md-3 my-2 my-md-0">
                        <div className="input-group">
                            <input className="form-control" type="text" placeholder="Search for..." aria-label="Search for..." aria-describedby="btnNavbarSearch" />
                        </div>
                    </form>

                </div>
                <div className="card-header bg-light text-dark d-flex justify-content-between">
                    <div>
                    <select className="form-select" aria-label="Default select example">
                        <option selected>Filtre</option>
                        <option value="1">One</option>
                        <option value="2">Two</option>
                        <option value="3">Three</option>
                    </select>
                    </div>
                    <div>
                        <button className="btn btn-secondary"><i className="fa-solid fa-print"></i>&nbsp;Imprimer</button>&nbsp;
                        <button className="btn btn-secondary"><i className="fa-solid fa-download"></i>&nbsp;Télecharger</button>
                    </div>
                </div>
                <div className="card-body">
                    <DataTable
                        columns={columns}
                        data={data}
                        pagination
                        
                        
                    />
                </div>
            </div>

        </>
    )
}


export default EtatVehicules;
