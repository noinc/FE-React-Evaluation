import React from 'react';
import {
  Link,
} from 'react-router-dom';

class LoginPage extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      loggedIn: false,
    };
  }

  render() {
    return (
      <div>
        Login Page
        <button type="button">
          <Link to="/">Login</Link>
        </button>
      </div>
    );
  }
}

export default LoginPage;
