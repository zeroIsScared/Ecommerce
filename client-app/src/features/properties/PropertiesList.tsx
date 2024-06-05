import { Button, Card, CardContent, CardHeader, CardMeta, Image, Segment } from "semantic-ui-react";
import { Properties } from "../../app/models/properties"
import { SyntheticEvent, useState } from "react";


interface Props {
    properties: Properties[];
    selectPropertyId: (id: number) => void;
    submiting: boolean;
    deleteProperty: (id: number) => void;
}

export default function PropertiesList({ properties, selectPropertyId, submiting, deleteProperty }: Props) {
    const [target, setTarget] = useState('');

    function handlePropertyDelete(e: SyntheticEvent<HTMLButtonElement>, id: number) {
        setTarget(e.currentTarget.name);
        deleteProperty(id);
    }

    return (
        <Segment>
            <Card.Group divided>
                {properties.map((property) => (
                    <Card key={property.id} clearing>
                        <CardContent>
                            <Image src={property.photoURL}
                            />
                            <CardHeader>{property.title}</CardHeader>
                            <CardMeta>{property.price} {property.currency} </CardMeta>
                        </CardContent>
                        <CardContent extra>
                            <div className="ui three buttons">
                                <Button standard color='olive' onClick={() => selectPropertyId(property.id)}>
                                    View
                                </Button>
                                <Button name={property.id} loading={submiting && target == `${property.id}`} basic color='orange'
                                    onClick={(e) => handlePropertyDelete(e, property.id)}>
                                    Delete
                                </Button>
                            </div>
                        </CardContent>
                    </Card>
                ))}
            </Card.Group>
        </Segment >
    )
}