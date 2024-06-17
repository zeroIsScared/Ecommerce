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
            <Grid.Column width='16'>
                <UserPropertiesList />
            </Grid.Column>
        </Grid>
    )
}