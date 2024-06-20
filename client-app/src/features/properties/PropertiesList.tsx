import { Card, Segment } from "semantic-ui-react";
import { SyntheticEvent, useEffect, useState } from "react";
import { useStore } from "../../app/stores/store";
import { Link } from "react-router-dom";
import { observer } from "mobx-react-lite";
import Buttons from "../../app/layout/components/Buttons";
import PropertiesCard from "../../app/layout/components/PropertiesCard";
import FilterProperties from "../../app/layout/components/form/FilterProperties";


export default observer(function PropertiesList() {

    const { propertyStore } = useStore();
    const { properties, addToUserFavorites, userFavorites,
        loadFilteredPropertiesByCategory, filteredPropertiesByCategory,
        setFilteredPropertiesByCategory } = propertyStore;
    const [propertyIdToAdd, setPropertyIdToAdd] = useState<number | undefined>(undefined);
    const [target, setTarget] = useState('');
    const [filter, setFilter] = useState(false);
    const [categoryId, setCategoryId] = useState<string | number | undefined>(undefined)


    const handleAddToUserFavorite = (e: SyntheticEvent<HTMLButtonElement>, propertyId: number) => {
        setTarget(e.currentTarget.name);
        setPropertyIdToAdd(propertyId);
    }
    const handleSubmit = (propertyCategory: string | number) => {
        console.log(propertyCategory);
        setCategoryId(propertyCategory)
        setFilter(true);
    }

    const handleClearFilter = () => {
        setFilter(false);
        setCategoryId(undefined);
        setFilteredPropertiesByCategory(properties);
    }

    useEffect(() => {
        if (propertyIdToAdd && !userFavorites.find(x => x.propertyId === propertyIdToAdd)) {
            addToUserFavorites({ userId: 1, propertyId: propertyIdToAdd });
            setTarget('');
        }
    }, [propertyIdToAdd, addToUserFavorites, userFavorites]);

    useEffect(() => {
        if (categoryId) {
            loadFilteredPropertiesByCategory(categoryId);
        }
    }, [filter, categoryId, loadFilteredPropertiesByCategory]);

    return (
        <Segment>
            <h2>All Properties</h2>
            <hr />
            <FilterProperties
                handleSubmit={handleSubmit}
                filter={filter}
                handleClearFilter={handleClearFilter} />
            <Segment>
                {(filteredPropertiesByCategory.length == 0 && (<h2 style={{ paddingBottom: '0.8em' }}>
                    No properties were loaded</h2>))}
                <Card.Group divided>
                    {filteredPropertiesByCategory.map((property) => (
                        <PropertiesCard
                            property={property}
                            buttonsStyle={''}>
                            <Buttons
                                content={'View'}
                                type={Link}
                                link={`/Properties/`}
                                color={'olive'}
                                id={property.id}
                            />
                            <Buttons
                                content={'Add to favorites'}
                                loading={Number(target) === property.id}
                                color={'orange'}
                                onClick={handleAddToUserFavorite}
                                id={property.id}
                            />
                        </PropertiesCard>))}
                </Card.Group>
            </Segment>
        </Segment >
    )
})