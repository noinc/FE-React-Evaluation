import React from 'react';
import './App.css';
import {
    Route,
    Switch
} from 'react-router-dom';
import {fakeInterests, fakeSkills} from "../dummy-data";
import Login from './Login';

function App() {
    console.log('test return', fakeInterests);
    console.log('test return', fakeSkills);
  return (
    <div className="App">
      <p>This is App.js</p>
        <Switch>
          <Route path="/">
            <Login />
          </Route>
        </Switch>
    </div>
  );
}

export default App;
