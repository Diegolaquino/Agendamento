import React from 'react';

import { BrowserRouter, Switch, Route } from 'react-router-dom';

import Main from './Pages/Main/index';
import Clients from './Pages/Client/index';

const Routes = () => (
    <BrowserRouter>
        <Switch>
            <Route exact path="/" component={ Main } />
            <Route path="/clients" component={ Clients } />
            {/* exemplo de rota com id */}
            {/* <Route path="/clients/:id" component={ Clients } /> */}
        </Switch>
    </BrowserRouter>
);

export default Routes;