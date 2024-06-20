
import { Button, Menu } from "semantic-ui-react";
import { NavLink } from "react-router-dom";
import { useAuth0 } from "@auth0/auth0-react";
import { useEffect } from "react";
import axios from "axios";


export default function Navbar() {
    const logeStyles = {
        marginRight: '10px',
    };

    const { loginWithRedirect, logout, isAuthenticated, getAccessTokenSilently, } = useAuth0();

    const handleLogin = async () => {
        loginWithRedirect();
    }

    useEffect(() => {
        getAccessTokenSilently().then((data) => {
            localStorage.setItem("accessToken", data);

            // if (localStorage.getItem("accessToken") !== data) {

            //     axios.defaults.headers.common = { 'Authorization': `Bearer ${data}` }

            //     localStorage.setItem("accessToken", data);
            // }
            console.log(data)
            console.log(localStorage.getItem("accessToken"))
        });
    }, [getAccessTokenSilently]);



    return (
        <Menu inverted fixed="top">
            <Menu.Item as={NavLink} to='/' header>
                <img src="../assets/.jpg" alt="logo" style={logeStyles} />
                Ecommerce
            </Menu.Item>
            <Menu.Item as={NavLink} to='/userProperties' name="Your Properties" />
            <Menu.Item as={NavLink} to='/userFavorites' name="Favorites" />
            <Menu.Item >
                <Button as={NavLink} to='/createProperty' standard content="Create Property" color="olive" />
            </Menu.Item>
            {!isAuthenticated && (
                <Menu.Item >
                    <Button standard content="Login" color="blue" onClick={() => handleLogin()} />
                </Menu.Item>)
            }
            {isAuthenticated && (
                <Menu.Item >
                    <Button standard content="Logout" color="blue" onClick={() => logout()} />
                </Menu.Item>)
            }
        </Menu>
    )
}