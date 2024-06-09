import { Grid } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";
import { useEffect } from "react";
import PropertiesList from "../properties/PropertiesList";



export default function PropertiesDashboard() {
    const { propertyStore } = useStore();
    const { userProperties } = propertyStore;



    return (
        <Grid padded>
            <Grid.Column width='12'>

            </Grid.Column>
            <Grid.Column width='4'>
                <h2>Property filters</h2>
            </Grid.Column>

        </Grid>
    )
}