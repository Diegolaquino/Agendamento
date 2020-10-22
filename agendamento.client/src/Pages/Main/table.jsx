import React from 'react';

export default function Table(){
    return (
        <table className="uk-table uk-table-divider">
            <caption><h1>Agendamentos</h1></caption>
            <thead>
                <tr>
                    <th>Nome do Cliente</th>
                    <th>Data Agendamento</th>
                    <th>Status</th>
                    <th>Comentário</th>
                </tr>
            </thead>
            <tfoot>
                <tr>
                    <td>-</td>
                </tr>
            </tfoot>
            <tbody>
                <tr>
                    <td>Diego Aquino</td>
                    <td>15/10/2020</td>
                    <td>Pendente</td>
                    <td>X</td>
                </tr>
            </tbody>
        </table>


    );
}