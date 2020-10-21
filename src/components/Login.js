import React from 'react';
import logo from '../logo.png';
import './Login.css';

export default function Login() {
    return (
        <div className="loginContainer">
            <div className="logoContainer">
                <img className="noincLogo" src={logo} alt="no.inc logo" />
            </div>
            <form className="loginForm">
                <p className="loginLabel">Login to Our Magic Portal</p>
                <input type="text" placeholder="Username" />
                <input type="text" placeholder="Password" />
                <input id="submitButton" type="submit" value="Login" />
            </form>
        </div>
    )
}