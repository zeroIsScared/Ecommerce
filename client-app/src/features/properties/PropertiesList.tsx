import { Button, Card, CardContent, CardHeader, CardMeta, Image, Segment } from "semantic-ui-react";
import { useEffect, useState } from "react";
import { useStore } from "../../app/stores/store";
import { Link } from "react-router-dom";
import { observer } from "mobx-react-lite";




export default observer(function PropertiesList() {
    // const [target, setTarget] = useState('');
    const { propertyStore } = useStore();
    const { properties, addToUserFavorites } = propertyStore;

    const [propertyIdToAdd, setPropertyIdToAdd] = useState<number | undefined>(undefined);

    const handleAddToUserFavorite = (propertyId: number) => {
        setPropertyIdToAdd(propertyId);
    }

    useEffect(() => {
        if (propertyIdToAdd) {
            addToUserFavorites({ userId: 3, propertyId: propertyIdToAdd });
        }


    }, [propertyIdToAdd, addToUserFavorites]);

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
    const image = "../../../../public/assets/3BI78kU.jpg";

    return (
        <Segment>
            <Card.Group divided>
                {properties.map((property) => (
                    <Card key={property.id} clearing>
                        <CardContent>
                            <Image src={image}
                            />
                            <h3>{property.title}</h3>
                            <CardMeta>Price: {property.price} {property.currency} </CardMeta>
                        </CardContent>
                        <CardContent extra textAlign="center">
                            <div className="ui small buttons">
                                <Button as={Link} to={`/Properties/${property.id}`} standard color='olive'>
                                    View
                                </Button>
                                {/* <Button name={property.id} loading={submiting && target == `${property.id}`} basic color='orange'
                                    onClick={(e) => handlePropertyDelete(e, property.id)}> */}
                                <Button standard color='orange' onClick={() => handleAddToUserFavorite(property.id)}>
                                    Add to favorites
                                </Button>
                            </div>
                        </CardContent>
                    </Card>
                ))}
            </Card.Group>
        </Segment >
    )
})