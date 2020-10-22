import React from 'react';
import Menu from '../../Components/Menu';
import Table from './table';
import './index.css';

function Main(props){

    const logo = props.logo;

    return (
        <React.Fragment>
            <header className="app-header">
        
                <Menu logo={logo} />
            </header>
            <section className="table">
                <Table />
            </section>
        </React.Fragment>
    );
}

export default Main;