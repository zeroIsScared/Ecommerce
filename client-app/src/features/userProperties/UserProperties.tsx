import { Grid } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";
import { useEffect } from "react";
import UserPropertiesList from "./UserPropertiesList";
import LoadingComponent from "../../app/layout/LoadingComponent";

export default function PropertiesDashboard() {

    const { propertyStore } = useStore();
    const { loading, loadYourProperties, yourProperties } = propertyStore;

    useEffect(() => {
        loadYourProperties()
    }, [propertyStore, loadYourProperties]);

    if (loading == true) return <LoadingComponent content={'Loading favorites properties'} />

    if (loading == false && yourProperties.length === 0) return <h1>No results were loaded!</h1>
    return (
        <Grid padded>
            <Grid.Column width='16'>
                <UserPropertiesList />
            </Grid.Column>
        </Grid>
    )
}