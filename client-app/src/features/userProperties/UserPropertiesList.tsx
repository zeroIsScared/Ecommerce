import { Card, Segment } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";
import { Link } from "react-router-dom";
import { observer } from "mobx-react-lite";
import PropertiesCard from "../../app/layout/components/PropertiesCard";
import Buttons from "../../app/layout/components/Buttons";
import { SyntheticEvent, useEffect, useState } from "react";
import FilterProperties from "../../app/layout/components/form/FilterProperties";


export default observer(function UserPropertiesList() {

    const { propertyStore } = useStore();
    const { yourProperties, deleteProperty } = propertyStore;

    const [propertyIdDeleted, setPropertyIdDeleted] = useState<number | undefined>(undefined);
    const [target, setTarget] = useState('');
    const [filter, setFilter] = useState(false);

    const handleDeleteProperty = (e: SyntheticEvent<HTMLButtonElement>, propertyId: number) => {
        setPropertyIdDeleted(propertyId);
        setTarget(e.currentTarget.name);
    }

    const handleSubmit = async (propertyCategory: number) => {
        setFilter(true);
    }

    const handleClearFilter = () => {
        setFilter(false);
    }

    useEffect(() => {
        if (propertyIdDeleted) {
            deleteProperty(propertyIdDeleted);
            setPropertyIdDeleted(undefined);
        }
    }, [propertyIdDeleted, deleteProperty]);

    return (
        <Segment>
            <h2>Your Properties</h2>
            <hr />
            <FilterProperties
                handleSubmit={handleSubmit}
                filter={filter}
                handleClearFilter={handleClearFilter} />
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
        </Segment>
    )
})


