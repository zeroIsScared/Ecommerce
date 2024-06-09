
import { Button, Menu } from "semantic-ui-react";
import { NavLink } from "react-router-dom";


export default function Navbar() {
    const logeStyles = {
        marginRight: '10px',
    };

    return (
        <Menu inverted fixed="top">
            <Menu.Item as={NavLink} to='/' header>
                <img src="../assets/.jpg" alt="logo" style={logeStyles} />
                Ecommerce
            </Menu.Item>
            <Menu.Item as={NavLink} to='/userProperties' name="Your Properties" />
            <Menu.Item as={NavLink} to='/userFavorites' name="Favorites" />
            <Menu.Item >
                <Button s={NavLink} to='/createProperty' standard content="Create Property" color="olive" />
            </Menu.Item>
        </Menu>
    )
}