import React from 'react';
import './App.css';
import {
  Route,
  Switch,
} from 'react-router-dom';
// import logo from './logo.svg';
import { fakeInterests, fakeSkills } from './dummy-data';

import HomePage from './pages/HomePage';
import LoginPage from './pages/LoginPage';

function App() {
  console.log('test return', fakeInterests);
  console.log('test return', fakeSkills);
  return (
    <div className="App">
      <p>This is App.js</p>
      <Switch>

        <Route path="/login">
          <LoginPage />
        </Route>
        <Route path="/">
          <HomePage />
        </Route>

      </Switch>
    </div>
  );
}

export default App;
