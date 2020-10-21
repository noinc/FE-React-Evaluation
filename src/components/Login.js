import React from 'react';
import logo from '../logo.svg';
import './Login.css';

export default function Login() {
    return (
        <div>
            <div>Logo goes here</div>
            <div>
                <p>Login to Our Magic Portal</p>
                <form>
                    <input type="text" placeholder="Username" />
                    <input type="text" placeholder="Username" />
                    <input type="submit" value="Login" />
                </form>
            </div>
        </div>
    )
}