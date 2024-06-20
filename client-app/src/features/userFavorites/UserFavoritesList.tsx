import { Button, Card, CardContent, CardMeta, Image, Segment } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";
import { Link } from "react-router-dom";
import { observer } from "mobx-react-lite";
import { SyntheticEvent, useEffect, useState } from "react";
import PropertiesCard from "../../app/layout/components/PropertiesCard";
import Buttons from "../../app/layout/components/Buttons";
import MySelectInput from "../../app/layout/components/form/MySelectInput";
import { propertyCategoryOptions } from "../../app/layout/components/options/propertyCategoryOptions";
import { Form, Formik } from "formik";
import FilterProperties from "../../app/layout/components/form/FilterProperties";



export default observer(function UserFavoritesList() {

    const { propertyStore } = useStore();
    const { deleteFromUserFavorites, userFavorites } = propertyStore;
    const [propertyIdDeleted, setPropertyIdDeleted] = useState<number | undefined>(undefined);
    const [filter, setFilter] = useState(false);


    const handleDeleteUserFavorite = (e: SyntheticEvent<HTMLButtonElement>, propertyId: number) => {
        setPropertyIdDeleted(propertyId);
    };

    const handleSubmit = async (propertyCategory: number) => {
        setFilter(true);
    }

    const handleClearFilter = () => {
        setFilter(false);
    }

    useEffect(() => {
        if (propertyIdDeleted) {
            deleteFromUserFavorites({ userId: 1, propertyId: propertyIdDeleted });
        }
    }, [propertyIdDeleted]);

    return (
        <Segment>
            <h2>Your Favorite Properties</h2>
            <hr />
            <FilterProperties
                handleSubmit={handleSubmit}
                filter={filter}
                handleClearFilter={handleClearFilter} />
            <Segment>
                <Card.Group divided>
                    {userFavorites.map(({ property }) => (
                        <PropertiesCard
                            property={property}
                            buttonsStyle={''}
                        >
                            <Buttons
                                content={'View'}
                                type={Link}
                                link={`/Properties/`}
                                color={'olive'}
                                id={property.id}
                            />
                            <Buttons
                                content={'Delete from favorites'}
                                color={'red'}
                                onClick={handleDeleteUserFavorite}
                                id={property.id}
                            />
                        </PropertiesCard>
                    ))}
                </Card.Group>
            </Segment>
        </Segment >
    )
})

