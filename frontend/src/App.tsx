import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './BowlingLeague/BowlersList';

function App() {
  return (
    <div className="App">
      <Header title="Bowlers in the League" />
      <BowlerList />
    </div>
  );
}

export default App;
