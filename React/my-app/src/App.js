import React from 'react';
// import logo from './logo.svg';
import './App.css';
import Viesti from './Viesti';
import Laskuri from './Laskuri';
import WebHaku from './WebHaku';

function App() {
  return (
    <div>
      <div className="App">
        <h1>Oma sovellus</h1>
      </div>
      <Viesti />

      <WebHaku />

      <Laskuri maksimi={15} />
      <Laskuri maksimi={5} />
    </div>
  );
}

export default App;
