import { SyntheticEvent } from "react";
import { LinkProps } from "react-router-dom";
import { Button, SemanticCOLORS } from "semantic-ui-react";

interface ButtonsProps {
    content: string;
    type?: React.ForwardRefExoticComponent<LinkProps & React.RefAttributes<HTMLAnchorElement>>;
    onClick?: (e?: SyntheticEvent<HTMLButtonElement>, propertyId?: number) => void;
    link?: string;
    color: SemanticCOLORS;
    loading?: any;
    id?: number;
    role?: "submit" | "reset" | "button" | undefined;
}

const Buttons = ({ content, type, onClick, link, color, id, role }: ButtonsProps) => {

    const handleOnClick = (onClick ?? false) !== false ? onClick : () => null;

    return (
        <Button
            as={type}
            to={`${link}${id}`}
            onClick={(e) => handleOnClick(e, id)}
            color={color}
            type={role}
        >
            {content}
        </Button>
    );
};

export default Buttons;
