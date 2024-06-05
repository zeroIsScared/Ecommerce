
import { Button, Container, Menu } from "semantic-ui-react";

interface Props {
    openForm: () => void;
}

export default function Navbar({ openForm }: Props) {
    const logeStyles = {
        marginRight: '10px',
    };

    return (
        <Menu inverted fixed="top">
            <Container>
                <Menu.Item header>
                    <img src="./assets/.jpg" alt="logo" style={logeStyles} />
                    Ecommerce
                </Menu.Item>
                <Menu.Item name="All Properties" />
                <Menu.Item name="Your Properties" />
                <Menu.Item >
                    <Button standard content="Create Property" color="olive" onClick={openForm} />
                </Menu.Item>
            </Container>
        </Menu>
    )
}