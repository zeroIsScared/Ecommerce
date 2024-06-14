import { Button } from "semantic-ui-react";

interface ButtonsProps {
    content: string;
    type?: string;
    onClick?: () => void;
    link?: string;
}

const Buttons = ({ content, type, onClick, link }: ButtonsProps) => {

    const handleOnClick = (onClick ?? false) !== false ? onClick : () => null;

    return (
        <Button
            as={type}
            to={link}
            onClick={handleOnClick}
        >
            {content}
        </Button>
    );
};

export default Buttons;
