import { Grid } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";
import { useEffect } from "react";
import UserPropertiesList from "./UserPropertiesList";




export default function PropertiesDashboard() {
    const { propertyStore } = useStore();

    useEffect(() => {
        propertyStore.loadYourProperties()
    }, [propertyStore]);

    return (
        <Grid padded>
            <Grid.Column width='12'>
                <UserPropertiesList />
            </Grid.Column>
            <Grid.Column width='4'>
                <h2>Property filters</h2>
            </Grid.Column>

        </Grid>
    )
}