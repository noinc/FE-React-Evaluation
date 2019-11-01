import React from 'react';
import {
  // Route,
  Switch,
} from 'react-router-dom';
// import logo from './logo.svg';
import './App.css';
import { fakeInterests, fakeSkills } from './dummy-data';

function App() {
  console.log('test return', fakeInterests);
  console.log('test return', fakeSkills);
  return (
    <div className="App">
      <p>This is App.js</p>
      <Switch />
    </div>
  );
}

export default App;
