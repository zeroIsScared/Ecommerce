import { ReactElement } from "react";
import { Card, CardContent, CardMeta, Image } from "semantic-ui-react";
import { Properties } from "../../models/properties";
import { GetUserFavorites } from "../../models/getUserFavorite";
import { Property } from "../../models/property";
import { Favorite } from "../../models/favorite";
import { isObject } from "mobx/dist/internal";
import { object } from "yup";


interface Props {
    children: ReactElement<HTMLButtonElement>[];
    property: Properties | Favorite;
    buttonsStyle: string;
}

//<div className="ui small buttons">

export default function PropertiesCard({ children, property, buttonsStyle }: Props) {

    const image = "../../../../public/assets/3BI78kU.jpg";
    const currency = typeof (property.currency) === 'object' ? property.currency.code : property.currency;

    return (

        <Card key={property.id} clearing>
            <CardContent>
                <Image src={image} />
                <h3>{property.title}</h3>
                <CardMeta>Price: {property.price} {currency} </CardMeta>
            </CardContent>
            <CardContent extra textAlign="center">
                <div className={buttonsStyle}>
                    {children}
                </div>
            </CardContent>
        </Card>
    )
}