import React from "react";
import DataTable, { TableColumn } from "react-data-table-component";
import Button from "../../../components/Administrateur/Button";

interface DataRow {
    agent: string;
    service: string;
    fonction: string;
    vehicule: string;
    action: any;
} 

const DotationCarburant = () => {


    const popupAction = () => {
        return alert("Hello world");
    }
    const columns: TableColumn<DataRow>[] = [
        {
            name: 'Agent',
            selector: row => row.agent,
            sortable: true,
        },
        {
            name: "Service",
            selector: row => row.service,
            sortable: true,
        },
        {
            name: 'Fonction',
            selector: row => row.fonction,
            sortable: true,
        },
        {
            name: 'Véhicule détenu',
            selector: row => row.vehicule,
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
            agent: 'Abraham DEDJENE',
            service: 'Prestation et contentieux',
            fonction: "Chef de service",
            vehicule: "88 JN 01",
            action: <Button popupAction={popupAction}/>
        },
        {
            id: 2,
            agent: "Mr N'GUESSAN",
            service: 'Prestation et contentieux',
            fonction: "Développeur",
            vehicule: "88 JE 01",
            action: <Button popupAction={popupAction}/>

        },

    ]
    return (
        <>
            <h1 className="mt-4">Dotation carburant</h1>
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


export default DotationCarburant;
