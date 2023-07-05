import React from "react";
import { Bar } from "react-chartjs-2"
import Chart from 'chart.js/auto';
import { DataCarburant } from "../../utils/DataCarburant";

const data = {
    labels: DataCarburant.map(item => item.year),
    // datasets is an array of objects where each object represents a set of data to display corresponding to the labels above. for brevity, we'll keep it at one object
    datasets: [
        {
            label: 'Popularity of colours',
            data: DataCarburant.map((data) => data.litre),
            // you can set indiviual colors for each bar
            backgroundColor: [
                'black',
            ],
            borderWidth: 1,
        }
    ]
}
const SuiviCarburant = () => {

    return (
        <>
            <div className="bg-light p-2">
                <h1 className="mt-4">Suivi du Carburant</h1>
                <div className="row">
                    <div className="col-md-6 offset-md-3">
                        <Bar data={data} />
                    </div>
                </div>

                <div className="row mt-4">
                    <div className="col-md-12">
                        <table className="table custom-table">
                            <thead>
                                <tr>
                                    <th scope="col">Date</th>
                                    <th scope="col">Energie</th>
                                    <th scope="col">Qte</th>
                                    <th scope="col">P.U</th>
                                    <th scope="col">Total TTC</th>

                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        28/02/2023
                                    </td>
                                    <td>
                                        Far far away, behind the word mountains
                                        <small className="d-block">Far far away, behind the word mountains</small>
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                </tr>
                                <tr>
                                    <td>28/02/2023</td>
                                    <td>
                                        Far far away, behind the word mountains
                                        <small className="d-block">Far far away, behind the word mountains</small>
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>

                                </tr>
                                <tr>

                                    <td>28/02/2023</td>
                                    <td>
                                        Far far away, behind the word mountains
                                        <small className="d-block">Far far away, behind the word mountains</small>
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>

                                </tr>

                                <tr>

                                    <td>28/02/2023</td>
                                    <td>
                                        Far far away, behind the word mountains
                                        <small className="d-block">Far far away, behind the word mountains</small>
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>

                                </tr>
                                <tr>
                                    <td>28/02/2023</td>
                                    <td>
                                        Far far away, behind the word mountains
                                        <small className="d-block">Far far away, behind the word mountains</small>
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>

                                </tr>
                                <tr>
                                    <td>28/02/2023</td>
                                    <td>
                                        Far far away, behind the word mountains
                                        <small className="d-block">Far far away, behind the word mountains</small>
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>
                                    <td>
                                        Lorem
                                    </td>

                                </tr>


                            </tbody>
                        </table>

                    </div>
                </div>
            </div>

        </>
    )
}


export default SuiviCarburant;
