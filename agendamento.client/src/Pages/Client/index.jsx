import React from 'react';
import './index.css';

export default function Table(){
    return (
        <React.Fragment>
            <table className="uk-table uk-table-divider uk-table-hover table-clients">
            <caption><h1>Clientes</h1> </caption>
            <thead>
                <tr>
                    <th>Nome do Cliente</th>
                    <th>Email</th>
                    <th>Telefone</th>
                    <th>Sexo</th>
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
                    <td>diegol.aquino@gmail.com</td>
                    <td>(21) 9 9203 4654</td>
                    <td>Masculino</td>
                </tr>
            </tbody>
        </table>

        <div>
        
            <button className="uk-button uk-button-primary uk-margin-small-right" type="button" uk-toggle="target: #kid">Open</button>

           
            <div id="kid" uk-modal="true">
                <div className="uk-modal-dialog uk-modal-body">
                    <h2 className="uk-modal-title">Cadastro de cliente</h2>
                    <div>
                        <form className="uk-form-stacked">
                            <div className="uk-margin">
                                <label className="uk-form-label" htmlFor="name">Nome</label>
                                <div className="uk-form-controls">
                                    <input className="uk-input uk-form-width-large" type="text" />
                                </div>
                            </div>
                            <div className="uk-margin">
                                <label className="uk-form-label" htmlFor="email">Email</label>
                                <div className="uk-form-controls">
                                    <input className="uk-input uk-form-width-large" type="email" />
                                </div>
                            </div>
                            <div className="uk-margin">
                                <label className="uk-form-label" htmlFor="phone">Telefone</label>
                                <div className="uk-form-controls">
                                    <input className="uk-input uk-form-width-large" type="phone" />
                                </div>
                            </div>
                            <div className="uk-margin">
                                <div className="uk-form-label">Sexo</div>
                                <div className="uk-form-controls uk-form-controls-text">
                                    <label><input className="uk-radio" type="radio" name="gender"/> Masculino</label><br />
                                    <label><input className="uk-radio" type="radio" name="gender"/> Feminino</label><br />
                                    <label><input className="uk-radio" type="radio" name="gender"/> Outro</label>
                                </div>
                            </div>

                        </form>
                    </div>
                    <p className="uk-text-right">
                        <button className="uk-button uk-button-default uk-modal-close" type="button">Cancelar</button>
                        <button className="uk-button uk-button-primary" type="button">Salvar</button>
                    </p>
                </div>
            </div>
        </div>
        </React.Fragment>
    );
}