import React from 'react';
import { useForm } from 'react-hook-form'
import logo from '../logo.png';
import './Login.css';

export default function Login() {
    const { handleSubmit, register, errors } = useForm()
    const onSubmit = values => console.log(JSON.stringify(values))

    return (
        <div className="loginContainer">
            <div className="logoContainer">
                <img className="noincLogo" src={logo} alt="no.inc logo" />
            </div>
            <form className="loginForm" onSubmit={handleSubmit(onSubmit)}>
                <p className="loginLabel">Login to Our Magic Portal</p>
                <input type="text" name="username" placeholder="Username" ref={register({
                    required: "Required",
                    minLength: {
                        value: 3,
                        message: "Username must be at least 3 characters long"
                    },
                    maxLength: {
                        value: 40,
                        message: "Username may not be longer than 40 character"
                    },
                    pattern: {
                        value: /^\w+$/i,
                        message: "Username may only contain word characters"
                    }
                })}/>
                {errors.username && errors.username.message}

                <input type="password" name="password" placeholder="Password" ref={register({
                    required: "Required",
                    minLength: {
                        value: 12,
                        message: "Password must be at least 12 characters long"
                    },
                    maxLength: {
                        value: 80,
                        message: "Password may not be longer than 80 characters"
                    },
                    pattern: {
                        value: /^\w+$/i,
                        message: "Password may only contain word characters"
                    }
                })}/>
                {errors.password && errors.password.message}
                
                <input id="submitButton" type="submit" value="Login" />
            </form>
        </div>
    )
}