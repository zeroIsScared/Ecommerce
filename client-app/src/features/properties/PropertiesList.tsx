import { Button, Card, CardContent, CardHeader, CardMeta, Image, Segment } from "semantic-ui-react";
import { Properties } from "../../app/models/properties"
import { SyntheticEvent, useEffect, useState } from "react";
import { useStore } from "../../app/stores/store";
import { Link } from "react-router-dom";




export default function PropertiesList() {
    // const [target, setTarget] = useState('');
    const { propertyStore } = useStore();
    const { properties } = propertyStore;

    // function deleteProperty(id: number) {
    //     setSubmiting(true);
    //     agent.Properties.delete(id).then(() => {
    //       setProperties([...properties.filter(x => x.id !== id)]);
    //       setSubmiting(false);
    //     })
    //   };


    // function handlePropertyDelete(e: SyntheticEvent<HTMLButtonElement>, id: number) {
    //     setTarget(e.currentTarget.name);
    //     deleteProperty(id);
    // }    


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
                                <Button as={Link} to={`/Properties/${property.id}`} standard color='olive' onClick={() => setSelectedPropertyId(property.id)}>
                                    View
                                </Button>
                                {/* <Button name={property.id} loading={submiting && target == `${property.id}`} basic color='orange'
                                    onClick={(e) => handlePropertyDelete(e, property.id)}> */}
                                <Button>
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