import { Card, Segment } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";
import { Link } from "react-router-dom";
import { observer } from "mobx-react-lite";
import PropertiesCard from "../../app/layout/components/PropertiesCard";
import Buttons from "../../app/layout/components/Buttons";
import { SyntheticEvent, useEffect, useState } from "react";


export default observer(function UserPropertiesList() {

    const { propertyStore } = useStore();
    const { yourProperties, deleteProperty } = propertyStore;

    const [propertyIdDeleted, setPropertyIdDeleted] = useState<number | undefined>(undefined);
    const [target, setTarget] = useState('');

    const handleDeleteProperty = (e: SyntheticEvent<HTMLButtonElement>, propertyId: number) => {
        setPropertyIdDeleted(propertyId);
        setTarget(e.currentTarget.name);
    }

    useEffect(() => {
        if (propertyIdDeleted) {
            deleteProperty(propertyIdDeleted);
            setPropertyIdDeleted(undefined);
        }
    }, [propertyIdDeleted, deleteProperty]);

    return (
        <Segment>
            <Card.Group divided>
                {yourProperties.map((property) => (
                    <PropertiesCard
                        property={property}
                        buttonsStyle=" ">

                        <Buttons
                            content={'View'}
                            type={Link}
                            link={`/Properties/`}
                            color={'olive'}
                            id={property.id}
                        />
                        <Buttons
                            content={'Edit'}
                            type={Link}
                            link={`/editProperty/`}
                            color={'orange'}
                            id={property.id}
                        />
                        <Buttons
                            content={'Delete'}
                            color={'red'}
                            onClick={handleDeleteProperty}
                            id={property.id}
                            loading={Number(target) === property.id}
                        />
                    </PropertiesCard>
                ))}
            </Card.Group>
        </Segment >
    )
})


{/* <Card key={property.id} clearing>
                        <CardContent>
                            <Image src={property.photoURL}
                            />
                            <h4>{property.title}</h4>
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
{/* <Button>
    Delete
</Button>
                            </div >
                        </CardContent >
                    </Card > * /} */}