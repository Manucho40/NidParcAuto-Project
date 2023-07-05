﻿import React from "react";
import DataTable, { TableColumn } from 'react-data-table-component';
import Button from "../../../components/Administrateur/Button";

export interface DataRow {
    immatriculation: string;
    marque: string;
    energie: string;
    dateDeMiseEnCirculation: string;
    dateAcquisition: string;
    statut: string;
    action: any;
}
const ReparationVehicule = () => {

    const popupAction = () => {
        return alert("Hello world");
    }
    const columns: TableColumn<DataRow>[] = [
        {
            name: 'Immatriculation',
            selector: row => row.immatriculation,
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
        {
            name: "Action",
            selector: row => row.action,
        }


    ];
    
    const data = [
        {
            id: 1,
            marque: 'Toyota',
            immatriculation: '88 JN 01',
            energie: "Essence",
            dateDeMiseEnCirculation: "20/12/1994",
            dateAcquisition: "04/05/2022",
            statut: "Occupé",
            action: <Button popupAction={popupAction}/>
        },
        {
            id: 2,
            marque: 'Suzuki',
            immatriculation: '88 JE 01',
            energie: "Gasoil",
            dateDeMiseEnCirculation: "20/12/1994",
            dateAcquisition: "04/05/2022",
            statut: "Innoccupé",
            action: <Button popupAction={popupAction}/>

        },

    ]

    return (
        <>
            <h1 className="mt-4">Véhicule en réparation</h1>
            <div className="card mb-4 ">
                <div className="card-header bg-dark text-light tabb">
                    <div>
                        <i className="fas fa-chart-area me-1"></i>
                        <span className="titleTab"> Liste des véhicules</span>
                    </div>
                    <form className="d-none d-md-inline-block form-inline ms-auto me-0 me-md-3 my-2 my-md-0">
                        <div className="input-group">
                            <input className="form-control" type="text" placeholder="Search for..." aria-label="Search for..." aria-describedby="btnNavbarSearch" />
                        </div>
                    </form>

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


export default ReparationVehicule;
