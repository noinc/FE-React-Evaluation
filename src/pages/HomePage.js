import React from 'react';
import { Route, Switch, Link } from 'react-router-dom';

import InterestsPage from './InterestsPage';
import InterestDetailPage from './InterestDetailPage';

class HomePage extends React.Component {
  render() {
    return (
      <div>
        Home Page

        <button type="button">
          <Link to="/interest/1">Interest 1</Link>
        </button>
        <button type="button">
          <Link to="/interests">Interests</Link>
        </button>

        <Switch>

          <Route path="/interest/:id">
            <InterestDetailPage />
          </Route>
          <Route path="/interests">
            <InterestsPage />
          </Route>

        </Switch>
      </div>
    );
  }
}

export default HomePage;
