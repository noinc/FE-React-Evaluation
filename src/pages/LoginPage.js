import React from 'react';
import {
    Link,
} from "react-router-dom";

export class LoginPage extends React.Component {

    render() {
        return <div>
            Login Page
            <button>
                <Link to="/">Login</Link>
            </button>
        </div>
    }
}
