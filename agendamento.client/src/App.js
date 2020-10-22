import React from 'react';
import logo from './logo.png';
import Routes from './routes';
import Menu from './Components/Menu';
import './App.css';

function App() {

  return (
    <div className="App">
      <Menu logo={ logo }/>
      <Routes />
    </div>
  );
}

export default App;
