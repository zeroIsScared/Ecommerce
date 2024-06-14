import { Grid } from "semantic-ui-react";
import PropertiesList from "./PropertiesList";
import { useStore } from "../../app/stores/store";
import { useEffect } from "react";
import { observer } from "mobx-react-lite";



export default observer(function PropertiesDashboard() {
    const { propertyStore } = useStore();

    useEffect(() => {
        propertyStore.loadProperties()
    }, [propertyStore]);

    return (
        <Grid padded>
            <Grid.Column width='12'>
                <PropertiesList />
            </Grid.Column>
            <Grid.Column width='4'>
                <h2>Property filters</h2>
            </Grid.Column>
        </Grid>
    )
})