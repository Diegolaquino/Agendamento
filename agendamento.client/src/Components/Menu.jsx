import React from 'react';

function Menu(props){
    const logo = props.logo;
    const teste = "#";
    return(
        <nav className="uk-navbar-container uk-margin" uk-navbar>
        <div className="uk-navbar-left menu">

        <img className="uk-navbar-item uk-logo app-logo" src={logo} alt="logo"/>

        <ul className="uk-navbar-nav">
            <li>
                <a href={teste}>
                    <span className="uk-icon uk-margin-small-right" uk-icon="icon: star"></span>
                    Agendamentos
                </a>
            </li>
            <li>
                <a href={teste}>
                    <span className="uk-icon uk-margin-small-right" uk-icon="icon: star"></span>
                    Serviços
                </a>
            </li>
            <li>
                <a href={teste}>
                    <span className="uk-icon uk-margin-small-right" uk-icon="icon: star"></span>
                    Clientes
                </a>
            </li>
        </ul>

        </div>
      </nav>
    );
}

export default Menu;