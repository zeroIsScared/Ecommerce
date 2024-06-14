import { Button, Card, CardContent, CardHeader, CardMeta, Image, Segment } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";
import { Link } from "react-router-dom";
import { observer } from "mobx-react-lite";




export default observer(function UserPropertiesList() {
    // const [target, setTarget] = useState('');
    const { propertyStore } = useStore();
    const { yourProperties } = propertyStore;

    return (
        <Segment>
            <Card.Group divided>
                {yourProperties.map((property) => (
                    <Card key={property.id} clearing>
                        <CardContent>
                            <Image src={property.photoURL}
                            />
                            <CardHeader>{property.title}</CardHeader>
                            <CardMeta>{property.price} {property.currency} </CardMeta>
                        </CardContent>
                        <CardContent extra>
                            <div className="ui three buttons">
                                <Button as={Link} to={`/Properties/${property.id}`} standard color='olive' >
                                    View
                                </Button>
                                <Button standard color='orange' as={Link} to={`/PropertyFrom/${property.id}`} >
                                    Edit
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
})