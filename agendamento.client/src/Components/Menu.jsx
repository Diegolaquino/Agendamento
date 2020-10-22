import React from 'react';
import './Menu.css';

function Menu(props){
    const logo = props.logo;
    return(
        <nav id="menu" className="uk-navbar-container uk-margin" uk-navbar="true">
        <div className="uk-navbar-left">

        <img className="uk-navbar-item uk-logo app-logo" src={logo} alt="logo"/>

        <ul className="uk-navbar-nav">
            <li>
                <a href="/">
                    <span className="uk-icon uk-margin-small-right" uk-icon="icon: star"></span>
                    Agendamentos
                </a>
            </li>
            <li>
                <a href="/services">
                    <span className="uk-icon uk-margin-small-right" uk-icon="icon: star"></span>
                    Serviços
                </a>
            </li>
            <li>
                <a href="/clients">
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