import React from 'react';
import './App.css';
import {
    Route,
    Switch
} from 'react-router-dom';
import {fakeInterests, fakeSkills} from "../dummy-data";
import Login from './Login';
import { Helmet } from 'react-helmet'

function App() {
    console.log('test return', fakeInterests);
    console.log('test return', fakeSkills);
  return (
    <div className="App">
      <Helmet>
        <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:400,600" rel="stylesheet" />
      </Helmet>
      <Switch>
        <Route path="/">
          <Login />
        </Route>
      </Switch>
    </div>
  );
}

export default App;
