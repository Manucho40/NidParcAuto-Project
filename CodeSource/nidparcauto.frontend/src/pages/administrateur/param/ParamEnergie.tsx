import React, { useEffect, useState } from "react";
import DataTable, { TableColumn } from "react-data-table-component";
import Button from "../../../components/Administrateur/Button";
import { useDispatch } from "react-redux";
import { fetchEnergies, selectEnergie } from "../../../store/features/energieSlice";
import { AppThunkDispatch } from "../../../store/store";
import { EnergiesInterface } from "../../../types/InterfacesTypes";
import { useSelector } from "react-redux";
import Loader from "../../../components/Loader";
export interface DataRow {
    id: number;
    libelle: string;
}
const ParamEnergie = () => {
    const [energieData, setEnergieData] = useState<EnergiesInterface[] | null>(null)
    const disptach = useDispatch<AppThunkDispatch>();
    const selector = useSelector(selectEnergie)
    // console.log(selector)
    useEffect(() => {
        disptach(fetchEnergies());
    }, [disptach])
    
    useEffect(() => {
        if(selector != null){
            setEnergieData(selector)
        }
    }, [selector])

    console.log(energieData)


    const popupAction = () => {
        return alert("Hello world");
    }
    const columns: TableColumn<EnergiesInterface>[] | null= [
        {
            name: 'Id',
            selector: row => row.idEnergie,
            sortable: true,
        },
        {
            name: 'Libelle',
            selector: row => row.libEnergie,
            sortable: true,
        }
    ];
    
    // const data = [
    //     {
    //         id: 1,
    //         libelle: 'Essence',
    //     },
    //     {
    //         id: 2,
    //         libelle: 'Gasoil',
    //     },
    //     {
    //         id: 3,
    //         libelle: 'Electrique',
    //     },

    // ]

    return (
        <>
            <h1 className="mt-4">Parametre Energie</h1>
            <div className="card mb-4 p-2">

            <div className="card mb-4 ">
                <div className="card-header bg-dark text-light tabb">
                    <div>
                        <i className="fas fa-chart-area me-1"></i>
                        <span className="titleTab"> Liste des Energies</span>
                    </div>
                    <form className="d-none d-md-inline-block form-inline ms-auto me-0 me-md-3 my-2 my-md-0">
                        <div className="input-group">
                            <Button  popupAction={popupAction}/>                        
                        </div>
                    </form>

                </div>
                <div className="card-body">
                    {
                        energieData ? (
                            <DataTable
                            columns={columns}
                            data={energieData}
                            pagination   
                        />
                        ) : (<Loader />)
                    }
                </div>
            </div>
            </div>
        </>
    )
}


export default ParamEnergie;
